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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormLogin FormLogin = new FormLogin();
            
             if (FormLogin.aaa == false)
            {
                
               FormLogin.ShowDialog();
                
              }
            if (FormLogin.aaa == false)
            {
                Environment.Exit(0);

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            }

        private void anaKategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ana_Kategori Ana_Kategori = new Ana_Kategori();
            Ana_Kategori.ShowDialog();
        }

        private void altKategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlt_Kategori FormAlt_Kategori = new FormAlt_Kategori();
            FormAlt_Kategori.ShowDialog();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunEkle FormUrunEkle = new FormUrunEkle();
            FormUrunEkle.ShowDialog();
        }
    }
    }

