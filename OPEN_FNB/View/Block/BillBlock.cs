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

namespace OPEN_FNB.View.Block
{
    public partial class BillBlock : UserControl
    {

        public Bill bill;
        public List<BillDetails> billDetails;

        public bool isIdle;
        public Main.Selling sellingControl;



        public BillBlock(int billID, Main.Selling sellingControl)
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += (s, e) => {
                if(bill==null) return;
                TimeSpan stayTime = DateTime.Now.Subtract(bill.checkin);
                time.Text = $"{String.Format("{0:0.##}", Math.Floor(stayTime.TotalHours))} Giờ{System.Environment.NewLine}{String.Format("{0:0.##}", stayTime.Minutes)} Phút";
            };
            timer.Start();
            this.sellingControl = sellingControl;
            if (billID != -1)
            {
                bill = Bill.getBillByID(null, billID);
                Console.WriteLine("da layb xong bill");
                billDetails = BillDetails.getAllByBillId(null, bill.id);
                isIdle = false;
            }	
            else
            {
                isIdle = true;
            }
            draw();
        }

        public void draw()
        {
            if (isIdle)
            {
                bill_id.Text = "Chưa có";
                bill_staff.Text = "Chưa có";
                bill_checkin.Text = "Chưa có";
                bill_total.Text = "0";
                bill_pay.Text = "0";
                time.Text = "0";

                pn_billdetails.Controls.Clear();
                pb_billdiscounts.Controls.Clear();

                btn_pay.Enabled = false;
                btn_phuthu.Enabled = false;
                btn_changetb.Enabled = false;
                btn_cancel.Enabled = false;

                return;
            }


            int index=0;
            int totalVisai = 0;
            int visai = 0;
            var font = new Font("Arial", 11, FontStyle.Regular);

            int billTotal=0;

            pn_billdetails.Controls.Clear();

        if(billDetails!=null)
            foreach(BillDetails billDetail in billDetails)
            {
                var panel = new Panel();
                panel.Size = new Size(290,50);
                panel.Location = new Point(0,5 + index*5 + index * 50 + totalVisai);
                //panel.BackColor = Color.Aqua;


                var number = new Label();
                number.Text = (index+1).ToString();
                number.Location = new Point(10, 10);
                number.Size = new Size(30, 20);
                number.Font = font;
                number.TextAlign = ContentAlignment.MiddleCenter;
                panel.Controls.Add(number);

                //Console.WriteLine(billDetail.item_details.name);
                var name= new Label();
                name.Text = billDetail.item_details==null ? "null" : billDetail.item_details.name ;
                name.Location = new Point(50, 10);
                name.Size = new Size(190, 20);
                name.Font = font;
                name.ForeColor = billDetail.item==-1 ? Color.Red : Color.Black;
                //name.BackColor = Color.AliceBlue;
                panel.Controls.Add(name);

                var amount = new Label();
                amount.Text = 'x'+billDetail.amount.ToString();
                amount.Location = new Point(245, 10);
                amount.Size = new Size(50, 20);
                amount.Font = font;
                amount.TextAlign = ContentAlignment.MiddleCenter;
                //amount.BackColor = Color.AliceBlue;
                panel.Controls.Add(amount);

                int discountIndex = 0;
                if (billDetail.discounts != null)
                {
                    foreach (ItemDiscountDetails idd in billDetail.discounts)
                    {
                        var button = new Button();
                        button.Location = new Point(105, 4 + 30 + 20 * discountIndex);
                        button.Size = new Size(12,12);
                        button.BackColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 0;
                        button.BackgroundImage = Properties.Resources.close_64px;
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        button.Click += (s,e) => {
                            DialogResult rs = MessageBox.Show("Xóa khuyến mãi này?","Xóa Khuyến Mãi!",MessageBoxButtons.YesNo);
                            if(rs == DialogResult.Yes)
                            {
                                billDetail.deleteDiscountToBillDetails(null, idd.id, billDetail.id);
                                BillDetails.updateLastPriceBillDetails(null, billDetail.id);
                                Bill.updateTotalBill(null, bill.id);
                                sellingControl.clickSelectedTable();
                            } 
                        };
                        panel.Controls.Add(button);

                        var discount = new Label();
                        discount.Text = idd.itemDiscount.name;
                        discount.Location = new Point(120, 30 + 20 * discountIndex);
                        discount.Size = new Size(130, 20);
                        discount.TextAlign = ContentAlignment.MiddleLeft;
                        discount.BackColor = Color.AliceBlue;
                        panel.Controls.Add(discount);
                        
                        var value = new Label();
                        value.Text = idd.value + "%";
                        value.Location = new Point(240, 30 + 20* discountIndex);
                        value.Size = new Size(40, 20);
                        //discount.BackColor = Color.AliceBlue;
                        value.TextAlign = ContentAlignment.MiddleRight;
                        value.Font = new Font("Arial", 8, FontStyle.Bold);
                        panel.Controls.Add(value);
                        panel.Height += 20;
                        discountIndex++;
                        visai += 20;
                    }
                    
                    }
                else
                {
                    visai = 0;
                    /*var total = new Label();
                    total.Text = Item.intToVnd(billDetail.last_price);
                    total.Location = new Point(180, 30);
                    total.Size = new Size(100, 15);
                    total.Font = new Font("Arial", 11, FontStyle.Regular);
                    total.TextAlign = ContentAlignment.MiddleRight;
                    panel.Controls.Add(total);
                    billTotal += billDetail.last_price;*/

                       /* var discountButton = new Button();
                        discountButton.Location = new Point(20, 30);
                        discountButton.Size = new Size(15, 15);
                        discountButton.Text = "*";
                        panel.Controls.Add(discountButton);
                        discountButton.Click += (s, e) =>
                        {
                            DialogResult rs =  new ItemDiscountBlock(bill.id,billDetail).ShowDialog();
                            if (rs == DialogResult.OK)
                            {
                                sellingControl.clickSelectedTable();
                            }
                        };*/

                }
                visai += 5;
                panel.Height += 10;
                var total = new Label();
                total.Text = Item.intToVnd(billDetail.last_price);
                total.Location = new Point(180, 30 + visai + 5);
                total.Size = new Size(100, 15);
                total.Font = new Font("Arial", 11, FontStyle.Regular);
                total.TextAlign = ContentAlignment.MiddleRight;
                panel.Controls.Add(total);
                billTotal += billDetail.last_price;


                #region phim chuc nan
                var discountButton = new Label()
                {
                    Location = new Point(20, 30 + visai + 5),
                    Size = new Size(30, 15),
                    Text = "KM",
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Khaki,
                    TextAlign = ContentAlignment.MiddleCenter,

                };
                discountButton.Click += (s, e) =>
                {
                    DialogResult rs = new ItemDiscountBlock(bill.id, billDetail).ShowDialog();
                    if (rs == DialogResult.OK)
                    {
                        Bill.updateTotalBill(null, bill.id);
                        sellingControl.clickSelectedTable();
                    }
                };
                panel.Controls.Add(discountButton);
                

                var deleteButton = new Label()
                {
                    Location = new Point(100, 30 + visai + 5),
                    Size = new Size(30, 15),
                    Text = "Hủy",
                    FlatStyle= FlatStyle.Flat,
                    BackColor=Color.IndianRed,
                    TextAlign = ContentAlignment.MiddleCenter

                };
                deleteButton.Click += (s, e) =>
                {
                    DialogResult rs = MessageBox.Show("Xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if(rs == DialogResult.Yes)
                    {
                        WaitBlock wait = new WaitBlock();
                        wait.Show();
                        bool check = billDetail.deteleBillDetails(null,billDetail.id);
                        if (check)
                        {
                            Bill.updateTotalBill(null, bill.id);
                            Controller.ToastController.addSureToast(2,"Xóa sản phẩm trong hóa đơn thành công!");
                        }else Controller.ToastController.addSureToast(3, "Xóa sản phẩm trong hóa đơn thành công!");
                        wait.Dispose();
                        sellingControl.clickSelectedTable();
                    }
                };
                panel.Controls.Add(deleteButton);
                

                var numberButton = new Label()
                {
                    Location = new Point(60, 30 + visai + 5),
                    Size = new Size(30, 15),
                    Text = "SL",
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.DodgerBlue,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                numberButton.Click += (s, e) =>
                {
                    NumberInputBlock num = new NumberInputBlock(billDetail.amount,null);
                    
                    DialogResult rs = num.ShowDialog();
                    int n = num.Number;
                    if(rs == DialogResult.OK)
                    {
                        billDetail.amount = n;
                        
                        bool check = billDetail.updateBillDetails(null);
                        if (check)
                        {
                            Bill.updateTotalBill(null, bill.id);
                            Controller.ToastController.addSureToast(2, "cập nhật SL sản phẩm trong hóa đơn thành công!");
                        }
                        else Controller.ToastController.addSureToast(3, "cập nhật SL sản phẩm trong hóa đơn thành công!");
                    }
                    sellingControl.clickSelectedTable();
                };
                panel.Controls.Add(numberButton);
                
                #endregion

                panel.Controls.Add(new Label(){ Height = 1, Location=new Point(10,panel.Height-2), BackColor = Color.Black , Width=280});
                pn_billdetails.Controls.Add(panel);

                totalVisai += visai;
                visai = 0;
                index++;
            }

            bill_id.Text = bill.id.ToString();
            bill_staff.Text = bill.username;
            bill_checkin.Text = bill.checkin.ToString("dd/MM/yyyy HH:mm");
            TimeSpan stayTime = DateTime.Now.Subtract(bill.checkin);
            time.Text = $"{String.Format("{0:0.##}", Math.Floor(stayTime.TotalHours))} Giờ{System.Environment.NewLine}{String.Format("{0:0.##}",stayTime.Minutes)} Phút";

            bill_total.Text = Item.intToVnd(billTotal);

            int bdindex = 0;
            if(bill.discounts!=null)
                foreach(BillDiscount billdiscount in bill.discounts)
                {
                    var bdid = new Label()
                    {
                        Text = (bdindex+1).ToString(),
                        Location = new Point(10, 5 + bdindex * 25),
                        Size = new Size(25, 15),
                        //BackColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    pb_billdiscounts.Controls.Add(bdid);

                    var bdname = new Label()
                    {
                        Text = billdiscount.name,
                        Location = new Point(45, 5 + bdindex * 25),
                        Size=new Size(200,15),
                        //BackColor = Color.White,
                    };
                    pb_billdiscounts.Controls.Add(bdname);

                    var bdvalue = new Label()
                    {
                        Text = billdiscount.value + "%",
                        Location = new Point(260, 5+ bdindex * 25),
                        Size = new Size(30, 15),
                        //BackColor = Color.White,
                        TextAlign=ContentAlignment.MiddleCenter
                    };
                    pb_billdiscounts.Controls.Add(bdvalue);

                    var line = new Label() { Height = 1, Location = new Point(10, 5 + bdindex * 25 + 15 + 2), BackColor = Color.Black, Width = 280 };
                    pb_billdiscounts.Controls.Add(line);

                    bdindex++;
                }
            bill_pay.Text = Item.intToVnd(bill.total);
            btn_pay.Enabled = true;
            btn_phuthu.Enabled = true;
            btn_changetb.Enabled = true;
            btn_cancel.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_billdiscount_Click(object sender, EventArgs e)
        {
            BillDiscountBlock billDiscountBlock = new BillDiscountBlock(bill);
            var rs = billDiscountBlock.ShowDialog();
            if(rs == DialogResult.OK)
            {
                sellingControl.clickSelectedTable();
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show($"Xác nhận thanh toán hóa đơn {bill.id}","Xác nhận",MessageBoxButtons.YesNo);
            if (rs != DialogResult.Yes) return;

            if (bill.id == -1 || bill == null)
            {
                return;
            }
            bill.complete = true;
            bill.updateBill(null);
            Controller.ToastController.addSureToast(2, $"Thanh toán thành công hóa đơn {bill.id} tổng {Item.intToVnd(bill.total)}");
            sellingControl.loadTable();
            sellingControl.selectedTable = null;
            sellingControl.resetTitle();
            this.bill.id = -1;
            this.isIdle = true;
            
            draw();
        }

        private void btn_phuthu_Click(object sender, EventArgs e)
        {
            StringInputBlock sib = new StringInputBlock("Nhập lý do phụ phu...");
            var rs = sib.ShowDialog();
            if(rs == DialogResult.OK)
            {
                string reason = sib.text;
                NumberInputBlock nib = new NumberInputBlock(1000, "Nhập số tiền phụ thu!");
                var rs_ = nib.ShowDialog();
                if(rs_ == DialogResult.OK)
                {
                    int price = nib.Number;

                    BillDetails bd = new BillDetails(bill.id, -1, price, 1, price, reason, true, 1);
                    Controller.ToastController.On();
                    bool temp = bd.saveBillDetails(null);
                    Controller.ToastController.Off();

                    sellingControl.clickSelectedTable();
                }
            }
        }

        private void btn_changetb_Click(object sender, EventArgs e)
        {
            //lay vao ban muon chuyen
            NumberInputBlock sib = new NumberInputBlock(1, "Nhập mã bàn muốn chuyển đến.");
            DialogResult rs = sib.ShowDialog();
            if (rs == DialogResult.OK)
            {
                int tableID = sib.Number;
                //Check if table does not exists;
                var table = Table.getTableById(null,tableID);
                if (table != null)
                {
                    //check if table not free
                    string condition = $"t.id = {tableID} && b.complete=0";
                    var bills = Bill.getAllWithCondition(null, condition);
                    if (bills == null)
                    {
                        //change table
                        bill.table_id = tableID;
                        bill.updateBill(null);
                        Controller.ToastController.addSureToast(2, "Chuyển bàn thành công.");
                        sellingControl.loadTable();
                        sellingControl.selectedTable = null;
                        sellingControl.resetTitle();
                        this.bill.id = -1;
                        this.isIdle = true;
                        draw();
                    }
                    else
                    {
                        Controller.ToastController.addSureToast(3, "Bàn này đã có người ngồi.");
                    }
                }
                else
                {
                    Controller.ToastController.addSureToast(3, "Không tìm thấy mã bàn đã nhập");
                }
            }

            
            
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show($"Xác nhận HỦY hóa đơn {bill.id}", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs != DialogResult.Yes) return;

            if (bill.id == -1 || bill == null)
            {
                return;
            }

            bill.deleteALlDiscountofBill(null, bill.id);
            if(billDetails!=null)
            foreach (BillDetails bd in billDetails)
            {
                bd.deteleBillDetails(null, bd.id);
            }
            if (bill.deleteBill(null))
            {
                Controller.ToastController.addSureToast(2, $"Hủy thành công hóa đơn {bill.id}!");
                sellingControl.loadTable();
                sellingControl.selectedTable = null;
                sellingControl.resetTitle();
                this.bill.id = -1;
                this.isIdle = true;

                draw();
            }
            
            
        }
    }
}
