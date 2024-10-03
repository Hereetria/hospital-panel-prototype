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
using System.Data.Common;

namespace Hastane_Application
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string doktortc;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            ddtc.Text = doktortc;

            SqlCommand komut = new SqlCommand("Select doktorAd,doktorSoyad From Tbl_Doktorlar where doktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", ddtc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ddadsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='"+ddadsoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            ddrandevuliste.DataSource = dt;
        }

        private void ddduzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TCNO = ddtc.Text;
            fr.Show();
        }

        private void ddduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void ddcikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ddrandevuliste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = ddrandevuliste.SelectedCells[0].RowIndex;
            ddetay.Text= ddrandevuliste.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
