using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace captcha
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        DevExpress.XtraEditors.PictureEdit pic;
        int rndsayi;
        
        public Form1()
        {
      

            InitializeComponent();
        }
        
        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Move(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int sayi = hScrollBar1.Value;
            pic.Location = new Point(sayi,10);
            label2.Text = sayi.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayi = rnd.Next(2,5);
            label1.Text = sayi.ToString();
            DevExpress.XtraEditors.PictureEdit x=pictureEdit1;
            switch (Convert.ToInt32(label1.Text))
            {
                case 2:
                    x = pictureEdit2;
                    break;
                case 3:
                    x = pictureEdit3;
                    break;
                case 4:
                    x = pictureEdit4;
                    break;
                case 5:
                    x = pictureEdit5;
                    break;

            }
            x.Location = new Point(12,12);
            pic = x;
            
        }
        void kontrol()
        {
          


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            int sayi = Convert.ToInt32(label1.Text);
            
            double pic2plus = pictureEdit2.Location.X + (pictureEdit2.Location.X) * 0.2;
            double pic2minus = pictureEdit2.Location.X - (pictureEdit2.Location.X) * 0.2;

            double pic3plus = pictureEdit3.Location.X + (pictureEdit3.Location.X) * 0.2;
            double pic3minus = pictureEdit3.Location.X - (pictureEdit3.Location.X) * 0.2;

            double pic4plus = pictureEdit4.Location.X + (pictureEdit4.Location.X) * 0.2;
            double pic4minus = pictureEdit4.Location.X - (pictureEdit4.Location.X) * 0.2;

            int kontrol = Convert.ToInt32(label2.Text);
            
            switch (sayi)
            {
                case 2:
                    if (kontrol < 95 && kontrol > 83)
                    {
                        label3.Text = "true";
                        MessageBox.Show("Giriş Başarılı. Lütfen Bekleyiniz");
                        Thread.Sleep(2000);
                        Close();
                        frm2.Show();
                    }
                    else
                    {
                        label4.Visible = true;
                        pictureEdit2.Location = new Point(12, 12);
                    }
                    break;
                case 3:
                    if (kontrol < 173 && kontrol > 162)
                    {
                        label3.Text = "true";
                        MessageBox.Show("Giriş Başarılı. Lütfen Bekleyiniz");
                        Thread.Sleep(2000);
                        Close();
                        frm2.Show();
                    }
                    else
                    {
                        label4.Visible = true;
                        pictureEdit3.Location = new Point(12, 12);
                    }
                    break;
                case 4:
                    if (kontrol<253 && kontrol>243)
                    {
                        label3.Text = "true";
                        MessageBox.Show("Giriş Başarılı. Lütfen Bekleyiniz");
                        Thread.Sleep(2000);
                        Close();
                        frm2.Show();
                    }
                    else
                    {
                        label4.Visible = true;
                        pictureEdit4.Location = new Point(12, 12);
                    }
                    break;
            }





        }
    }
}
