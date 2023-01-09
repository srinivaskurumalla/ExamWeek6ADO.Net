using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWeek6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection con = null;
        private SqlCommand cmd = null;

        //String type
        string EmployeeType = string.Empty;
        //return value
        int returnValue = 0;

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_InsertEmployee", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EmployeeId", TxtEmpNo.Text);
                    cmd.Parameters.AddWithValue("@EmployeeName", TxtEmpName.Text);
                    cmd.Parameters.AddWithValue("@EmployeeSalary", TxtSalary.Text);
                    cmd.Parameters.AddWithValue("@EmployeeType", EmployeeType);

                    // get output parameter

                  /*  SqlParameter IdParameter = new SqlParameter("@Id", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(IdParameter);
*/


                    //To get stored procedure return value
                    SqlParameter retVal = cmd.Parameters.Add("@Return_Value", SqlDbType.Int);
                    retVal.Direction = ParameterDirection.ReturnValue;
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                    returnValue = (int)retVal.Value;
                   
                }
            }
            if(returnValue == -1)
            {
                LblMessage.Text = $"Employee Name Should be greater than 2 characters";
            }
            else if (returnValue == -2)
            {
                LblMessage.Text = $"Employee Name Should be less than 21 characters";
            }
           else  if (returnValue == -3)
            {
                LblMessage.Text = $"Employee Salary Sholud be greater than or equal to 25000";
            }
            else if (returnValue == -4)
            {
                LblMessage.Text = $"Employee Type must be selected";
            }
           else  if (returnValue == -5)
            {
                LblMessage.Text = $"Employee Already Exists with Id {TxtEmpNo.Text}";
            }
            else
            {
                LblMessage.Text = $"Employee Added with Id : {TxtEmpNo.Text}";
            }
            Reset();
        }

        private void RdPayRoll_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeType = "P";
        }

        private void RdConsultant_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeType = "C";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Reset Method
        private void Reset()
        {
            TxtEmpNo.Text = "";
            TxtEmpName.Text = "";
            TxtSalary.Text = "";
            EmployeeType = "";
           
        }
    }

      
    }

