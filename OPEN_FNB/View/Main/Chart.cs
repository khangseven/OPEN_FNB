using OPEN_FNB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OPEN_FNB.View.Main
{
    public partial class Chart : UserControl
    {
        public Chart()
        {
            InitializeComponent();
        }

        void bill(bool condition)
        {
            string s = "";
            if (condition)
            {
                s = " && b.checkin >= '" + dtp_start.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' && b.checkout <= '" + dtp_end.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' ";

            }

            Console.WriteLine(s);
            var list = Bill.getAllWithCondition(null, " b.complete = 1 " + s);
            if (list == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào phù hợp!");
                return;
            }

            int total = 0;
            int ta_total = 0;
            int no_total = 0;
            int slmuave = 0;
            int sltaiban = 0;
            int tgmuave = 0;
            int tgtaiban = 0;
            int tgtotal = 0;
            int night=0;
            int day = 0;

            chart_total.Series[0].Points.Clear();
            chart_time.Series[0].Points.Clear();
            chart_type.Series[0].Points.Clear();
            chart_discount.Series[0].Points.Clear();
            chart_night.Series[0].Points.Clear();
            chart_xh.Series[0].Points.Clear();

            list.ForEach(b =>
            {
                total += b.total;
                
                TimeSpan t=  b.checkout.Subtract(b.checkin);
                tgtotal +=(int) t.TotalMinutes;

                if (b.table_id == 0)
                {
                    ta_total += b.total;
                    slmuave++;

                    tgmuave += (int)t.TotalMinutes;
                }
                else
                {
                    no_total+=b.total;
                    sltaiban++;

                    tgtaiban += (int)t.TotalMinutes;
                }

                if (b.checkin.Hour > 18)
                {
                    night++;
                }
                else day++;

            });

            chart_total.Series[0].Points.AddXY("Mang về",ta_total);
            chart_total.Series[0].Points.AddXY("Tại bàn", no_total);
            chart_total.Series[0].XValueMember = "Name";
            chart_total.Series[0].YValueMembers = "Count";
            chart_total.Series[0].IsValueShownAsLabel = true;

            chart_type.Series[0].Points.AddXY("Mang Về", slmuave);
            chart_type.Series[0].Points.AddXY("Tại bàn", sltaiban);
            chart_type.Series[0].XValueMember = "Name";
            chart_type.Series[0].YValueMembers = "Count";
            chart_type.Series[0].IsValueShownAsLabel = true;

            chart_time.Series[0].Points.AddXY("Mang Về", slmuave==0 ? 0 : tgmuave / slmuave);
            chart_time.Series[0].Points.AddXY("Tại bàn", sltaiban==0 ? 0: tgtaiban / sltaiban);
            chart_time.Series[0].XValueMember = "Name";
            chart_time.Series[0].YValueMembers = "Count";
            chart_time.Series[0].IsValueShownAsLabel = true;

            chart_night.Series[0].Points.AddXY("Trước 18h", day);
            chart_night.Series[0].Points.AddXY("Sau 18h", night);
            chart_night.Series[0].XValueMember = "Name";
            chart_night.Series[0].YValueMembers = "Count";
            chart_night.Series[0].IsValueShownAsLabel = true;
            //
            var conn = View.Login.Login.conn;
            try
            {
                var cmd = new MySqlCommand($"SELECT count(*),checkin FROM `bill` WHERE checkin BETWEEN CURDATE() - INTERVAL 30 DAY AND CURDATE() GROUP BY DATE_FORMAT(checkin, '%Y%m%d');", conn);
                var rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        chart_xh.Series[0].Points.AddXY(rs.GetDateTime(1).ToString("dd/MM"), rs.GetInt16(0));
                    }
                    chart_xh.Series[0].XValueMember = "Name";
                    chart_xh.Series[0].YValueMembers = "Count";
                    chart_xh.Series[0].IsValueShownAsLabel = true;
                    rs.Close();
                }
                else
                {
                    rs.Close();
                }
            }
            catch (Exception e)
            {
                Controller.ToastController.addToast(4, $"Lỗi khi thống kê!{System.Environment.NewLine}Chi tiết: {e.Message}");
            }

            try
            {
                var cmd = new MySqlCommand($"select  (SELECT count(bill) as a2 from list_bill_discount),(SELECT count(bill_details) as a1 from list_item_discount);", conn);
                var rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        chart_discount.Series[0].Points.AddXY("Hóa đơn",rs.GetInt16(0));
                        chart_discount.Series[0].Points.AddXY("Sản phẩm", rs.GetInt16(1));
                    }
                    chart_discount.Series[0].XValueMember = "Name";
                    chart_discount.Series[0].YValueMembers = "Count";
                    chart_discount.Series[0].IsValueShownAsLabel = true;
                    rs.Close();
                }
                else
                {
                    rs.Close();
                }
            }
            catch (Exception e)
            {
                Controller.ToastController.addToast(4, $"Lỗi khi thống kê!{System.Environment.NewLine}Chi tiết: {e.Message}");
            }
        }

        private void dtp_start_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_start.Value > dtp_end.Value)
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

        private void Chart_Load(object sender, EventArgs e)
        {
            Controller.ToastController.Off();
            bill(false);
        }

        private void chart_total_Click(object sender, EventArgs e)
        {

        }

        private void chart_time_Click(object sender, EventArgs e)
        {

        }
    }
}
