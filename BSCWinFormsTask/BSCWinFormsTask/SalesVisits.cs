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
    public partial class SalesVisits : Form
    {
        int SelectedSales;
      
        SqlConnection Conn = new SqlConnection();

        String ConnectionString = @"data source=DESKTOP-7SFCMDT\SARASQL;initial catalog=DesktopDB;
                    integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        int SelectedRow;
        public SalesVisits()
        {
            InitializeComponent();
        }

        private void SalesVisits_Load(object sender, EventArgs e)
        {
            GetSalesVisits();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesView salesView = new SalesView();
            salesView.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
             {
                int i = dataGridView1.SelectedCells[0].RowIndex;

                int val = (int)dataGridView1.SelectedCells[0].Value;

                if (dataGridView1.Rows.Count > 1 && i != dataGridView1.Rows.Count - 1)
                {
                    SqlCommand com = new SqlCommand();
                    com.CommandText = "DELETE FROM Visits WHERE Serial=" + val + "";
                    Conn.Open();
                    com.Connection = Conn;
                    com.ExecuteNonQuery();
                    Conn.Close();
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("Row Deleted");
                }
                else
                {
                    MessageBox.Show("Must Select A Row !");
                }
            }
            catch
            {
                MessageBox.Show("Must Select A Row !");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView1.SelectedCells[0].RowIndex;

                SelectedRow = (int)dataGridView1.SelectedCells[0].Value;


                if (dataGridView1.Rows.Count > 1 && i != dataGridView1.Rows.Count - 1)
                {
                    label1.Visible = true;
                    SummaryrichTextBox.Visible = true;
                    button4.Visible = true;
                }
                else
                {
                    MessageBox.Show("Must Select A Row !");
                }
            }
            catch
            {
                MessageBox.Show("Must Select A Row !");
            }
            

           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(SummaryrichTextBox.Text!="")
            {
                Conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = Conn;
                com.CommandText = "Update Visits set  VisitSummary =@VisitSummary where Serial= @Serial";
                com.CommandType = CommandType.Text;
                com.Parameters.Add("@Serial", SqlDbType.Int).Value = SelectedRow;
                com.Parameters.Add("@VisitSummary", SqlDbType.VarChar).Value = SummaryrichTextBox.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("Row Updated");
                Conn.Close();


                dataGridView1.DataSource = null;
                dataGridView1.Refresh();

                GetSalesVisits();
            }
            else
            {
                label1.Visible = false;
                SummaryrichTextBox.Visible = false;
                button4.Visible = false;
            }

          
        }

        private void GetSalesVisits()
        {
            label1.Visible = false;
            SummaryrichTextBox.Visible = false;
            button4.Visible = false;

            SelectedSales = SalesView.SelectedSales;
            SalesName.Text = SalesView.SelectedSalesName;
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            String sqlStatement = @"select V.Serial, C.Name , V.VisitSummary, V.VisitDate 
                                    from Visits  V inner join Customer C on V.CustomerID =  C.ID 
                                    inner join Sales S on V.SalesID = S.ID
                                    where S.ID = @SID ";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlStatement, Conn.ConnectionString);
            da.SelectCommand.Parameters.Add("@SID", SqlDbType.Int).Value = SelectedSales;
            da.Fill(ds);
           
            dataGridView1.DataSource = ds.Tables[0];

            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("No Visits");
            }
            Conn.Close();
        }
    }
}
