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
    public partial class TableManager : UserControl
    {
        public TableManager()
        {
            InitializeComponent();

            loadType();
            loadTable();
        }

        #region tabletype

        public TableType selectedTableType=null;
        void loadType()
        {
            var list = TableType.getAll(null);
            dgv_tabletype.Rows.Clear();
            dgv_tabletype.RowCount=list.Count;
            int index = 0;
            cb_tabletype.Items.Clear();
            list.ForEach(t => {
                var temp2 = new ComboboxItem(t.name, t);
                dgv_tabletype.Rows[index].Cells[0].Value = t.id.ToString();
                dgv_tabletype.Rows[index].Cells[1].Value = temp2;
                index++;

                cb_tabletype.Items.Add(temp2);

            });
            cb_tabletype.SelectedIndex=0;

            selectedTableType = null;
            lb_idtype.Text = "_";
            lb_nametype.Text = "";
        }

        private void dgv_tabletype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            selectedTableType = (dgv_tabletype.Rows[e.RowIndex].Cells[1].Value as ComboboxItem).Value as TableType;
            lb_idtype.Text = selectedTableType.id.ToString();
            lb_nametype.Text = selectedTableType.name;
        }

        private void btn_addt_Click(object sender, EventArgs e)
        {
            StringInputBlock sib = new StringInputBlock("Nhập tên loại bàn: ");
            var rs = sib.ShowDialog();
            if(rs == DialogResult.OK)
            {
                TableType tt = new TableType(sib.text);
                Controller.ToastController.On();
                var check = tt.saveTableType();
                Controller.ToastController.Off();
                if (check)
                {
                    loadType();
                }
            }
        }

        private void btn_updatet_Click(object sender, EventArgs e)
        {
            if (selectedTableType == null)
            {
                Controller.ToastController.addSureToast(3, "Hãy chọn trước một loại bàn!");
            }
            else
            {
                if(lb_nametype.Text.Trim().Length == 0)
                {
                    Controller.ToastController.addSureToast(3, "Tên không thể rỗng!");
                    return;
                }
                selectedTableType.name = lb_nametype.Text;
                Controller.ToastController.On();
                var rs  =  selectedTableType.updateTableType(null);
                Controller.ToastController.Off();
                if (rs) loadType();
            }
        }

        private void btn_deletet_Click(object sender, EventArgs e)
        {
            if (selectedTableType == null)
            {
                Controller.ToastController.addSureToast(3, "Hãy chọn trước một loại bàn!");
            }
            else
            {
                Controller.ToastController.On();
                var rs = selectedTableType.deleteTableType(null);
                Controller.ToastController.Off();
                if (rs) loadType();
            }
        }
        #endregion

        #region table

        Table selectedTable = null;
        void loadTable()
        {
            var list = Table.getAllWithCondition(null," && t.id!=0");
            dgv_table.Rows.Clear();
            dgv_table.RowCount = list.Count;
            int index = 0;

            list.ForEach(t => {
                var temp2 = new ComboboxItem(t.name, t);
                dgv_table.Rows[index].Cells[0].Value = t.id.ToString();
                dgv_table.Rows[index].Cells[1].Value = temp2;
                dgv_table.Rows[index].Cells[2].Value = t.type_name;
                index++;

            });

            selectedTable = null;
            tb_id.Text = "_";
            tb_name.Text = "";
        }

        private void dgv_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            selectedTable = (dgv_table.Rows[e.RowIndex].Cells[1].Value as ComboboxItem).Value as Table;
            tb_id.Text = selectedTable.id.ToString();
            tb_name.Text = selectedTable.name;
            for(int i = 0; i < cb_tabletype.Items.Count; i++)
            {
                if(((cb_tabletype.Items[i] as ComboboxItem).Value as TableType).id == selectedTable.type)
                {
                    cb_tabletype.SelectedIndex = i;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringInputBlock sib = new StringInputBlock("Nhập tên bàn: ");
            var rs = sib.ShowDialog();
            if (rs == DialogResult.OK)
            {
                Table tt = new Table(sib.text,((cb_tabletype.Items[cb_tabletype.SelectedIndex] as ComboboxItem).Value as TableType).id);
                Controller.ToastController.On();
                var check = tt.saveTable();
                Controller.ToastController.Off();
                if (check)
                {
                    loadType();
                    loadTable();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedTable == null)
            {
                Controller.ToastController.addSureToast(3, "Hãy chọn trước một bàn!");
            }
            else
            {
                if (tb_name.Text.Trim().Length == 0)
                {
                    Controller.ToastController.addSureToast(3, "Tên không thể rỗng!");
                    return;
                }
                selectedTable.name = tb_name.Text;
                selectedTable.type = ((cb_tabletype.Items[cb_tabletype.SelectedIndex] as ComboboxItem).Value as TableType).id;
                Controller.ToastController.On();
                var rs = selectedTable.updateTable(null);
                Controller.ToastController.Off();
                if (rs)
                {
                    loadType();
                    loadTable();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedTable == null)
            {
                Controller.ToastController.addSureToast(3, "Hãy chọn trước một bàn!");
            }
            else
            {
                Controller.ToastController.On();
                var rs = selectedTable.deleteTable(null);
                Controller.ToastController.Off();
                if (rs)
                {
                    loadType();
                    loadTable();
                }
            }
        }
        #endregion

        
    }
}
