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


namespace WindowsFormsApplication3
{
    public partial class frmemployee : Form
    {
        public frmemployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string connetionString = null;
            //string sql = null;
         
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection cnn;
            connetionString = @"Data Source=JASON-IMAC\SQLEXPRESS;Database=reassist;Integrated Security = SSPI";
            cnn = new SqlConnection(connetionString);
            try
            {


                cnn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO empreassists ( FName, MName, LName) VALUES (@fname, @mname, @lname)", cnn);
           
                command.Parameters.Add("@fname",txtfirstname.Text);
                command.Parameters.Add("@mname",txtmiddlename.Text);
                command.Parameters.Add("@lname",txtlastname.Text);
                command.ExecuteNonQuery();
             
                MessageBox.Show("Successfully Added!");
   
                cnn.Close();
            }
            catch 
            {
                MessageBox.Show("ndi makokonectd");
            }

        }

        private void frmemployee_Load(object sender, EventArgs e)
        {
          // SqlConnection conn = SqlConnection("Server=JASON-IMAC\SQLEXPRESS;Database=reassist");

           

        /* var con = new reassistemp();
            var cus = (from c in con.empreassists select c).First();

            txtfirstname.Text = cus.FName;
            txtlastname.Text = cus.LName;
            txtmiddlename.Text = cus.MName;
            txtfathersname.Text = cus.FathersName;
            cbogender.Items.Add("Male");
            cbogender.Items.Add("Female");*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
