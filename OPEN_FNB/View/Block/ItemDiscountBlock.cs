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
    public partial class ItemDiscountBlock : Form
    {
        public int billID;
        public BillDetails billDetail;
        public ItemDiscountBlock(int billid, BillDetails bd)
        {
            InitializeComponent();
            billID = billid;
            billDetail = bd;

            draw();
        }

        public void draw()
        {
            lb_billid.Text = billID.ToString();
            lb_itemname.Text = billDetail.item_details.name;

            Controller.ToastController.On();
            var list = ItemDiscountDetails.getAllDiscountOfItem(null, billDetail.item);
            Controller.ToastController.Off();

            int index = 0;
            if(list!=null)
            foreach (ItemDiscountDetails idd in list)
            {
                var id =new Label();
                id.Text = idd.itemDiscount.id.ToString();
                id.Location = new Point(0, 5+ 20*index);
                id.Size = new Size(50, 15);
                id.TextAlign = ContentAlignment.MiddleCenter;
                //id.BackColor = Color.Red;
                pn_show.Controls.Add(id);

                var name = new Label();
                name.Text = idd.itemDiscount.name;
                name.Location = new Point(60, 5 + 20 * index);
                name.Size = new Size(200, 15);
                //name.BackColor = Color.Red;
                pn_show.Controls.Add(name);

                var condition = new Label();
                condition.Text = idd.itemDiscount.info;
                condition.Location = new Point(280, 5 + 20 * index);
                condition.Size = new Size(220, 15);
                //condition.BackColor = Color.Red;
                pn_show.Controls.Add(condition);

                var value = new Label();
                value.Text = idd.value + "%";
                value.Location = new Point(515, 5 + 20 * index);
                value.Size = new Size(45, 15);
                value.TextAlign = ContentAlignment.MiddleCenter;
                //value.BackColor = Color.Red;
                pn_show.Controls.Add(value);

                var apply = new CheckBox();
                apply.Location = new Point(595, 5 + 20 * index);
                apply.Size = new Size(15, 15);
                apply.Checked = false;
                if(billDetail.discounts!=null)
                    billDetail.discounts.ForEach(x =>
                    {
                        Console.WriteLine(x.id +" "+ idd.id);
                        if (x.id == idd.id)
                        {
                            
                            apply.Checked = true;
                        }
                    });
                pn_show.Controls.Add(apply);

                apply.CheckedChanged += (s, e) =>
                {
                    var wait = new WaitBlock();
                    wait.Show();
                    if (apply.Checked)
                    {
                        bool check = billDetail.addDiscountToBillDetails(null,idd.id,billDetail.id);
                        if (check)
                        {
                            draw();
                        }
                    }
                    else
                    {
                        bool check = billDetail.deleteDiscountToBillDetails(null, idd.id, billDetail.id);
                        if (check)
                        {
                            draw();
                        }
                    }
                    wait.Dispose();
                };

                index++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            BillDetails.updateLastPriceBillDetails(null, this.billDetail.id);
            this.Close();
        }
    }
}
