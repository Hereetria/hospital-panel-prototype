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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            kyttc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where hastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",kyttc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                kytad.Text = dr[1].ToString();
                kytsoyad.Text = dr[2].ToString();
                kyttel.Text = dr[4].ToString();
                kytsifre.Text = dr[5].ToString();
                kytcinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void kytbuton_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set hastaAd=@p1,hastaSoyad=@p2,hastaTelefon=@p3,hastaSifre=@p4,hastaCinsiyet=@p5 Where hastaTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",kytad.Text);
            komut2.Parameters.AddWithValue("@p2", kytsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", kyttel.Text);
            komut2.Parameters.AddWithValue("@p4", kytsifre.Text);
            komut2.Parameters.AddWithValue("@p5", kytcinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", kyttc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
