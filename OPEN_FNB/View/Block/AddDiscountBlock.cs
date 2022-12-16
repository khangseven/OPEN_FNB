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
    public partial class AddDiscountBlock : Form
    {
        public BillDiscount bd { get; set; }
        public ItemDiscount id { get; set; }
        public AddDiscountBlock(bool isBillDiscount)
        {
            InitializeComponent();
            if (isBillDiscount)
            {
                
            }
            else
            {
                _value.Visible = false;

            }
        }

       

        private void start_ValueChanged(object sender, EventArgs e)
        {
            if (_start.Value > _end.Value)
            {
                _start.Value = _end.Value;
                MessageBox.Show("Ngày bắt đầu phải trước hoặc bằng ngày kết thúc!");
            }
        }

        private void end_ValueChanged(object sender, EventArgs e)
        {
            if (_start.Value > _end.Value)
            {
                _end.Value = _start.Value;
                MessageBox.Show("Ngày kết thúc phải sau hoặc bằng ngày kết thúc!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ok
            if (_start.Value > _end.Value)
            {
                _start.Value = _end.Value;
                MessageBox.Show("Ngày bắt đầu phải trước hoặc bằng ngày kết thúc!");
            }
            else if(_name.Text.Trim().Length==0 || _info.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nhập đầy đủ các thông tin!");
            }
            else
            {
                bd=new BillDiscount(false,_name.Text,(int)_value.Value,_info.Text,_start.Value,_end.Value);
                id= new ItemDiscount(false, _name.Text, _info.Text, _start.Value, _end.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
