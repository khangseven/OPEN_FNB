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

namespace OPEN_FNB.View.Block
{
    public partial class BillDiscountBlock : Form
    {
        public Bill bill;
        public BillDiscountBlock(Bill b)
        {
            InitializeComponent();
          
            this.bill = b;

            draw();
        }

        public void draw()
        {
            lb_billid.Text = bill.id.ToString();

            Controller.ToastController.On();
            var list = BillDiscount.getAllAvailable(null);
            Controller.ToastController.Off();

            int index = 0;
            if(list!=null)
            foreach (BillDiscount bd in list)
            {
                var id =new Label();
                id.Text = bd.id.ToString();
                id.Location = new Point(0, 5+ 20*index);
                id.Size = new Size(50, 15);
                id.TextAlign = ContentAlignment.MiddleCenter;
                //id.BackColor = Color.Red;
                pn_show.Controls.Add(id);

                var name = new Label();
                name.Text = bd.name;
                name.Location = new Point(60, 5 + 20 * index);
                name.Size = new Size(200, 15);
                //name.BackColor = Color.Red;
                pn_show.Controls.Add(name);

                var condition = new Label();
                condition.Text = bd.info;
                condition.Location = new Point(280, 5 + 20 * index);
                condition.Size = new Size(220, 15);
                //condition.BackColor = Color.Red;
                pn_show.Controls.Add(condition);

                var value = new Label();
                value.Text = bd.value + "%";
                value.Location = new Point(515, 5 + 20 * index);
                value.Size = new Size(45, 15);
                value.TextAlign = ContentAlignment.MiddleCenter;
                //value.BackColor = Color.Red;
                pn_show.Controls.Add(value);

                var apply = new CheckBox();
                apply.Location = new Point(595, 5 + 20 * index);
                apply.Size = new Size(15, 15);
                apply.Checked = false;

                if(bill.discounts!=null)
                    bill.discounts.ForEach(x =>
                    {
                        if (x.id == bd.id)
                        {
                            apply.Checked = true;
                        }
                    });
                pn_show.Controls.Add(apply);

                    //Controller.ToastController.On();

                apply.CheckedChanged += (s, e) =>
                {
                    var wait = new WaitBlock();
                    wait.Show();
                    if (apply.Checked)
                    {
                        bool check = bill.addDiscountToBill(null,bd.id,bill.id);
                        draw();
                    }
                    else
                    {
                        bool check = bill.deleteDiscountToBill(null, bd.id, bill.id);
                        draw();
                    }
                    wait.Dispose();
                };

                index++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Bill.updateTotalBill(null, bill.id);
            this.Close();
        }
    }
}
