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
    public partial class FormAlt_Kategori : Form
    {
        Connection mycnn = new Connection();
        

        public FormAlt_Kategori()
        {
            InitializeComponent();
            AnaKategoriGetir();
            DataGetir();
            DataButtonEkle();
        }
        public void AnaKategoriGetir ()
        {
            SqlCommand cmd = new SqlCommand("SELECT KategoriID, KategoriAdi FROM Tbl_Kategori WHERE KategoriDurum=1", mycnn.MyConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            cmbbx_AnaCat.Text = "Seçiniz";

            while (dr.Read())
            {
                cmbbx_AnaCat.Items.Add(new ComboBox_Value(Convert.ToInt32 (dr[0]), dr[1].ToString()));
            }
            dr.Close();
        }
        private void DataGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT AltKategoriID, KategoriID, AltKategoriAdi, AltKategoriDurum, AltKategoriTarih FROM Tbl_AltKategori ", mycnn.MyConnection());
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
        private void AltKategoriekle()
        {
            ComboBox_Value combo = (ComboBox_Value) cmbbx_AnaCat.SelectedItem;
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_AltKategori (KategoriID, AltKategoriAdi) VALUES (@ID, @AD)",mycnn.MyConnection());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", combo.id);
            cmd.Parameters.AddWithValue("@AD", Txtbx_AltCat.Text);
            cmd.ExecuteNonQuery();
        }

        private void btn_AltCatEkle_Click(object sender, EventArgs e)
        {
            if (cmbbx_AnaCat.SelectedItem != null)
            {
                if(Txtbx_AltCat.Text !="")
                {
                    AltKategoriekle();
                    DataGetir();
                    MessageBox.Show("Alt Kategori Başarıyla Eklenmiştir.");
                }
                else
                {
                    MessageBox.Show("Lütfen Alt Kategori Adını Giriniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Veri Giriniz.");
            }


        }
        private void KategoriGüncelle(string _id, string _adi, byte _durum)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_AltKategori SET AltKategoriAdi='" + _adi + "' , AltKategoriDurum='" + _durum + "' WHERE AltKategoriID='" + _id + "' ", mycnn.MyConnection());
            cmd.ExecuteNonQuery();
            DataGetir();
            MessageBox.Show("Güncelleme İşleminiz Gerçekleştirilmiştir.");
        }


        private void KategoriSil(string _id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_AltKategori  WHERE AltKategoriID='" + _id + "' ", mycnn.MyConnection());
            cmd.ExecuteNonQuery();
            DataGetir();
            MessageBox.Show("Silme İşleminiz Gerçekleştirilmiştir.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["AltKategoriID"].Value.ToString();
                string adi = dataGridView1.Rows[e.RowIndex].Cells["AltKategoriAdi"].Value.ToString();
                byte durum = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells["AltKategoriDurum"].Value);
                KategoriGüncelle(id, adi, durum);
            }
            else if (e.ColumnIndex == 6)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["AltKategoriID"].Value.ToString();
                KategoriSil(id);
            }
        }
    }
}

