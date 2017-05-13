using Service_Desk.ServiceDesk_service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Service_Desk
{
    public partial class login_form : Telerik.WinControls.UI.RadForm
    {

        RadForm2 main = new RadForm2();
        public login_form()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();

            var login_control = client.login(username_txt.Text, password_txt.Text).ToString();

            client.Close();

            if (Convert.ToInt32(login_control)==1)
            {
                MessageBox.Show("Welcome " + username_txt.Text);
                this.Hide();
                Program.login_control = 1;
                main.Show();
            }

        }
    }
}
