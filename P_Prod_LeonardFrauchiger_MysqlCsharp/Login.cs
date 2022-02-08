using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Prod_LeonardFrauchiger_MysqlCsharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            Network network = new Network();
            network.Connect(txtBoxUsername.Text, txtBoxPassword.Text, txtBoxServer.Text, txtBoxDatabase.Text);
        }

        public void Message(string message)
        {
            MessageBox.Show(message,"ERROR");
        }
    }
}
