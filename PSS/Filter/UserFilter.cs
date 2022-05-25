using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS.Filter
{
    public partial class UserFilter : Form
    {
        public UserFilter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = Database.DBcontext.Db();

            string logf = tbogfirst.Text;
            string logl = tbloglast.Text;
            string dept = tbdept.Text;
            string name = tbname.Text;
            string rank = tbrank.Text;
            
        }
    }
}
