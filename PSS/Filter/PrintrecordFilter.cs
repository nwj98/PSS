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
    public delegate void PrintrecordDataGetEventHandler(string logf, string logl,
        string name, string pagesize, string isColor);
    public partial class PrintrecordFilter : Form
    {
        public PrintrecordDataGetEventHandler DataSendEvent;
        public PrintrecordFilter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSendEvent(tblogfirst.Text, tbloglast.Text, tbname.Text, tbpagesize.Text, tbcolor.Text);
            this.Close();
        }
    }
}
