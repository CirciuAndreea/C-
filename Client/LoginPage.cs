using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPPC.Client;
using MPPC.model;
using Client;
using System.Configuration;

namespace MPPC.Client
{
    public partial class LoginPage : Form
    {
        private ClientCtrl ctrl;
        public LoginPage(ClientCtrl ctrl)
        {
            InitializeComponent();
            this.ctrl = ctrl;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            Angajat es = new Angajat() { Username = username, Password = password };
            if (username != null && password != null)
            {
                try
                {
                    // MessageBox.Show("B!!!");
                    ctrl.login(es);
                   // MessageBox.Show("Login succeded");
                    mainPage chatWin = new mainPage(es, ctrl, this);
                    chatWin.Text = "Chat window for " + username;
                    chatWin.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Nu exista cont cu aceste date de logare! Va rugam incercati din nou!");
                    return;
                }
            }
        }
    }
}
