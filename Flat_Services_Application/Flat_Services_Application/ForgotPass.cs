using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net;
using System.Xml.Linq;

namespace Flat_Services_Application
{
    public partial class ForgotPass : Form
    {
       
        public ForgotPass()
        {
            InitializeComponent();
        }

        
        public ForgotPass(String s)
        {
            InitializeComponent();
            tbMail.Text = s;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login login = new Login();  
            login.Show();   
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //neu sdt ton tai, otp gui ve may dung thi dang hap thanh cong
            if (tbOTP.Text == "" || tbMail.Text == "")
                return;
            if(!IsNumberPhone(tbMail.Text))
            {
                lb1.Text = "!";
                lb1.ForeColor = Color.Red;
                return;
            }
            //dieu kien otp


            
            this.Hide();
            changePass_forgot c = new changePass_forgot(tbMail.Text);
            c.Show();
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (tbMail.Text == "")
            {
                lb1.Text = "*";
                lb1.ForeColor = Color.Red;
            }
            else
                lb1.Text = "";
        }

        private void tbOTP_TextChanged(object sender, EventArgs e)
        {
            if (tbOTP.Text == "")
            {
                lb2.Text = "*";
                lb2.ForeColor = Color.Red;
            }
            else
                lb2.Text = "";
        }
        public bool IsNumberPhone(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ' || (a[i] < '0' || a[i] > '9'))
                    return false;
            }
            if (a.Length < 10 || a.Length > 11)
                return false;
            return true;
        }
    }
}
