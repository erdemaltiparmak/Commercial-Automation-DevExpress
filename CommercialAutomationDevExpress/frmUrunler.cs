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

namespace CommercialAutomationDevExpress
{
    public partial class frmUrunler : Form
    {

        public frmUrunler()
        {
            InitializeComponent();
        }
        DbConnection db = new DbConnection();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Urun", db.connect());
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void sbtnUrunKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand c = new SqlCommand("insert into Urun(UrunAd,UrunMarka,UrunModel,UrunYıl,UrunAdet,UrunAlisFiyat,UrunSatisFiyat,UrunAciklama) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", db.connect());
            c.Parameters.AddWithValue("@p1", textEditUrunAd.Text);
            c.Parameters.AddWithValue("@p2", textEditUrunMarka.Text);
            c.Parameters.AddWithValue("@p3", textEditUrunModel.Text);
            c.Parameters.AddWithValue("@p4", textEditUrunYil.Text);
            c.Parameters.AddWithValue("@p5", int.Parse(textEditUrunAdet.Text));
            c.Parameters.AddWithValue("@p6", decimal.Parse(textEditUrunAlisFiyat.Text));
            c.Parameters.AddWithValue("@p7", decimal.Parse(textEditUrunSatisFiyat.Text));
            c.Parameters.AddWithValue("@p8", textEditUrunAciklama.Text);
            c.ExecuteNonQuery();
            db.connect().Close();
            MessageBox.Show($"{textEditUrunAd.Text} adlı ürün eklendi.");
            listele();
        }

        private void sbtnUrunSil_Click(object sender, EventArgs e)
        {
            //SqlCommand s = new SqlCommand("select UrunAd from Urun where UrunID=@p1", db.connect());
            //s.Parameters.AddWithValue("@p1", textEditUrunID);

            //SqlDataReader dr = s.ExecuteReader();
            //while(dr.Read())
            //{
            //    string urunAd = (string) dr["UrunAd"];
            //}

            SqlCommand c = new SqlCommand("delete from Urun where UrunID=@p1", db.connect());
            c.Parameters.AddWithValue("@p1", textEditUrunID.Text);
            c.ExecuteNonQuery();
            db.connect().Close();
            MessageBox.Show("ürün silindi");
            listele();
        }
        private void sbtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand c = new SqlCommand("update Urun set UrunAd=@p1,UrunMarka=@p2,UrunModel=@p3,UrunYıl=@p4,UrunAdet=@p5,UrunAlisFiyat=@p6,UrunSatisFiyat=@p7,UrunAciklama=@p8 where UrunID=@p9", db.connect());
            c.Parameters.AddWithValue("@p1", textEditUrunAd.Text);
            c.Parameters.AddWithValue("@p2", textEditUrunMarka.Text);
            c.Parameters.AddWithValue("@p3", textEditUrunModel.Text);
            c.Parameters.AddWithValue("@p4", textEditUrunYil.Text);
            c.Parameters.AddWithValue("@p5", int.Parse(textEditUrunAdet.Text));
            c.Parameters.AddWithValue("@p6", decimal.Parse(textEditUrunAlisFiyat.Text));
            c.Parameters.AddWithValue("@p7", decimal.Parse(textEditUrunSatisFiyat.Text));
            c.Parameters.AddWithValue("@p8", textEditUrunAciklama.Text);
            c.Parameters.AddWithValue("@p9", int.Parse(textEditUrunID.Text));

            c.ExecuteNonQuery();
            db.connect().Close();
            MessageBox.Show("ürün güncellendi");
            listele();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();
            textEditUrunID.ReadOnly = true;
            textEditUrunID.Text = dr["UrunID"].ToString();
            textEditUrunAd.Text = dr["UrunAd"].ToString();
            textEditUrunMarka.Text= dr["UrunMarka"].ToString();
            textEditUrunModel.Text = dr["UrunModel"].ToString();
            textEditUrunYil.Text = dr["UrunYıl"].ToString();
            textEditUrunAdet.Value = int.Parse(dr["UrunAdet"].ToString());
            textEditUrunAlisFiyat.Text = dr["UrunAlisFiyat"].ToString();
            textEditUrunSatisFiyat.Text = dr["UrunSatisFiyat"].ToString();
            textEditUrunAciklama.Text = dr["UrunAciklama"].ToString();


        }

        private void groupControlUrun_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
