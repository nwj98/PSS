using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS.ucPanel
{
    public partial class PrintrecordPanel : UserControl
    {
        PropertyPage.PrintrecordPage propertyPage;
        public PrintrecordPanel()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var db = Database.DBcontext.Db();


            // load all user in database
            IEnumerable<Database.Printrecord> result = db.Query("printrecord").Get<Database.Printrecord>();

            grid.Rows.Clear();
            foreach (var printrecord in result)
            {
                grid.Rows.Add(new object[]
                {
                    printrecord.Print_num,
                    printrecord.Emp_name,
                    printrecord.File_size,
                    printrecord.Log
                });
            }
        }
        public void FilterData(string logf, string logl, string name)
        {
            var db = Database.DBcontext.Db();

            IEnumerable<Database.Printrecord> result = null;
                

            if (name.Equals(""))
            {
                result = db.Query("printrecord").Where("log", ">=", logf)
                    .Where("log", "<=", logl).Get<Database.Printrecord>();
            }
            else
            {
                result = db.Query("printrecord").Where("log", ">=", logf)
                    .Where("log", "<=", logl).Where("emp_name",name)
                    .Get<Database.Printrecord>();
            }

            grid.Rows.Clear();
            foreach (var printrecord in result)
            {
                grid.Rows.Add(new object[]
                {
                    printrecord.Print_num,
                    printrecord.Emp_name,
                    printrecord.File_size,
                    printrecord.Log
                });
            }
        }
        public void SearchNameData(string name)
        {
            grid.ClearSelection();
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(name))
                {
                    row.Selected = true;
                    //break;
                }
            }
        }
        public DataGridView getGrid() { return this.grid; }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            tableLayoutPanel1.Controls.Clear();
            property.SetLabelText(this.grid.CurrentRow.Cells[0].Value.ToString(),
                this.grid.CurrentRow.Cells[1].Value.ToString(),
                this.grid.CurrentRow.Cells[2].Value.ToString(),
                this.grid.CurrentRow.Cells[3].Value.ToString()
                );
            tableLayoutPanel1.Controls.Add(property);
            property.Dock = tableLayoutPanel1.Dock;
            */
            propertyPage = new PropertyPage.PrintrecordPage();
            propertyPage.SetContext(this.grid.CurrentRow.Cells[0].Value.ToString(),
                this.grid.CurrentRow.Cells[1].Value.ToString(),
                this.grid.CurrentRow.Cells[2].Value.ToString(),
                this.grid.CurrentRow.Cells[3].Value.ToString()
                );
            propertyPage.Show();
        }
        public string GetFilepath(string print_num)
        {
            var db = Database.DBcontext.Db();
            string filepath = "";
            IEnumerable<Database.Printrecord> result =
                db.Query("printrecord").Where("print_num", print_num).Get<Database.Printrecord>();


            foreach (var printrecord in result)
            {
                filepath = printrecord.File_path;
            }

            return filepath;
        }
    }
}
