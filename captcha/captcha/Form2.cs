using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Giriş_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            string kuladi = "orcun61";
            string sifre = "sifre";
            if (textEdit1.Text == kuladi && textEdit2.Text == sifre)
            {
                frm1.Show();
                Hide();

            }
            else MessageBox.Show("Kullanıcı adı veya şifre yanlış");
          

        }
    }
}