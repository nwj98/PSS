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
    public delegate void UserDataGetEventHandler(string logf, string logl, 
        string dept,string name, string rank);
    public partial class UserFilter : Form
    {
        public UserDataGetEventHandler DataSendEvent;
        public UserFilter()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSendEvent(tblogfirst.Text,tbloglast.Text,tbdept.Text,tbname.Text,tbrank.Text);
            this.Close();
        }
    }
}
