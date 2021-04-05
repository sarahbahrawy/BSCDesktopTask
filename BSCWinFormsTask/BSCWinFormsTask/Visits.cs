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

namespace BSCWinFormsTask
{
    public partial class Visits : Form
    {
        SqlConnection Conn = new SqlConnection();
        
        String ConnectionString = @"data source=DESKTOP-7SFCMDT\SARASQL;initial catalog=DesktopDB;
                    integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        
        int SelectedSales;
        
        int SelectedCustomer;

        List<int> SalesID = new List<int>();

        List<int> CustomerID = new List<int>();

        public Visits()
        {
            InitializeComponent();
            Conn.ConnectionString = ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void NewVisit_Load(object sender, EventArgs e)
        {
            

            Conn.Open();

            // Select Sales

            SqlCommand com = new SqlCommand();
            com.Connection = Conn;
            com.CommandText = "select * from Sales";
            com.CommandType = CommandType.Text;
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                SalescomboBox.Items.Add(r[1]);
                SalesID.Add(int.Parse(r[0].ToString()));
            }



            // Select Customers
            SqlCommand comm = new SqlCommand();
            comm.Connection = Conn;
            comm.CommandText = "select * from Customer";
            comm.CommandType = CommandType.Text;
            SqlDataReader rr = comm.ExecuteReader();
            while (rr.Read())
            {
                CustomercomboBox.Items.Add(rr[1]);
                CustomerID.Add(int.Parse(rr[0].ToString()));
            }

            Conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            Conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = Conn;
            com.CommandText = "insert into Visits values (@SalesID,@CustomerID,@VisitSummary,@VisitDate)";
            com.CommandType = CommandType.Text;
            com.Parameters.Add("@SalesID", SqlDbType.Int).Value = SelectedSales;
            com.Parameters.Add("@CustomerID", SqlDbType.Int).Value = SelectedCustomer;
            com.Parameters.Add("@VisitSummary", SqlDbType.VarChar).Value = SummaryrichTextBox.Text;
            com.Parameters.Add("@VisitDate", SqlDbType.DateTime).Value = DateTime.Now;
            com.ExecuteNonQuery();
            MessageBox.Show("New Visit is added");
            Conn.Close();
            Back();
        }

        private void SalescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSales = SalesID[SalescomboBox.SelectedIndex];
        }

        private void CustomercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCustomer = CustomerID[CustomercomboBox.SelectedIndex];
        }

        private void Back()
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
