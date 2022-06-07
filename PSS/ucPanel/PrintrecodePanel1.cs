using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlKata.Execution;
namespace PSS.ucPanel
{
    public partial class PrintrecodePanel1 : UserControl
    {
        Property.PrintProperty property = new Property.PrintProperty();
        
        public PrintrecodePanel1()
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
                    printrecord.Doc_name,
                    printrecord.Doc_page,
                    printrecord.File_size,
                    printrecord.Page_size,
                    printrecord.Color,
                    printrecord.Log

                }) ;
            }
        }
        public void FilterData(string logf, string logl, string name, string pagesize, string isColor)
        {
            var db = Database.DBcontext.Db();

            IEnumerable<Database.Printrecord> result =
                db.Query("printrecord").Where("log", ">=", logf).Where("log", "<=", logl).Get<Database.Printrecord>();

            grid.Rows.Clear();
            foreach (var printrecord in result)
            {
                grid.Rows.Add(new object[]
                {
                    printrecord.Print_num,
                    printrecord.Emp_name,
                    printrecord.Doc_name,
                    printrecord.Doc_page,
                    printrecord.File_size,
                    printrecord.Page_size,
                    printrecord.Color,
                    printrecord.Log
                });
            }
        }
        public void SearchNameData(string name)
        {
            var db = Database.DBcontext.Db();

            IEnumerable<Database.Printrecord> result =
                db.Query("printrecord").Where("emp_name",name).Get<Database.Printrecord>();

            grid.Rows.Clear();
            foreach (var printrecord in result)
            {
                grid.Rows.Add(new object[]
                {
                    printrecord.Print_num,
                    printrecord.Emp_name,
                    printrecord.Doc_name,
                    printrecord.Doc_page,
                    printrecord.File_size,
                    printrecord.Page_size,
                    printrecord.Color,
                    printrecord.Log
                });
            }
        }
        public DataGridView getGrid() { return this.grid; }
        private void PrintrecodePanel1_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            property.SetLabelText(this.grid.CurrentRow.Cells[0].Value.ToString(),
                this.grid.CurrentRow.Cells[1].Value.ToString(),
                this.grid.CurrentRow.Cells[2].Value.ToString(),
                this.grid.CurrentRow.Cells[3].Value.ToString(),
                this.grid.CurrentRow.Cells[4].Value.ToString(),
                this.grid.CurrentRow.Cells[5].Value.ToString(),
                this.grid.CurrentRow.Cells[6].Value.ToString(),
                this.grid.CurrentRow.Cells[7].Value.ToString()
                );
            tableLayoutPanel1.Controls.Add(property);
            property.Dock = tableLayoutPanel1.Dock;
            
        }
    }

}
