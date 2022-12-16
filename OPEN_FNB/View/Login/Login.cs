using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OPEN_FNB.Model;

namespace OPEN_FNB.View.Login
{
    public partial class Login : Form
    {
        public static MySqlConnection conn { get; set; }
        public Login()
        {
            InitializeComponent();
            connectToDB();
            sClick();
        }
        void connectToDB()
        {
            conn = MySQL.MySQLConnection.getMySQLConnection("127.0.0.1", "3306", "openfab", "quantrivien", "123");
            try
            {
                Console.WriteLine("Database connecting...");
                conn.Open();
                Console.WriteLine("Database connection successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            
        }

        private void sClick()
        {

            //t.addToast(new Random().Next(4)+1, "hello");

            //t.addToast(new Random().Next(4) + 1, Model.User.checkUser(conn,2).ToString());

            //Controller.ToastController.addToast(1, new Model.User("khang","123","hehe",1).saveUser(conn).ToString());

            /* Model.Table.getAll(null).ForEach(table =>
             {
                 Console.WriteLine(table.name);
             });*/

            //pictureBox1.Image = Model.Item.getItemById(null, 4).image;
            /*Model.Item item = Model.Item.getItemById(null, 3);
            item.image = new Bitmap(pictureBox1.Image);
            item.updateItem(null);*/

            //Controller.ToastController.off();
            //Model.BillDiscount.getAll(null).ForEach(x => {Controller.ToastController.addToast(1, x.name); });
            /*Bitmap bm = Model.Item.getItemById(null, 6).image;
            for (int i = 0; i < 10; i++)
            {
                var block = new Block.ItemBlock(bm, "Tra sua chan dau duong den", "30.000 VND",Color.AliceBlue,Color.Green,Color.DeepPink)
                {
                    Location = new Point(i * 150 + i * 10, 0),
                };
                this.Controls.Add(block);

            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User();
            bool rs = User.userLogin(conn, out user, tb_name.Text, tb_pass.Text);
            if (rs)
            {
                Controller.ToastController.addSureToast(2, "Đăng nhập thành công!");
                this.Visible = false;
                Main.Main main = new Main.Main();
                main.user = user;
                main.Show();
            }
            else
            {
                Controller.ToastController.addSureToast(3, "Đăng nhập thất bại, kiểm tra lại thông tin đã nhập!");
            }
            //MessageBox.Show(new Model.ItemDiscountDetails().getAllDiscountOfItem(null, 2).Count.ToString()) ;


            //Server server = new Server();
            //new Thread(server.StartServer).Start();

        }

        private void Login_Load(object sender, EventArgs e)
        {
           // k7ToggleButton1.setText("Dạng bảng", "Dạng khối");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
