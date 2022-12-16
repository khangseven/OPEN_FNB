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

namespace OPEN_FNB.View.Main
{
    public partial class Statistic : UserControl
    {
        public Statistic()
        {
            InitializeComponent();
            

        }
        private void Statistic_Load(object sender, EventArgs e)
        {
            Controller.ToastController.Off();
            bill(false);
            cb_type.SelectedIndex = 0;
        }

        Bill selectedBill = null;
        void bill(bool condition)
        {
            string s = "";
            if (condition)
            {
                s = " && b.checkin >= '"+ dtp_start.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' && b.checkout <= '"+ dtp_end.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
                
            }
            if (cb_type.SelectedIndex == 2)
            {
                s += " && t.id!=0";
            }
            else if (cb_type.SelectedIndex == 1)
            {
                s += " && t.id=0";
            }
            Console.WriteLine(s);
            var list = Bill.getAllWithCondition(null, " b.complete = 1 " + s);
            if (list == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào phù hợp!");
                return;
            }
            
            dgv.Rows.Clear();
            dgv.RowCount = list.Count;
            int index = 0;
            int total = 0;
            list.ForEach(b => {

                ComboboxItem temp = new ComboboxItem(b.id.ToString(), b);

                dgv.Rows[index].Cells[0].Value = temp;
                dgv.Rows[index].Cells[1].Value = b.table_type_name;
                dgv.Rows[index].Cells[2].Value = b.username;
                dgv.Rows[index].Cells[3].Value = b.checkin.ToString("G");
                dgv.Rows[index].Cells[4].Value = b.checkout.ToString("G");
                dgv.Rows[index].Cells[5].Value = b.total.ToString();
                total += b.total;
                index++;
            });
            lb_all.Text = "Tổng cộng: " + Item.intToVnd(total);
            bill_id.Text = "Chưa có";
            bill_staff.Text = "Chưa có";
            bill_checkin.Text = "Chưa có";
            bill_total.Text = "0";
            bill_pay.Text = "0";
            time.Text = "0";
            pn_billdetails.Controls.Clear();
            pb_billdiscounts.Controls.Clear();
            selectedBill = null;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            selectedBill = ((dgv.Rows[e.RowIndex].Cells[0].Value as ComboboxItem).Value as Bill);
            if(selectedBill!=null)
                loadBillDetails();

        }

        void loadBillDetails()
        {
            int index = 0;
            int totalVisai = 0;
            int visai = 0;
            var font = new Font("Arial", 11, FontStyle.Regular);

            int billTotal = 0;

            var billDetails = BillDetails.getAllByBillId(null, selectedBill.id);
            pn_billdetails.Controls.Clear();
            pb_billdiscounts.Controls.Clear();

            if (billDetails != null)
                foreach (BillDetails billDetail in billDetails)
                {
                    var panel = new Panel();
                    panel.Size = new Size(290, 50);
                    panel.Location = new Point(0, 5 + index * 5 + index * 50 + totalVisai);
                    //panel.BackColor = Color.Aqua;


                    var number = new Label();
                    number.Text = (index + 1).ToString();
                    number.Location = new Point(10, 10);
                    number.Size = new Size(30, 20);
                    number.Font = font;
                    number.TextAlign = ContentAlignment.MiddleCenter;
                    panel.Controls.Add(number);

                    //Console.WriteLine(billDetail.item_details.name);
                    var name = new Label();
                    name.Text = billDetail.item_details == null ? "null" : billDetail.item_details.name;
                    name.Location = new Point(50, 10);
                    name.Size = new Size(190, 20);
                    name.Font = font;
                    name.ForeColor = billDetail.item == -1 ? Color.Red : Color.Black;
                    //name.BackColor = Color.AliceBlue;
                    panel.Controls.Add(name);

                    var amount = new Label();
                    amount.Text = 'x' + billDetail.amount.ToString();
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

                            var discount = new Label();
                            discount.Text = idd.itemDiscount.name;
                            discount.Location = new Point(120, 30 + 20 * discountIndex);
                            discount.Size = new Size(130, 20);
                            discount.TextAlign = ContentAlignment.MiddleLeft;
                            discount.BackColor = Color.AliceBlue;
                            panel.Controls.Add(discount);

                            var value = new Label();
                            value.Text = idd.value + "%";
                            value.Location = new Point(240, 30 + 20 * discountIndex);
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


                    pn_billdetails.Controls.Add(panel);

                    totalVisai += visai;
                    visai = 0;
                    index++;
                }
            var bill = selectedBill;
            bill_id.Text = bill.id.ToString();
            bill_staff.Text = bill.username;
            bill_checkin.Text = bill.checkin.ToString("dd/MM/yyyy HH:mm");
            TimeSpan stayTime = bill.checkout.Subtract(bill.checkin);
            time.Text = $"{String.Format("{0:0.##}", Math.Floor(stayTime.TotalHours))} Giờ{System.Environment.NewLine}{String.Format("{0:0.##}", stayTime.Minutes)} Phút";

            bill_total.Text = Item.intToVnd(billTotal);

            int bdindex = 0;
            if (bill.discounts != null)
                foreach (BillDiscount billdiscount in bill.discounts)
                {
                    var bdid = new Label()
                    {
                        Text = (bdindex + 1).ToString(),
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
                        Size = new Size(200, 15),
                        //BackColor = Color.White,
                    };
                    pb_billdiscounts.Controls.Add(bdname);

                    var bdvalue = new Label()
                    {
                        Text = billdiscount.value + "%",
                        Location = new Point(260, 5 + bdindex * 25),
                        Size = new Size(30, 15),
                        //BackColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    pb_billdiscounts.Controls.Add(bdvalue);

                    var line = new Label() { Height = 1, Location = new Point(10, 5 + bdindex * 25 + 15 + 2), BackColor = Color.Black, Width = 280 };
                    pb_billdiscounts.Controls.Add(line);

                    bdindex++;
                }
            bill_pay.Text = Item.intToVnd(bill.total);
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_start.Value > dtp_end.Value)
            {
                dtp_start.Value = dtp_end.Value;
                MessageBox.Show("Thời gian bắt đầu phải trước kết thúc.");
            }
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_start.Value > dtp_end.Value)
            {
                dtp_end.Value = dtp_start.Value;
                MessageBox.Show("Thời gian bắt đầu phải trước kết thúc.");
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            bill(true);
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            bill(false);
        }

        
    }
}
