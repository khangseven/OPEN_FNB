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
    public partial class TableBlock : UserControl
    {

        public bool Idle=true;
        public bool Selected=false;
        public int Id;
        public int Bill=-1;

        public string name;
        public string type;
        public bool isTakeAway;

        public event EventHandler SelectedChanged;
        public virtual void OnSelectedChanged(EventArgs e)
        {
            SelectedChanged?.Invoke(this, e);
        }

        public event EventHandler TableClicked;
        public virtual void OnTableClicked(EventArgs e)
        {
            TableClicked?.Invoke(this, e);
        }

        
        public TableBlock()
        {
            InitializeComponent();
            
        }

        public void init(string name, string type, int id, int bill)
        {
            this.TableName.Text = name;
            this.Id = id;
            if (id == 0)
            {
                this.Type.Text =  type;
            }
            else this.Type.Text = id + " | " + type;
            this.Bill = bill;
            this.name = name;
            this.type = type;
            reDraw();
        }

        public  void reDraw()
        {
            if (Id==0)
            {
                if (Bill != -1)
                {
                    PictureBox.Image = OPEN_FNB.Properties.Resources.take_away_food_64px_blue;
                }
                else
                {
                    PictureBox.Image = OPEN_FNB.Properties.Resources.take_away_food_64px_white;
                }

                if (Selected)
                {
                    this.BackColor = Color.DodgerBlue;
                    PictureBox.Image = OPEN_FNB.Properties.Resources.take_away_food_64px_white_selected;
                }
                else
                {
                    this.BackColor = Color.White;
                }
            }
            else
            {
                if (Bill != -1)
                {
                    PictureBox.Image = OPEN_FNB.Properties.Resources.table_64px_blue;
                }
                else
                {
                    PictureBox.Image = OPEN_FNB.Properties.Resources.table_64px_white;
                }

                if (Selected)
                {
                    this.BackColor = Color.DodgerBlue;
                    PictureBox.Image = OPEN_FNB.Properties.Resources.table_64px_white_select;
                }
                else
                {
                    this.BackColor = Color.White;
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            TableBlock_Click(this, e);
        }

        private void Name_Click(object sender, EventArgs e)
        {
            TableBlock_Click(this, e);
        }

        private void Type_Click(object sender, EventArgs e)
        {
            TableBlock_Click(this, e);
        }

        private void TableBlock_Click(object sender, EventArgs e)
        {
            Selected = true;
            this.OnSelectedChanged(EventArgs.Empty);
            this.OnTableClicked(EventArgs.Empty);
            reDraw();
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void TableBlock_MouseEnter(object sender, EventArgs e)
        {
            if (Selected) return;
            this.BackColor = Color.LightCyan;
        }

        private void TableBlock_MouseLeave(object sender, EventArgs e)
        {
            if (Selected) return;
            this.BackColor = Color.White;
        }
    }
}
