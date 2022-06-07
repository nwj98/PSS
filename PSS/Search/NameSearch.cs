using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS.Search
{
    public delegate void UserNameSearchEventHandler(string name);
    public partial class NameSearch : Form
    {
        public UserNameSearchEventHandler DataSendEvent;
        public NameSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSendEvent(textBox1.Text);
        }
    }
}
