using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormLogin : Form
    {
        public bool aaa;
        public FormLogin()
        {
            InitializeComponent();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            

           
            if ("esin" == txtbx_ad.Text && "1234" == txtbx_sifre.Text)
            {
                aaa = true;
                this.Close();
                
            }
            else
            {
                aaa = false;
                MessageBox.Show("Hatalı Giriş!");
                

            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {   if(aaa==true)
            this.Close();   

        }
    }
}
