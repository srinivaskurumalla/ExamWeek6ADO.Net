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
using System.Configuration;

namespace SecondCode
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet dataSet = null;

        // the % character is a wildcard that matches any number of characters
        string query = "SELECT * FROM Customer WHERE City LIKE @pattern";

        public Form1()
        {
            InitializeComponent();
        }

        //Generating Primary Key
        public DataColumn[] GeneratePrimaryKey(DataSet dataSet)
        {
            DataColumn[] dc = new DataColumn[1];
            dc[0] = dataSet.Tables["Customer"].Columns["CustomerId"];
            dataSet.Tables["Customer"].PrimaryKey = dc;

            return dc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Customer", con))
                {

                    dataSet = new DataSet();
                    adapter.Fill(dataSet, "Customer");
                    //Bound to Combo Box
                    DataGv.DataSource = dataSet.Tables["Customer"];
                  



                }

               /* using(adapter = new SqlDataAdapter("Select CreditLimit,CustomerName from Customer", con))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet, "customers");

                    //Bound to combo box

                    CbSort.DataSource = dataSet.Tables["customers"];
                    CbSort.ValueMember = "CreditLimit";
                    CbSort.Text = "--selects--";
                }*/
            }
        }

        private void Filter()
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Customer", con))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet, "Customer");
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                   /* DataTable dt = dataSet.Tables["Customer"];
                  
                    DataView dv = dataSet.Tables["Customer"].AsDataView();*/
                    if (CbSort.SelectedIndex == 1)
                    {

                    }


                }
            }
        }

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter(query, con))
                {
                    string pattern = $"{TxtCity.Text}%";
                    adapter.SelectCommand.Parameters.AddWithValue("@pattern", pattern);

                    dataSet = new DataSet();
                    adapter.Fill(dataSet, "Customer");

                    // SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    //Generate Primary Key
                    //dataSet.Tables["Customer"].PrimaryKey = GeneratePrimaryKey(dataSet);

                    DataTable dt = dataSet.Tables["Customer"];
                    DataGv.DataSource = dt;


                }

            }
           // CbSort_SelectedIndexChanged(sender, e);
        }

        private void CbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sort1 = "Select * from Customer Order By  ";

            if (CbSort.SelectedIndex == 0)
            {
                sort1 += " CreditLimit asc";
            }
            else if (CbSort.SelectedIndex == 1)
            {
                sort1 += " CreditLimit desc";
            }
            else if(CbSort.SelectedIndex == 2)
            {
                sort1 += " CustomerName asc";

            }
            else if(CbSort.SelectedIndex == 3)
            {
                sort1 += " CustomerName desc";
            }
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter(sort1, con))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet, "Customer");
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    DataTable dt = dataSet.Tables["Customer"];

                    DataView dv = dataSet.Tables["Customer"].AsDataView();
                   
                   // dv.RowFilter = "City='" + CbSort.SelectedValue + "'";


                    DataGv.DataSource = dv;


                    sort1 = "";
                }
            }
        }
    }
}
