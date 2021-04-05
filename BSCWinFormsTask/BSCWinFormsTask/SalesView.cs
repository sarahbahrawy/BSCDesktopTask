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
    public partial class SalesView : Form
    {
        SqlConnection Conn = new SqlConnection();

        String ConnectionString = @"data source=DESKTOP-7SFCMDT\SARASQL;initial catalog=DesktopDB;
                    integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        public static  int SelectedSales;
        public static string SelectedSalesName;


        List<int> SalesID = new List<int>();


        public SalesView()
        {
            InitializeComponent();
        }

        private void SalesView_Load(object sender, EventArgs e)
        {
            Conn.ConnectionString = ConnectionString;

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
        }

        private void SalescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSales = SalesID[SalescomboBox.SelectedIndex];
            SelectedSalesName = (string)SalescomboBox.SelectedItem;
            SalesVisits salesVisits = new SalesVisits();
            this.Hide();
            salesVisits.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            SalesVisits salesVisits = new SalesVisits();
            this.Hide();
            salesVisits.Hide();
            home.Show();
        }
    }
}
