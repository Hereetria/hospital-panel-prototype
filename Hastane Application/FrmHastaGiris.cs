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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }

        private void girisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *  From Tbl_Hastalar Where hastaTc=@p1 and hastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtc.Text);
            komut.Parameters.AddWithValue("@p2", txsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc=txtc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali Kullanici Adi veya Sifre");
            }
        }
    }
}
