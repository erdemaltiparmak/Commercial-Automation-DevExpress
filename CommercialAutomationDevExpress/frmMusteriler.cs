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
        public bool IsValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            
            if(!IsValidEmail(maskedTextBox1.Text))
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
            comboBox1.DisplayMember = "sehir";
            comboBox1.ValueMember = "sehir";
            comboBox1.DataSource = ds.Tables[0];
            //ilçeler combobox
            

        }

        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"select ilce as i from ilceler inner join iller on ilceler.sehir=iller.id where iller.sehir like '{comboBox1.Text}' ", db.connect());
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet,"i");
            comboBox2.DisplayMember = "i";
            comboBox2.ValueMember = "i";
            comboBox2.DataSource = dataSet.Tables[0];
        }
    }
}
