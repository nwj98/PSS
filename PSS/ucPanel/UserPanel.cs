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
    public partial class UserPanel : UserControl
    {
        PropertyPage.UserPropertyPage propertyPage;


        public UserPanel()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var db = Database.DBcontext.Db();


            // load all user in database
            IEnumerable<Database.User> result = db.Query("employee").Get<Database.User>();

            grid.Rows.Clear();
            foreach (var employee in result)
            {
                grid.Rows.Add(new object[]
                {
                    employee.Emp_id,
                    employee.Dept_name,
                    employee.Emp_name,
                    employee.Gender,
                    employee.Rank,
                    employee.Ip,
                    employee.Log
                });
            }
        }
        public void FilterData(string logf, string logl, string dept, string name, string rank)
        {
            var db = Database.DBcontext.Db();

            IEnumerable<Database.User> result =
                db.Query("employee").Where("log", ">=", logf).Where("log", "<=", logl).Get<Database.User>();

            grid.Rows.Clear();
            foreach (var employee in result)
            {
                grid.Rows.Add(new object[]
                {
                    employee.Emp_id,
                    employee.Dept_name,
                    employee.Emp_name,
                    employee.Gender,
                    employee.Rank,
                    employee.Ip,
                    employee.Log
                });
            }
        }
        public void SearchNameData(string name)
        {

            grid.ClearSelection();
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[2].Value.ToString().Equals(name))
                {
                    row.Selected = true;
                    break;
                }
            }

        }
        public DataGridView getGrid() { return this.grid; }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            propertyPage = new PropertyPage.UserPropertyPage();
            propertyPage.SetPropertyLabel(this.grid.CurrentRow.Cells[0].Value.ToString(),
                this.grid.CurrentRow.Cells[1].Value.ToString(),
                this.grid.CurrentRow.Cells[2].Value.ToString(),
                this.grid.CurrentRow.Cells[3].Value.ToString(),
                this.grid.CurrentRow.Cells[4].Value.ToString(),
                this.grid.CurrentRow.Cells[5].Value.ToString(),
                this.grid.CurrentRow.Cells[6].Value.ToString());
            propertyPage.Show();
            */
            propertyPage = new PropertyPage.UserPropertyPage();
            propertyPage.SetContext(this.grid.CurrentRow.Cells[0].Value.ToString(),
                this.grid.CurrentRow.Cells[1].Value.ToString(),
                this.grid.CurrentRow.Cells[2].Value.ToString(),
                this.grid.CurrentRow.Cells[3].Value.ToString(),
                this.grid.CurrentRow.Cells[4].Value.ToString(),
                this.grid.CurrentRow.Cells[5].Value.ToString(),
                this.grid.CurrentRow.Cells[6].Value.ToString());
            propertyPage.Show();

        }
    }
}
