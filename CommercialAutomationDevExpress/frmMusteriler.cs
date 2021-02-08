using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialAutomationDevExpress
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        DbConnection db = new DbConnection();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Musteri", db.connect());
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.ClearSelection();

        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            
            if(!IsValidEmail(textEditMusteriMail.Text))
            {
                MessageBox.Show("Geçerli bir email adresi giriniz.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
   
            //iller combobox
            SqlDataAdapter da = new SqlDataAdapter("select sehir from iller", db.connect());
            DataSet ds = new DataSet();
            da.Fill(ds,"sehir");
            textEditMusteriIl.DisplayMember = "sehir";
            textEditMusteriIl.ValueMember = "sehir";
            textEditMusteriIl.DataSource = ds.Tables[0];



            listele();

        }

        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"select ilce as i from ilceler inner join iller on ilceler.sehir=iller.id where iller.sehir like '{textEditMusteriIl.Text}' ", db.connect());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet,"i");
            textEditMusteriIlce.DisplayMember = "i";
            textEditMusteriIlce.ValueMember = "i";
            textEditMusteriIlce.DataSource = dataSet.Tables[0];
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetFocusedDataRow();
            //textEditUrunID.ReadOnly = true;
            textEditMusteriTC.Text = dr["MusteriTC"].ToString();
            textEditMusteriAd.Text = dr["MusteriAd"].ToString();
            textEditMusteriSoyad.Text = dr["MusteriSoyad"].ToString();
            textEditMusteriTelNo.Text = dr["MusteriTelNo"].ToString();
            textEditMusteriMail.Text = dr["MusteriMail"].ToString();
            textEditMusteriVergiDairesi.Text = dr["MusteriVergiDairesi"].ToString();
            textEditMusteriIl.Text = dr["MusteriIl"].ToString();
            textEditMusteriIlce.Text= dr["MusteriIlce"].ToString();
            textEditMusteriAdres.Text = dr["MusteriAcikAdres"].ToString();

        }
    }
}
