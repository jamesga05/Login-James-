using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Form Login = new Form2();
            Login.Show();
            click.Visible = true;
        }

        private void click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
            this.Dispose();
        }
    }
}
