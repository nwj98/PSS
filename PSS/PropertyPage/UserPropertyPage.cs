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
    public partial class UserPropertyPage : Form
    {
        UserProperty property = new UserProperty();
        public UserPropertyPage()
        {
            InitializeComponent();
        }

        private void UserPropertyPage_Load(object sender, EventArgs e)
        {
            
        }
        public void SetPropertyLabel(string id, string docname, string name, string gender,
            string rank, string ip)
        {
            property.SetLabelText(id, docname, name, gender, rank, ip);
            tableLayoutPanel1.Controls.Add(property);
        }
    }
}
