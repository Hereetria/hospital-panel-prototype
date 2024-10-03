using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Application
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;



        //ad soyad cekme
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            hdtc.Text = tc;

            SqlCommand komut = new SqlCommand("Select hastaAd,hastaSoyad From Tbl_Hastalar Where hastaTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",hdtc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                hdadsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Gecmisi
            string query = "Select * From Tbl_Randevular Where hastaTc=@p1";
            SqlDataAdapter da = new SqlDataAdapter(query, bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", tc);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            //Branslari Cekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                hdbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void hdbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            hddoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select doktorAd,doktorSoyad From Tbl_Doktorlar Where doktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", hdbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                hddoktor.Items.Add(dr3[0] + "" + dr3[1]);
                bgl.baglanti().Close(); 
            }
        }

        private void hddoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * From Tbl_Randevular Where RandevuBrans=@p1 and RandevuDurum=0";
            SqlDataAdapter da = new SqlDataAdapter(query, bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", hdbrans.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void hdduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = hdtc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            hdid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void hdbuton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Randevular (HastaTc, HastaSikayet, RandevuBrans, RandevuDoktor, RandevuDurum, RandevuTarih, RandevuSaat) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", hdtc.Text);
            komut.Parameters.AddWithValue("@p2", hdsikayet.Text);
            komut.Parameters.AddWithValue("@p3", hdbrans.Text);
            komut.Parameters.AddWithValue("@p4", hddoktor.Text);
            komut.Parameters.AddWithValue("@p5", 0);
            komut.Parameters.AddWithValue("@p6", now.Date);
            komut.Parameters.AddWithValue("@p7", now.TimeOfDay);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alindi");

        }

    }
}
