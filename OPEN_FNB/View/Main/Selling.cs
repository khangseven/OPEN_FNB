using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPEN_FNB.Model;
using OPEN_FNB.View.Block;

namespace OPEN_FNB.View.Main
{
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
            Controller.ToastController.Off();
        }

        public Block.TableBlock selectedTable = null;
        Block.BillBlock billBlock = null;
        public User user;
        public Action refresh;

        private void Selling_Load(object sender, EventArgs e)
        {
            //UI
            browse_order.Items.Clear();
            browse_order.Items.Add(new ComboboxItem("Sắp xếp theo tên (A-Z)", "order by i.name ASC"));
            browse_order.Items.Add(new ComboboxItem("Sắp xếp theo tên (Z-A)", "order by i.name DESC"));
            browse_order.Items.Add(new ComboboxItem("Giá tăng dần", "order by i.price ASC"));
            browse_order.Items.Add(new ComboboxItem("Giá giảm dần", "order by i.price DESC"));
            browse_order.SelectedIndex = 0;
            loadItemType();

            browse_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            browse_name.AutoSize = false; //Allows you to change height to have bottom padding
            browse_name.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });

            pn_tables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pn_tables.AutoSize = false; //Allows you to change height to have bottom padding
            pn_tables.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Top, BackColor = Color.DimGray });

            pn_itemsOrder.VerticalScroll.Visible = true;

            pn_items.Location = new System.Drawing.Point(0, 20);
            pn_tables.Location = new System.Drawing.Point(0, 20);
            pn_itemdiscount.Location = new System.Drawing.Point(0, 20);
            pn_billdiscount.Location = new System.Drawing.Point(0, 20);

            //pn_items.Visible = false;

            //UI

            #region load

            loadTable();
            loadItem();
            loadItemDiscount();
            loadBillDiscount();

            #endregion

            #region addsomething

            btn_table.Tag = pn_tables;
            btn_menu.Tag = pn_items;
            btn_itemdiscount.Tag = pn_itemdiscount;
            btn_billdiscount.Tag = pn_billdiscount;

            #endregion

        }

        private void Tb_TableClicked(object sender, EventArgs e)
        {
            lb_thongbao.Visible = false;

            var table = (Block.TableBlock) sender;
            selectedTable = table;
            
            bill_pictureType.Image = table.Id==0 ? Properties.Resources.take_away_food_64px : Properties.Resources.table_64px_white_select;
            bill_table.Text = (table.Id == 0 ? "Mang đi" : "Tại quán") + " / " + table.name + " / " + table.type;

            pn_billblock.Controls.Clear();

            if(table.Bill != -1)
            {
                if (table.Id == 0)
                {
                    string condition = $"t.id = {table.Id} && b.id={table.Bill} && b.complete=0";

                    var bill = Bill.getAllWithCondition(null, condition)[0];

                    Block.BillBlock bl = new Block.BillBlock(bill.id, this);
                    bl.Location = new Point(0, 0);
                    pn_billblock.Controls.Add((bl));
                    billBlock = bl;
                }
                else
                {
                    string condition = $"t.id = {table.Id} && b.complete=0";

                    var bill = Bill.getAllWithCondition(null, condition)[0];

                    Block.BillBlock bl = new Block.BillBlock(bill.id, this);
                    bl.Location = new Point(0, 0);
                    pn_billblock.Controls.Add((bl));
                    billBlock = bl;
                }

            }
            else
            {
                Block.BillBlock bl = new Block.BillBlock(-1, this);
                bl.Location = new Point(0, 0);
                pn_billblock.Controls.Add((bl));
                billBlock = bl;
                return;
            }
    
        }

        private void Tb_SelectedChanged(object sender, EventArgs e)
        {
            List<Block.TableBlock> tableBlocks = new List<Block.TableBlock>();
            foreach(var ctrl in pn_tables.Controls)
            {
                if(ctrl is Block.TableBlock) tableBlocks.Add((Block.TableBlock)ctrl);
            }

            foreach(var tb in tableBlocks)
            {
                if (tb == sender) continue;
                tb.Selected = false;
                tb.reDraw();
            }
        }

        void loadItemType()
        {

            var listItemType = ItemType.getAll(null);
            browse_type.Items.Clear();

            ComboboxItem i_ = new ComboboxItem("Tất cả", null);
            //detail_itemtype.Items.Add(i_);
            browse_type.Items.Add(i_);

            listItemType.ForEach(item =>
            {
                ComboboxItem i = new ComboboxItem(item.name, item);

                browse_type.Items.Add(i);
            });

            if (browse_type.Items.Count != 0) browse_type.SelectedIndex = 0;

        }

        void loadItem()
        {
            string type = "";
            if (browse_type.SelectedIndex != 0)
            {
                type = $"&& i.item_type = { (((ComboboxItem)browse_type.SelectedItem).Value as ItemType).id}";
            }

            string name = browse_name.Text;

            string condition = $"where i.name like '%{name}%' && i.isAvailable=true {type} {(browse_order.SelectedItem as ComboboxItem).Value}";

            Console.WriteLine($"select i.id,i.name,i.price,i.image,i.isAvailable,i.isProcessed,i.item_type,it.name,it.unit from item i join item_type it on i.item_type = it.id {condition}");

            List<Item> list = Item.getAllWithCondition(null, condition);

            if (list == null || list.Count == 0)
            {
                return;
            }

            pn_itemsOrder.Controls.Clear();

            int index = 0;
            int rowIndex = 0;
            list.ForEach(item =>
            {

                var block = new Block.ItemBlock_Simple(item.image, item.name,item.getPriceVND(),item);
                block.Location = new System.Drawing.Point(index * 150 + 5 * index + 14, rowIndex * 170 + 5 * rowIndex + 5);
                pn_itemsOrder.Controls.Add(block);

                block.ItemClick += (s, e) => {
                    if(e is MouseEventArgs)
                    {
                        MouseButtons mouse = ((MouseEventArgs)e).Button;
                        int amount = 0;
                        if (MouseButtons.Left == mouse)
                        {
                            //string rs = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng món muốn thêm!","Thêm sản phẩm","Chỉ nhận số nguyên.");
                            using (Block.NumberInputBlock numberInput = new Block.NumberInputBlock())
                            {
                                DialogResult rs = numberInput.ShowDialog();
                                if (rs == DialogResult.OK)
                                {
                                    amount = numberInput.Number;
                                }
                            }
                        }
                        else
                        {
                            amount = 1;
                        }
                        if (amount == 0) return;
                        if (selectedTable == null)
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn để thêm sản phẩm này!");
                            return;
                        }
                        if (selectedTable.Bill == -1)
                        {
                            Bill b = new Bill(selectedTable.Id, user.id, DateTime.Now, new DateTime(), 0, false, "");
                            bool rs = b.saveBill(null);
                            if (rs)
                            {
                                int billID = Table.getTableById(null, selectedTable.Id).bill;
                                selectedTable.Bill = billID;
                                selectedTable.reDraw();
                            }
                            else
                            {
                                return;
                            }
                        }

                        BillDetails bd = new BillDetails(selectedTable.Bill, item.id, item.price * amount, amount, item.price * amount, "", true, 1);
                        Controller.ToastController.On();
                        bool temp = bd.saveBillDetails(null);
                        Controller.ToastController.Off();

                        if (temp == true) clickSelectedTable();
                    }
                    else
                    {
                        //MessageBox.Show(e.ToString());
                    }
                    
                    
                };

                index++;

                if (index % 4 == 0)
                {
                    rowIndex++;
                    index = 0;
                }
              
            });
        }

        void loadItemDiscount()
        {
            List<ItemDiscount> list = ItemDiscount.getAllAvailable(null);
            if (list != null)
            {
                dgv_itemdiscount.Rows.Clear();
                dgv_itemdiscount.RowCount = list.Count;
                int index = 0;
                list.ForEach(e => {
                    
                    dgv_itemdiscount.Rows[index].Cells[0].Value = (e.id).ToString();
                    dgv_itemdiscount.Rows[index].Cells[1].Value = e.name.ToString();
                    dgv_itemdiscount.Rows[index].Cells[2].Value = e.info.ToString();
                    dgv_itemdiscount.Rows[index].Cells[3].Value = e.start.ToString("dd/MM/yyyy HH:mm") + Environment.NewLine+"đến" +Environment.NewLine + e.end.ToString("dd/MM/yyyy HH:mm");
                    dgv_itemdiscount.Rows[index].Cells[4].Value = "Xem";


                    index++;
                });
            }
        }
        private void dgv_itemdiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                
                List<ItemDiscountDetails> list = ItemDiscountDetails.getAllItemOf1Discount(null, Int32.Parse(dgv_itemdiscount.Rows[e.RowIndex].Cells[0].Value.ToString()));
                string items = "";
                foreach(ItemDiscountDetails i in list)
                {
                    items+=i.item.name.ToString() + $"({i.value.ToString()}%)" + Environment.NewLine;
                }
                MessageBox.Show(items);
            }
        }   

        void loadBillDiscount()
        {
            List<BillDiscount> list = BillDiscount.getAllAvailable(null);
            if (list != null)
            {
                dgv_billdiscount.Rows.Clear();
                dgv_billdiscount.RowCount = list.Count;
                int index = 0;
                list.ForEach(e => {

                    dgv_billdiscount.Rows[index].Cells[0].Value = (index+1).ToString();
                    dgv_billdiscount.Rows[index].Cells[1].Value = e.name.ToString();
                    dgv_billdiscount.Rows[index].Cells[2].Value = e.info.ToString();
                    dgv_billdiscount.Rows[index].Cells[3].Value = e.start.ToString("dd/MM/yyyy HH:mm") + Environment.NewLine + "đến" + Environment.NewLine + e.end.ToString("dd/MM/yyyy HH:mm");
                    dgv_billdiscount.Rows[index].Cells[4].Value = e.value.ToString()+"%";


                    index++;
                });
            }
        }

        public void loadTable()
        {
            pn_tables.Controls.Clear();
            List<Table> tables = Table.getAllWithCondition(null, " && t.id!=0 Order by t.name ASC ");
            selectedTable = null;
            int index = 0;
            int yIndex = 0;
            foreach (Table table in tables)
            {
                var tb = new Block.TableBlock();
                tb.init(table.name, table.type_name, table.id, table.bill);
                tb.Location = new System.Drawing.Point(index * 100 + 10 * index + 5, 10 + 100*yIndex);
                pn_tables.Controls.Add(tb);
                index++;
                if (index == 6)
                {
                    index = 0;
                    yIndex++;
                }
                tb.SelectedChanged += Tb_SelectedChanged;
                tb.TableClicked += Tb_TableClicked;
            }

            pn_tables.Controls.Add(new Label() { Height = 1, Location = new Point(20, 20 + 100 * yIndex + 100), BackColor = Color.Black, Width = 620 });
            
            //====================Mang Ve===========================
            
            index = 1;
            yIndex++;

            var btn_add = new Button()
            {
                Location = new System.Drawing.Point(5 + 20, 20 + 30 + 100 * yIndex),
                Size = new System.Drawing.Size(60, 60),
                //Text = "Add",
                FlatStyle = FlatStyle.Flat,
                //BackColor = Color.Beige,
                BackgroundImage = Properties.Resources.add_shopping_cart_50px,
                BackgroundImageLayout = ImageLayout.Center
            };
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.Click += (s, e) => {
                string text = "";
                using (StringInputBlock sib = new StringInputBlock("Nhập thông tin khách!"))
                {
                    var rs = sib.ShowDialog();
                    if (rs == DialogResult.OK)
                    {
                        text = sib.text;
                       // Controller.ToastController.On();
                        Bill b = new Bill(0, user.id, DateTime.Now, new DateTime(), 0, false, text);
                        //Controller.ToastController.Off();
                        var check = b.saveBill(null);
                        if (check)
                        {
                            Controller.ToastController.addSureToast(2, $"Thêm hóa đơn mang về '{text}' thành công!");
                            loadTable();
                        }
                        else
                        {
                            Controller.ToastController.addSureToast(3, $"Thêm hóa đơn mang về '{text}' thất bại!");
                        }
                    }
                }
            };
            pn_tables.Controls.Add(btn_add);

            //Controller.ToastController.On();
            List<Bill> bills = Bill.getAllWithCondition(null, " t.id=0 && b.complete=false Order by b.checkin DESC ");
            if (bills != null)
            {
                Console.WriteLine(bills.Count.ToString());
                foreach (Bill b in bills)
                {
                    Console.WriteLine("id bill " + b.id);
                    var tb = new Block.TableBlock();
                    tb.init(b.customer_reviews, b.checkin.ToString("HH:mm"), 0, b.id);
                    tb.Location = new System.Drawing.Point(index * 100 + 10 * index + 5, 30 + 100 * yIndex);
                    pn_tables.Controls.Add(tb);
                    index++;
                    if (index == 6)
                    {
                        index = 0;
                        yIndex++;
                    }
                    tb.SelectedChanged += Tb_SelectedChanged;
                    tb.TableClicked += Tb_TableClicked;
                }
            }
            

            #region timer;
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (s, e) =>
            {

                List<Table> tabletemp = Table.getAllWithCondition(null, " && t.id!=0 Order by t.name ASC ");
                List<Bill> billtemp = Bill.getAllWithCondition(null, " t.id=0 && b.complete=false Order by b.checkin DESC ");
                if((billtemp != null && bills == null)|| billtemp == null && bills != null)
                {
                    loadTable();
                    timer.Dispose();
                    return;
                }else if( billtemp!=null && bills!=null && billtemp.Count != bills.Count)
                {
                    loadTable();
                    timer.Dispose();
                    return;
                }
                if (tabletemp.Count != tables.Count)
                {
                    loadTable();
                    timer.Dispose();
                    return;
                }
                else
                {
                    int i = 0;
                    foreach (Table t in tables)
                    {
                       
                        if (t.bill != tabletemp[i].bill)
                        {
                            loadTable();
                            timer.Dispose();
                            return;
                        }
                        i++;
                    }
                }

            };
            timer.Start();
            #endregion
        }

        public void resetTitle()
        {
            bill_pictureType.Image= null;
            bill_table.Text = "Hãy chọn một bàn nào";
        }

        public void clickSelectedTable()
        {
            if (selectedTable!= null)
                Tb_TableClicked(selectedTable, null);
        }

        void handleClick(object sender, EventArgs e)
        {
            pn_bottom.BackColor = (sender as Control).BackColor;

            pn_tables.Visible = false;
            pn_items.Visible = false;
            pn_billdiscount.Visible = false;
            pn_itemdiscount.Visible = false;

            ((sender as Button).Tag as Panel).Location = new Point(0,20);
            ((sender as Button).Tag as Panel).Visible = true;
            ((sender as Button).Tag as Panel).Refresh();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loadItem();
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            handleClick(sender, e);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            handleClick(sender, e);
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            handleClick(sender, e);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_billdiscount_Click(object sender, EventArgs e)
        {
            handleClick(sender, e);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
