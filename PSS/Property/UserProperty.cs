using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS
{
    public partial class UserProperty : UserControl
    {
        public UserProperty()
        {
            InitializeComponent();
            //SetLabelText("", "", "", "", "", "");
        }
        public void SetLabelText(string id, string docname, string name,
            string gender, string rank, string ip)
        {
            lblid.Text = id;
            lbldocname.Text = docname;
            lblname.Text = name;
            lblgender.Text = gender;
            lblrank.Text = rank;
            lblip.Text = ip;
        }
    }
    
}
