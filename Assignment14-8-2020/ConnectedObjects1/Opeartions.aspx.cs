using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedObjects1
{
    public partial class Opeartions : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Assignments;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public void ShowGrid()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from EmpTb1", conn);

            SqlDataReader sdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(sdr);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            sdr.Close();
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ShowGrid();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Insert into EmpTb1(empName ,empSal) values (@empName ,@empSal)", conn);
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = txtEmpName.Text;
            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(txtEmpSal.Text);
            cmd.ExecuteNonQuery();       
            conn.Close();
            ShowGrid(); 
        }

        protected void btnSp_Insert_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Sp_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName", txtEmpName.Text);
            cmd.Parameters.AddWithValue("@EmpSal", txtEmpSal.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update EmpTb1 set EmpName=@empName, EmpSal=@empsal where EmpId=@empid", conn);
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add("@empname", SqlDbType.VarChar, 20).Value = txtEmpName.Text;
            cmd.Parameters.Add("@empsal", SqlDbType.Float).Value = Convert.ToSingle(txtEmpSal.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnSp_Update_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Sp_Update1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EmpId", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            cmd.Parameters.Add("@EmpName", SqlDbType.VarChar,20).Value = (txtEmpName.Text);
            cmd.Parameters.Add("@EmpSal", SqlDbType.Float).Value = (txtEmpSal.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from EmpTb1  where EmpId='" + txtEmpId.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnSp_Delete_Click(object sender, EventArgs e)
        {

        }

        protected void btnParameters_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from EmpTb1  where EmpId=@EmpId", conn);
            cmd.Parameters.Add("@EmpId", SqlDbType.Int).Value = Convert.ToInt32(txtEmpId.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }
    }
}