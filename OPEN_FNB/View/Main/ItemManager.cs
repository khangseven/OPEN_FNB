using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OPEN_FNB.Model;

namespace OPEN_FNB.View.Main
{
    public partial class ItemManager : Form
    {
        private bool isUpdate = false;

        private Item currentItem;
        
        public ItemManager()
        {
            InitializeComponent();
        }

        private void ItemManager_Load(object sender, EventArgs e)
        {
            Controller.ToastController.Off();
            tg_view.setText("Dạng Bảng", "Dạng Lưới");
            tg_view.StatusChanged += Tg_view_StatusChanged;
            

            loadItemType();

            //Set order
            browse_order.Items.Clear();
            browse_order.Items.Add(new ComboboxItem("Sắp xếp theo tên (A-Z)", "order by i.name ASC"));
            browse_order.Items.Add(new ComboboxItem("Sắp xếp theo tên (Z-A)", "order by i.name DESC"));
            browse_order.Items.Add(new ComboboxItem("Giá tăng dần", "order by i.price ASC"));
            browse_order.Items.Add(new ComboboxItem("Giá giảm dần", "order by i.price DESC"));
            browse_order.Items.Add(new ComboboxItem("Sản phẩm chế biến sẵn", "order by i.isProcessed"));
            browse_order.Items.Add(new ComboboxItem("Sản phẩm ngừng bán", "order by i.isAvailable"));
            browse_order.SelectedIndex = 0;

            //turn off
            detail_price.Controls[0].Hide();

            loadData();

            addItemGui();

            toggleImage();
            
            browseItemGuiUpdate();

            Controller.ToastController.On();

            browse_FindById_CheckedChanged(browse_FindById, null);
        }

        private void Tg_view_StatusChanged(object sender, EventArgs e)
        {
            if (tg_view.Status)
            {
                dgv.Visible = true;
                blockview.Visible = false;
            }
            else
            {
                dgv.Visible = false;
                blockview.Visible = true;
            }
        }

        void loadData()
        {

            if (browse_min.Value > browse_max.Value)
            {
                Controller.ToastController.addSureToast(3, "Giá min không thể lớn hơn giá max!");
                return;
            }

            string id = "";
            if (browse_FindById.Checked)
            {
                id = $"&& i.id = {browse_id.Value}";
            }

            string price = "";
            if (browse_toggle_price.Checked)
            {
                price = $"&& i.price > {browse_min.Value} && i.price < {browse_max.Value}";
            }

            string type = "";
            if(cb_type.SelectedIndex != 0)
            {
                type = $"&& i.item_type = { (((ComboboxItem)cb_type.SelectedItem).Value as ItemType).id}";
            }

            string name = browse_name.Text;

            string status = "";
            if (browse_toggle_status.Checked)
            {
                status = $"&& i.isProcessed = {browse_isProcessed.Checked} && i.isAvailable = {browse_isAvailable.Checked}";
            }
            
            

            string condition = $"where i.name like '%{name}%' {id} {price} {type} {status} {(browse_order.SelectedItem as ComboboxItem).Value}";

            Console.WriteLine($"select i.id,i.name,i.price,i.image,i.isAvailable,i.isProcessed,i.item_type,it.name,it.unit from item i join item_type it on i.item_type = it.id {condition}");

            List<Item> list = Item.getAllWithCondition(null,condition);
            
            if ( list == null || list.Count == 0)
            {
                //Controller.ToastController.addSureToast(3, "Khong tim thay san pham nao tuong ung!");
                dgv.RowCount = 0;
                
                return;
            }
            dgv.RowCount = list.Count;
            blockview.Controls.Clear();
            int index = 0;
            int index2 = 0;
            list.ForEach(item =>
            {
                if (item.id != -1)
                {
                    dgv.Rows[index].Cells[0].Value = item.id;
                    dgv.Rows[index].Cells[1].Value = item.name;
                    dgv.Rows[index].Cells[2].Value = item.image;
                    dgv.Rows[index].Cells[3].Value = item.price;
                    dgv.Rows[index].Cells[4].Value = item.type_name;
                    dgv.Rows[index].Cells[5].Value = item.isProcessed ? "Có sẵn" : "Chế biến";
                    dgv.Rows[index].Cells[6].Value = item.isAvailable ? "Còn bán" : "Ngừng bán";

                    //blockview
                    int padding = 40;
                    int blockPerRow = 4;
                    var block = new Block.ItemBlock(item.image, item.name, $"{item.price} VND", Color.AliceBlue, Color.Green, Color.DeepPink)
                    {
                        Location = new Point(padding + index2 * 150 + index2 * 30, padding + (index / blockPerRow) * 10 + 190 * (index / blockPerRow)),
                    };
                    blockview.Controls.Add(block);
                    index2++;
                    if (index2 >= blockPerRow)
                    {
                        index2 = 0;
                    }
                    block.id = item.id;
                    block.Click += Block_Click;
                    //=====

                    index++;
                }
                else dgv.RowCount -= 1; 
                
            });
        }

        private void Block_Click(object sender, EventArgs e)
        {
            int id = (sender as View.Block.ItemBlock).id;
            Controller.ToastController.Off();
            //Console.WriteLine("chi tiet "+id);
            if (id == -1)
                currentItem = new Item();
            else
                currentItem = Item.getItemById(null, id);
            Controller.ToastController.On();
            showItemGui();
            showItem();

            detail_info.Text = "";
        }

        void loadItemType()
        {

            var listItemType = ItemType.getAll(null);

            detail_itemtype.Items.Clear();
            cb_type.Items.Clear();

            ComboboxItem i_ = new ComboboxItem("Tất cả", null);
            //detail_itemtype.Items.Add(i_);
            cb_type.Items.Add(i_);

            listItemType.ForEach(item =>
            {
                ComboboxItem i = new ComboboxItem(item.name, item);
                detail_itemtype.Items.Add(i);
                cb_type.Items.Add(i);
            });

            if (detail_itemtype.Items.Count != 0) detail_itemtype.SelectedIndex = 0;
            if (cb_type.Items.Count != 0) cb_type.SelectedIndex = 0;

        }

        void toggleImage()
        {
            if (!ck_showImage.Checked)
            {
                ck_showImage.BackColor = Color.OrangeRed;
                ck_showImage.ForeColor = Color.White;

                dgv.Columns[2].Visible = false;
            }
            else
            {
                ck_showImage.BackColor = Color.SpringGreen;
                ck_showImage.ForeColor = Color.BlueViolet;

                dgv.Columns[2].Visible = true;
            }
            dgv.Update();
            dgv.Refresh();
        }

        void showItem()
        {
            detail_id.Text = currentItem.id.ToString();
            detail_name.Text = currentItem.name;
            detail_image.Image = currentItem.image;
            detail_image.SizeMode = PictureBoxSizeMode.Zoom;

            detail_price.Text = currentItem.price.ToString();

            if (currentItem.type==0)
            {
                detail_itemtype.SelectedIndex = 0;
            }
            else
            {
                int index = 0;
                foreach (ComboboxItem item in detail_itemtype.Items)
                {
                    if ((item.Value as ItemType).id == currentItem.type)
                    {
                        detail_itemtype.SelectedIndex = index;
                        break;
                    }
                    index++;
                }
            }
            

            detail_isProcessed.Checked = currentItem.isProcessed;
            detail_isAvailable.Checked = currentItem.isAvailable;
        }

        void addItemGui()
        {
            Detail_title.Text = "THÊM MỚI";
            currentItem = new Item();
            detail_btn_add.Enabled = true;
            detail_btn_cancel.Enabled = true;
            detail_btn_delete.Enabled = false;
            detail_btn_update.Enabled = false;

            detail_btn_add.Visible = true;
            detail_btn_cancel.Visible = true;
            detail_btn_delete.Visible = false;
            detail_btn_update.Visible = false;

            detail_id.Text = "Hiện chưa có ID";
            detail_name.Text = "";
            detail_info.Text = "Hãy điền đầy đủ các thông tin về sản phẩm";
            detail_image.Image = null;
            detail_isAvailable.Checked = true;
            detail_isProcessed.Checked = true;
            detail_price.Value = 0;
        }

        void showItemGui()
        {
            if(dgv.RowCount == 0)
            {
                //addItemGui();
                
                return;
            }
            Detail_title.Text = "CHI TIẾT";

            detail_btn_add.Enabled = false;
            detail_btn_cancel.Enabled = false;
            detail_btn_delete.Enabled = true;
            detail_btn_update.Enabled = true;

            detail_btn_add.Visible = false;
            detail_btn_cancel.Visible = false;
            detail_btn_delete.Visible = true;
            detail_btn_update.Visible = true;
        }

        void browseItemGuiUpdate()
        {
            
        }

        
        void test()
        {
            currentItem = new Item();
            showItem();
            //pn_detail.Visible = !pn_detail.Visible;
            //pn_detail.Location = new Point(pn_detail.Location.X + 10, pn_detail.Location.Y);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            toggleImage();
        }



        private void cb_itemtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdate) detail_info.Text = "Thông tin đã được thay đổi!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*blockview.Visible = true;
            dgv.Visible = false;*/
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            isUpdate = true;
            //int id = Int32.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            //currentItem = Item.getItemById(null, id);
            int id = Int32.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
            Controller.ToastController.Off();
            //Console.WriteLine("chi tiet "+id);
            if (id == -1)
                currentItem = new Item();
            else
                currentItem = Item.getItemById(null, id);
            Controller.ToastController.On();
            showItemGui();
            showItem();
            
            detail_info.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            addItemGui();
           // showItem();
        }

        private void detail_image_select_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh bạn muốn sử dụng...";
                dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    detail_image.Image = new Bitmap(dialog.FileName);
                    detail_image.SizeMode = PictureBoxSizeMode.Zoom;
                    if (isUpdate) detail_info.Text = "Thông tin đã được thay đổi!";
                    currentItem.image = (Bitmap)detail_image.Image;
                }
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            loadData(); 
        }

        private void detail_isProcessed_CheckedChanged(object sender, EventArgs e)
        {
            currentItem.isProcessed = detail_isProcessed.Checked;
            if(isUpdate) detail_info.Text = "Thông tin đã được thay đổi!";
        }

        private void detail_isAvailable_CheckedChanged(object sender, EventArgs e)
        {
            currentItem.isAvailable = detail_isAvailable.Checked;
            if (isUpdate) detail_info.Text = "Thông tin đã được thay đổi!";
        }

        private void browse_toggle_price_CheckedChanged(object sender, EventArgs e)
        {
            browseItemGuiUpdate();
        }

        private void browse_toggle_status_CheckedChanged(object sender, EventArgs e)
        {
            browseItemGuiUpdate();
        }

        private void browse_min_ValueChanged(object sender, EventArgs e)
        {
            

            if (browse_min.Value > browse_max.Value)
                browse_max.Value = browse_min.Value;
        }

        private void browse_max_ValueChanged(object sender, EventArgs e)
        {
            if (browse_max.Value < browse_min.Value)
                browse_min.Value = browse_max.Value;
        }

        private void browse_FindById_CheckedChanged(object sender, EventArgs e)
        {
            browse_id.Enabled = (sender as CheckBox).Checked;
        }

        private void detail_name_TextChanged(object sender, EventArgs e)
        {
            currentItem.name = detail_name.Text;
            if (isUpdate) detail_info.Text = "Thông tin đã được thay đổi!";
        }

        private void detail_price_ValueChanged(object sender, EventArgs e)
        {
            currentItem.price = (int)(sender as NumericUpDown).Value;
            if (isUpdate) detail_info.Text = "Thông tin đã được thay đổi!";
        }

        private void detail_btn_cancel_Click(object sender, EventArgs e)
        {
            //pn_detail.Dispose();
            //dgv.Size = new Size(1076, dgv.Height);
            addItemGui();
            //showItem();
        }

        private void detail_btn_add_Click(object sender, EventArgs e)
        {
            currentItem.type = ((detail_itemtype.SelectedItem as ComboboxItem).Value as ItemType).id;
            currentItem.isAvailable = detail_isAvailable.Checked;
            currentItem.isProcessed = detail_isProcessed.Checked;
            
            if(currentItem.name == null || currentItem.price == 0)
            {
                Controller.ToastController.addToast(3, "Hãy điền đầy đủ các thông tin để thực hiện thêm sản phẩm");
                return;
            }
            Console.WriteLine(currentItem.type);
            var rs = currentItem.saveItem(null);
            if(rs)
            {
                loadData();
                addItemGui();
            }
        }
        private void detail_btn_update_Click(object sender, EventArgs e)
        {
            currentItem.type = ((detail_itemtype.SelectedItem as ComboboxItem).Value as ItemType).id;
            if (currentItem.name == null || currentItem.price == 0)
            {
                Controller.ToastController.addToast(3, "Hãy điền đầy đủ các thông tin để thực hiện thêm sản phẩm");
                return;
            }
            var rs = currentItem.updateItem(null);
            if (rs)
            {
                Controller.ToastController.Off();
                loadData();
                showItem();
                Controller.ToastController.Off();
            }
        }

        private void detail_clearImg_Click(object sender, EventArgs e)
        {
            detail_image.Image = null;
            if (isUpdate) detail_info.Text = "Thông tin đã được thay đổi!";
            currentItem.image = null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
