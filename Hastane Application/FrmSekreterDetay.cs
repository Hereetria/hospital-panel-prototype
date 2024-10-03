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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string Tcnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            sdsektc.Text = Tcnumara;

            SqlCommand komut1 = new SqlCommand("Select sekreterAdSoyad From Tbl_Sekreterler Where sekreterTc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",sdsektc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                sdsekadsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branslari Cekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doktorlari Listeleme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (doktorAd + ' ' + DoktorSoyad) AS doktorAd,doktorBrans From Tbl_Doktorlar",bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //Bransi Aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                sdbrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void sdkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@r1",sdtarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2", sdsaat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", sdbrans.Text);
            komutKaydet.Parameters.AddWithValue("@r4", sddoktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Olusturuldu");
        }

        private void sdbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            sddoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select doktorAd,doktorSoyad From Tbl_Doktorlar Where doktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",sdbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                sddoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void sdolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",sdduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void sddocpanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void sdbranspanel_Click(object sender, EventArgs e)
        {
            FrmBrans frb =  new FrmBrans();
            frb.Show();
        }

        private void sdrandevuliste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void sdguncelle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }
    }
}
