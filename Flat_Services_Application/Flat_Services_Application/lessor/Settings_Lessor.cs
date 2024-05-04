using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flat_Services_Application.lessor
{
    public partial class Settings_Lessor : Form
    {
        public Settings_Lessor()
        {
            InitializeComponent();
        }

        private void Setting_btn_Click(object sender, EventArgs e)
        {

        }

        private void Home_btn_Click(object sender, EventArgs e)
        {

        }

        private void tbChangePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePass c = new ChangePass();
            c.Show();
        }
    }
}
