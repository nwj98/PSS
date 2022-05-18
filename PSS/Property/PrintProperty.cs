using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS.Property
{
    public partial class PrintProperty : UserControl
    {
        public PrintProperty()
        {
            InitializeComponent();
        }

        public void SetLabelText(string num, string name, string docname,
            string page, string file, string size, string color)
        {
            lblnum.Text = num;
            lbldocname.Text = docname;
            lblname.Text = name;
            lblpage.Text = page;
            lblfile.Text = file;
            lblsize.Text = size;
            lblcolor.Text = color;
        }
    }
    
}
