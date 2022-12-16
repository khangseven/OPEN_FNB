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
    public partial class UserManager : UserControl
    {
        public UserManager()
        {
            InitializeComponent();
            loadUser();
        }

        User selectedUser = null;
        void loadUser()
        {
            var list = User.getAllNoAd(null);
            dgv.RowCount = list.Count;
            int index = 0;
            if (list != null)
            {
                list.ForEach(e => {

                    ComboboxItem temp = new ComboboxItem(e.name, e);

                    dgv.Rows[index].Cells[0].Value = e.id.ToString();
                    dgv.Rows[index].Cells[1].Value = temp;
                    dgv.Rows[index].Cells[2].Value = e.password;
                    dgv.Rows[index].Cells[3].Value = e.info;
                    index++;
                    
                });
            }
            selectedUser = null;
            id.Text = "Hãy chọn 1 user";
            name.Text = "";
            pass.Text = "";
            info.Text = "";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            selectedUser = (dgv.Rows[e.RowIndex].Cells[1].Value as ComboboxItem).Value as User;
            id.Text = selectedUser.id.ToString();
            name.Text = selectedUser.name.ToString();
            pass.Text = selectedUser.password;
            info.Text = selectedUser.info;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                Controller.ToastController.On();
                var rs = selectedUser.deleteUser(null);
                Controller.ToastController.Off();

                if (rs)
                {
                    loadUser();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User();
            StringInputBlock sib = new StringInputBlock("Nhập tên người dùng");
            var rs = sib.ShowDialog();
            if (rs == DialogResult.OK)
            {
                u.name = sib.text;
                StringInputBlock sib1 = new StringInputBlock("Nhập mật khẩu người dùng");
                rs = sib1.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    u.password = sib1.text;
                    StringInputBlock sib2 = new StringInputBlock("Nhập thông tin người dùng");
                    rs = sib2.ShowDialog();
                    if (rs == DialogResult.OK)
                    {
                        u.info = sib2.text;
                        u.role = 1;
                        if( u.name == null || u.password==null || u.name.Trim().Length == 0 || u.password.Trim().Length==0)
                        {
                            MessageBox.Show("Tên và mật khẩu bắt buộc phải có!");
                            return;
                        }
                        Controller.ToastController.On();
                        var check = u.saveUser(null);
                        Controller.ToastController.Off();
                        if (check)
                        {
                            loadUser();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {

                selectedUser.name = name.Text;
                selectedUser.info = info.Text;
                selectedUser.password = pass.Text;
                if (selectedUser.name == null || selectedUser.password == null || selectedUser.name.Trim().Length == 0 || selectedUser.password.Trim().Length == 0)
                {
                    MessageBox.Show("Tên và mật khẩu bắt buộc phải có!");
                    return;
                }
                Controller.ToastController.On();
                var rs = selectedUser.updateUser(null);
                Controller.ToastController.Off();

                if (rs)
                {
                    loadUser();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringInputBlock sib2 = new StringInputBlock("Nhập mật khẩu mới");
            var rs = sib2.ShowDialog();
            if (rs == DialogResult.OK)
            {
                if (sib2.text == null || sib2.text.Trim().Length == 0)
                {
                    MessageBox.Show("Mật khẩu không thể trống");
                }
                Controller.ToastController.On();
                var check = User.updateAdmin(null, sib2.text);
                Controller.ToastController.Off();
                if (check)
                {
                    loadUser();
                }
            }
        }
    }
}
