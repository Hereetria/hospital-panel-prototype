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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Brans Ekleme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                dpbrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void dpekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (doktorAd,doktorSoyad,doktorBrans,doktorTc,doktorSifre) values (@d1,@d2,@d3,@d4,@d5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", dpad.Text);
            komut.Parameters.AddWithValue("@d2", dpsoyad.Text);
            komut.Parameters.AddWithValue("@d3", dpbrans.Text);
            komut.Parameters.AddWithValue("@d4", dptc.Text);
            komut.Parameters.AddWithValue("@d5", dpsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            dpad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            dpsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dpbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dptc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dpsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void dpsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Doktorlar where doktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",dptc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayit Sildindi","Uyari",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void dpguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set doktorAd=@d1,doktorSoyad=@d2,doktorBrans=@d3,doktorSifre=@d5 where doktorTc=@d4",bgl.baglanti());

            komut.Parameters.AddWithValue("@d1", dpad.Text);
            komut.Parameters.AddWithValue("@d2", dpsoyad.Text);
            komut.Parameters.AddWithValue("@d3", dpbrans.Text);
            komut.Parameters.AddWithValue("@d4", dptc.Text);
            komut.Parameters.AddWithValue("@d5", dpsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
