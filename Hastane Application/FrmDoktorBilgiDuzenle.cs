using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Application
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCNO;

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            dbdtc.Text = TCNO; 

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where doktorTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",dbdtc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                dbdad.Text = dr[1].ToString();
                dbdsoyad.Text = dr[2].ToString();
                dbdbrans.Text = dr[3].ToString();
                dbdsifre.Text = dr[4].ToString();
            }
            bgl.baglanti().Close();
        }

        private void dbdguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set doktorAd=@p1,doktorSoyad=@p2,doktorBrans=@p3,doktorSifre=@p4 where doktorTc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",dbdad.Text);
            komut.Parameters.AddWithValue("@p2", dbdsoyad.Text);
            komut.Parameters.AddWithValue("@p3", dbdbrans.Text);
            komut.Parameters.AddWithValue("@p4", dbdsifre.Text);
            komut.Parameters.AddWithValue("@p5", dbdtc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgi Güncelleme Basarili");
        }
    }
}
