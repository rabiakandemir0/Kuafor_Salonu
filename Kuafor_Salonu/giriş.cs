using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
using Kuafor_Salonu;


namespace Kuafor_Salonu
{
    public partial class giriş : Form
    {


        public giriş()
        {
            InitializeComponent();
          
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                MessageBox.Show("admin girişi başarılı ");
                this.Hide();
                anasayfa ynform = new anasayfa();

                ynform.ShowDialog();
            }
            else if (textBox1.Text == "kullanıcı" && textBox2.Text == "456")
            {
                MessageBox.Show("kullanıcı girişi başarılı");
                this.Hide();
                musteriler ynform = new musteriler();
                ynform.ShowDialog();

            }
            else MessageBox.Show("giriş başarısız");
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
    }
}
