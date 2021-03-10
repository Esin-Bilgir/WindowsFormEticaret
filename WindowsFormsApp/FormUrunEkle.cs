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
    public partial class FormUrunEkle : Form
    {
        Connection mycnn = new Connection();
        public FormUrunEkle()
        {
            InitializeComponent();
            DataGetir();
            AnaKategoriGetir();
            DataButtonEkle();
        }
        public void AnaKategoriGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT KategoriID, KategoriAdi FROM Tbl_Kategori WHERE KategoriDurum=1", mycnn.MyConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            cmbbx_Anakat.Text = "Seçiniz";

            while (dr.Read())
            {
                cmbbx_Anakat.Items.Add(new ComboBox_Value(Convert.ToInt32(dr[0]), dr[1].ToString()));
            }
            dr.Close();
        }

        public void AltKategoriGetir()
        {
            cmbbx_AltKat.Items.Clear();
            ComboBox_Value combo = (ComboBox_Value)cmbbx_Anakat.SelectedItem;
            SqlCommand cmd = new SqlCommand("SELECT AltKategoriID, AltKategoriAdi FROM Tbl_AltKategori WHERE AltKategoriDurum=1 AND KategoriID=@ID ", mycnn.MyConnection());
            cmd.Parameters.AddWithValue("@ID", combo.id);
            SqlDataReader dr = cmd.ExecuteReader();
            cmbbx_AltKat.Text = "Seçiniz";

            while (dr.Read())
            {
                cmbbx_AltKat.Items.Add(new ComboBox_Value(Convert.ToInt32(dr[0]), dr[1].ToString()));
            }
            dr.Close();
        }

        private void cmbbx_Anakat_SelectedIndexChanged(object sender, EventArgs e)
        {

            AltKategoriGetir();

        }
        public void UrunEkle()
        {
            ComboBox_Value Anacombo = (ComboBox_Value)cmbbx_Anakat.SelectedItem;
            ComboBox_Value Altcombo = (ComboBox_Value)cmbbx_Anakat.SelectedItem;

            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Urun ( KategoriID, AltKategoriID, UrunKodu, UrunAdi,UrunFiyat,UrunDurum) VALUES ( @ANA_ID, @ALT_ID,@URUNKOD, @URUNADI, @URUNFYT, @URUNAKTIF ) ", mycnn.MyConnection());

            cmd.Parameters.AddWithValue("@ANA_ID", Anacombo.id);
            cmd.Parameters.AddWithValue("@ALT_ID", Altcombo.id);
            cmd.Parameters.AddWithValue("@URUNKOD", txtbx_UrunKod.Text.ToString());
            cmd.Parameters.AddWithValue("@URUNADI", txtbx_UrunAd.Text.ToString());
            cmd.Parameters.AddWithValue("@URUNFYT", txtbx_UrunFiyat.Value);
            cmd.Parameters.AddWithValue("@URUNAKTIF", checkBox1.Checked);
            cmd.ExecuteNonQuery();
        }
        private void Btn_UrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                UrunEkle();
                DataGetir();
                MessageBox.Show("Ürün Başarıyla Eklenmiştir.");
            }
            catch
            {
                MessageBox.Show("Hata: Lütfen Değerleri Dikkatli Giriniz.");


            }
        }
        private void DataGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT UrunID, KategoriID, AltKategoriID, UrunKodu, UrunAdi,UrunFiyat,UrunDurum FROM Tbl_Urun ", mycnn.MyConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = false; // sütun indexini alabilmek içn

        }


        private void DataButtonEkle()
        {
           

            DataGridViewLinkColumn LinkDelete = new DataGridViewLinkColumn();
            LinkDelete.UseColumnTextForLinkValue = true;
            LinkDelete.HeaderText = "Sil";
            LinkDelete.DataPropertyName = "LnkColumn";
            LinkDelete.LinkBehavior = LinkBehavior.SystemDefault;
            LinkDelete.Text = "Sil";
            dataGridView1.Columns.Add(LinkDelete);


        }
        private void KategoriSil(string _id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Urun  WHERE UrunID='" + _id + "' ", mycnn.MyConnection());
            cmd.ExecuteNonQuery();
            DataGetir();
            MessageBox.Show("Silme İşleminiz Gerçekleştirilmiştir.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 7)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["UrunID"].Value.ToString();
                KategoriSil(id);
            }
        }
    }
    }
    

