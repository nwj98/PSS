using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS.PropertyPage
{
    public partial class PrintrecordPage : Form
    {
        public PrintrecordPage()
        {
            InitializeComponent();
        }

        public void SetLabelText(string num, string name, string size, string log)
        {
            lblnum.Text = num;
            lblname.Text = name;
            lblsize.Text = size;
            lbllog.Text = log;
        }
        public void SetContext(string num, string name, string size, string log)
        {
            lblnum.Text = num;
            lblname.Text = name;
            lblsize.Text = size;
            lbllog.Text = log;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
