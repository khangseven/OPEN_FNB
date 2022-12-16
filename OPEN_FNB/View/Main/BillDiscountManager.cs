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
using System.Windows.Controls;
using System.Windows.Forms;

namespace OPEN_FNB.View.Main
{
    public partial class BillDiscountManager : Form
    {
        public BillDiscountManager()
        {
            InitializeComponent();
            loadBillDiscount();
        }

        void loadBillDiscount()
        {
            //dgv_billdiscount.RowTemplate.MinimumHeight = 300;
            Controller.ToastController.Off();
            var list = BillDiscount.getAll(null);
            if (list != null)
            {
                dgv_billdiscount.Rows.Clear();
                dgv_billdiscount.RowCount= list.Count;
                int index = 0;
                list.ForEach(e => {

                    var temp = new ComboboxItem(e.name,e);

                    dgv_billdiscount.Rows[index].Cells[0].Value = (index + 1).ToString();
                    dgv_billdiscount.Rows[index].Cells[1].Value = temp;
                    dgv_billdiscount.Rows[index].Cells[2].Value = e.info.ToString();
                    dgv_billdiscount.Rows[index].Cells[3].Value = e.start.ToString("dd/MM/yyyy HH:mm") + Environment.NewLine + "đến" + Environment.NewLine + e.end.ToString("dd/MM/yyyy HH:mm");
                    dgv_billdiscount.Rows[index].Cells[4].Value = e.value.ToString() + "%";

                    index++;
                });
            }

            selectedBillDiscount = null;
            lb_id.Text = "_";
            name.Text = "Hãy chọn 1 khuyến mãi";
            info.Text = "";
            start.Text = "_";
            end.Text = "_";
            value.Text = "_";
        }

        BillDiscount selectedBillDiscount = null;
        private void dgv_billdiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var bd = (dgv_billdiscount.Rows[e.RowIndex].Cells[1].Value as ComboboxItem).Value as BillDiscount;

            lb_id.Text = bd.id.ToString();
            name.Text = bd.name;
            info.Text = bd.info.ToString();
            start.Text = bd.start.ToString("dd/MM/yyyy HH:mm");
            end.Text = bd.end.ToString("dd/MM/yyyy HH:mm");
            value.Text = bd.value.ToString();

            selectedBillDiscount = bd;

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void info_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDiscountBlock adb = new AddDiscountBlock(true);
            var rs = adb.ShowDialog();
            if(rs == DialogResult.OK)
            {
                var bd = adb.bd;
                Controller.ToastController.On();
                var check = bd.saveBillDiscount(null);
                Controller.ToastController.Off();
                if (check)
                {
                    loadBillDiscount();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text.Trim().Length == 0 || info.Text.Trim().Length == 0)
                return;
            if (selectedBillDiscount != null)
            {
                selectedBillDiscount.name = name.Text;
                selectedBillDiscount.info = info.Text;
                Controller.ToastController.On();
                var rs =  selectedBillDiscount.updateBillDiscount(null);
                Controller.ToastController.Off();
                if (rs)
                {
                    loadBillDiscount();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedBillDiscount != null)
            {
                Controller.ToastController.On();
                var rs = selectedBillDiscount.deleteBillDiscount(null);
                Controller.ToastController.Off();

                if (rs)
                {
                    loadBillDiscount();
                }
            }
        }

        
    }
}
