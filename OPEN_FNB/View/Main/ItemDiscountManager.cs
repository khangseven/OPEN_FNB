using OPEN_FNB.Model;
using OPEN_FNB.View.Block;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPEN_FNB.View.Main
{
    public partial class ItemDiscountManager : UserControl
    {
        public ItemDiscountManager()
        {
            InitializeComponent();
            loadItemDiscount();
        }

        ItemDiscount selectedItemDiscount = null;
        //ItemDiscountDetails idd = null;
        void loadItemDiscount()
        {
            var list = ItemDiscount.getAll(null);
            int index = 0;
            dgv_itemdiscount.RowCount = list.Count;
            if(list!=null)
                list.ForEach(e => {

                    ComboboxItem temp = new ComboboxItem(e.name, e);

                    dgv_itemdiscount.Rows[index].Cells[0].Value = e.id.ToString();
                    dgv_itemdiscount.Rows[index].Cells[1].Value = temp;
                    dgv_itemdiscount.Rows[index].Cells[2].Value = e.info;
                    dgv_itemdiscount.Rows[index].Cells[3].Value = e.start.ToString("dd/MM/yyyy HH:mm") + Environment.NewLine + "đến" + Environment.NewLine + e.end.ToString("dd/MM/yyyy HH:mm");
                    
                    index++;
                });

            lb_id.Text = "Chưa xác định";
            name.Text = "Hãy chọn một khuyến mãi";
            info.Text = "";
            start.Text = "_";
            end.Text = "_";
            lb_id_2.Text = "Chưa xác định";
            selectedItemDiscount = null;
            pn_itemdiscount.Controls.Clear();
            pn_items.Controls.Clear();
        }

        private void dgv_itemdiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            selectedItemDiscount = (dgv_itemdiscount.Rows[e.RowIndex].Cells[1].Value as ComboboxItem).Value as ItemDiscount;
            loadItemInDiscount();

            lb_id.Text = selectedItemDiscount.id.ToString();
            name.Text = selectedItemDiscount.name.ToString();
            info.Text = selectedItemDiscount.info.ToString();
            start.Text = selectedItemDiscount.start.ToString("dd/MM/yyyy HH:mm");
            end.Text = selectedItemDiscount.end.ToString("dd/MM/yyyy HH:mm");

            string t = tb_itemname.Text;
            if (t.Trim().Length == 0) t = "";
            loadItem(t);
        }

        void loadItem(string name)
        {
            pn_items.Controls.Clear();
            //Controller.ToastController.On();
            var list = Item.getAllByName(null, name);
            //Controller.ToastController.Off();
            int index = 0;
            if (list != null)
                list.ForEach(e => { 
                    var stt = new Label()
                    {
                        Text = index.ToString(),
                        Location = new Point(10,index * 20 + 5),
                        Size = new Size(30,15)
                    };
                    pn_items.Controls.Add(stt);

                    var lbname = new Label()
                    {
                        Text = e.name,
                        Location = new Point(50, index * 20 + 5),
                        Size = new Size(220, 15)
                    };
                    pn_items.Controls.Add(lbname);

                    var btn = new Button()
                    {
                        Location = new Point(280, index * 20 + 5),
                        Size = new Size(15, 15),
                        BackgroundImage = Properties.Resources.add_64px,
                        FlatStyle = FlatStyle.Flat,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        Tag = false
                    };
                    btn.FlatAppearance.BorderSize = 0;
                    var l = ItemDiscountDetails.getAllItemOf1Discount(null, selectedItemDiscount.id);
                    if(l != null)
                    {
                        l.ForEach(idd => { 
                            if(idd.item.id == e.id)
                            {
                                btn.BackgroundImage = Properties.Resources.done_64px;
                                btn.Tag = true;
                            }
                        });
                    }

                    btn.Click += (os, ev) => {
                        if (((bool)btn.Tag))
                        {
                            MessageBox.Show("Sản phẩm này đã được thêm trước đó!");
                        }
                        else
                        {
                            var nib = new NumberInputBlock(1, 100, "Nhập % giảm sản phẩm");
                            var rs = nib.ShowDialog();
                            if (rs == DialogResult.OK)
                            {
                                Controller.ToastController.On();
                                var check = selectedItemDiscount.addItemToItemDiscount(null,e.id,nib.Number);
                                Controller.ToastController.Off();
                                if (check)
                                {
                                    loadItemDiscount();
                                }
                            }
                        }
                    };

                    pn_items.Controls.Add(btn);

                    index++;
                });
        }

        void loadItemInDiscount()
        {
            pn_itemdiscount.Controls.Clear();
            lb_id_2.Text = selectedItemDiscount.id.ToString();
            if(selectedItemDiscount != null)
            {
                var list = ItemDiscountDetails.getAllItemOf1Discount(null, selectedItemDiscount.id);
                int index = 0;
                if (list != null)
                    list.ForEach(e => {
                        var stt = new Label()
                        {
                            Text = index.ToString(),
                            Location = new Point(10, index * 20 + 5),
                            Size = new Size(30, 15)
                        };
                        pn_itemdiscount.Controls.Add(stt);

                        var lbname = new Label()
                        {
                            Text = e.item.name,
                            Location = new Point(50, index * 20 + 5),
                            Size = new Size(180, 15)
                        };
                        pn_itemdiscount.Controls.Add(lbname);

                        var v = new Label()
                        {
                            Text = e.value.ToString() + "%",
                            Location = new Point(230, index * 20 + 5),
                            Size = new Size(40, 15)
                        };
                        pn_itemdiscount.Controls.Add(v);

                        var btn = new Label()
                        {
                            //Text = e.value.ToString() + "%",
                            Location = new Point(280, index * 20 + 5),
                            Size = new Size(15, 15),
                            BackgroundImage = Properties.Resources.close_64px,
                            FlatStyle = FlatStyle.Flat,
                            BackgroundImageLayout = ImageLayout.Zoom,

                        };
                        pn_itemdiscount.Controls.Add(btn);

                        btn.Click += (s, item) => {
                            var rs = MessageBox.Show("Xác nhận xóa sản phẩm trong khuyến mãi này?", "Xác nhận", MessageBoxButtons.YesNo);
                            if(rs == DialogResult.Yes)
                            {
                                Controller.ToastController.On();
                                var check = selectedItemDiscount.deleteItemFromItemDiscount(null,e.item.id);
                                Controller.ToastController.Off();
                                if (check)
                                {
                                    loadItemDiscount();
                                }
                            }
                        };

                        index++;
                    });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDiscountBlock adb = new AddDiscountBlock(false);
            var rs = adb.ShowDialog();
            if (rs == DialogResult.OK)
            {
                var id = adb.id;
                Controller.ToastController.On();
                var check = id.saveItemDiscount(null);
                Controller.ToastController.Off();
                if (check)
                {
                    loadItemDiscount();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text.Trim().Length == 0 || info.Text.Trim().Length == 0)
                return;
            if (selectedItemDiscount != null)
            {
                selectedItemDiscount.name = name.Text;
                selectedItemDiscount.info = info.Text;
                Controller.ToastController.On();
                var rs = selectedItemDiscount.updateItemDiscount(null);
                Controller.ToastController.Off();
                if (rs)
                {
                    loadItemDiscount();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedItemDiscount != null)
            {
                Controller.ToastController.On();
                var rs = selectedItemDiscount.deleteItemDiscount(null);
                Controller.ToastController.Off();

                if (rs)
                {
                    loadItemDiscount();
                }
            }
        }
    }
}
