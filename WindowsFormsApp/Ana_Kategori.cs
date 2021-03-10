using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Ana_Kategori : Form
    {
        Connection mycnn = new Connection();

        
        public Ana_Kategori()
        {
            InitializeComponent();
            DataGetir();
            DataButtonEkle();
        }

        private void DataGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT KategoriID, KategoriAdi, KategoriDurum, KategoriTarih FROM Tbl_Kategori ", mycnn.MyConnection ());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = false; // sütun indexini alabilmek içn

                }
        private void DataButtonEkle()
        {
            DataGridViewLinkColumn LinkEdit = new DataGridViewLinkColumn();
            LinkEdit.UseColumnTextForLinkValue = true;
            LinkEdit.HeaderText = "Güncelle";
            LinkEdit.DataPropertyName = "LnkColumn";
            LinkEdit.LinkBehavior = LinkBehavior.SystemDefault;
            LinkEdit.Text = "Güncelle";
            dataGridView1.Columns.Add(LinkEdit);

            DataGridViewLinkColumn LinkDelete = new DataGridViewLinkColumn();
            LinkDelete.UseColumnTextForLinkValue = true;
            LinkDelete.HeaderText = "Sil";
            LinkDelete.DataPropertyName = "LnkColumn";
            LinkDelete.LinkBehavior = LinkBehavior.SystemDefault;
            LinkDelete.Text = "Sil";
            dataGridView1.Columns.Add(LinkDelete);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AnaKategoriekle()
        {
            if (Txtbx_ad.Text != "")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Kategori (KategoriAdi) VALUES ('" + Txtbx_ad.Text.ToString()+"')",mycnn.MyConnection());
                cmd.ExecuteNonQuery();                      //execute et
                DataGetir();                                 //Datanın direkt tabloda Görünmesi için
                MessageBox.Show("Kategori Başarıyla Eklenmiştir.");
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Veri Giriniz.");
            }
        }

        private void Btn_AnaKategoriEkle_Click (object sender, EventArgs e)
        {
            AnaKategoriekle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["KategoriID"].Value.ToString();
                string adi = dataGridView1.Rows[e.RowIndex].Cells["KategoriAdi"].Value.ToString();
                byte durum = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells["KategoriDurum"].Value);
                KategoriGüncelle(id, adi, durum);
            }
            else if  (e.ColumnIndex==5)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["KategoriID"].Value.ToString();
                KategoriSil(id);
            }
        }


        private void KategoriGüncelle(string _id, string _adi, byte _durum)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Kategori SET KategoriAdi='" + _adi + "' , KategoriDurum='" + _durum + "' WHERE KategoriID='" + _id + "' ", mycnn.MyConnection());
            cmd.ExecuteNonQuery();
            DataGetir();
            MessageBox.Show("Güncelleme İşleminiz Gerçekleştirilmiştir.");
        }


        private void KategoriSil(string _id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Kategori  WHERE KategoriID='" + _id + "' ", mycnn.MyConnection());
            cmd.ExecuteNonQuery();
            DataGetir();
            MessageBox.Show("Silme İşleminiz Gerçekleştirilmiştir.");
        }
    }
}
