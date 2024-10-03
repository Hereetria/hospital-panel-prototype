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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void kytbuton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (hastaAd,hastaSoyad,hastaTc,hastaTelefon,hastaSifre,hastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", kytad.Text);
            komut.Parameters.AddWithValue("@p2", kytsoyad.Text);
            komut.Parameters.AddWithValue("@p3", kyttc.Text);
            komut.Parameters.AddWithValue("@p4", kyttel.Text);
            komut.Parameters.AddWithValue("@p5", kytsifre.Text);
            komut.Parameters.AddWithValue("@p6", kytcinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydiniz Başariyla Yapilmistir");
        }
    }
}
