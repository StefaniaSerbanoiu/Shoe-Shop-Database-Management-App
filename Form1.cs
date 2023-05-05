using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//databases namespaces
using System.Data;
using System.Data.SqlClient;





namespace ShoeShopApp
{

    public partial class Form1 : Form
    {
        SqlDataAdapter daManagers, daWorkers;
        DataSet ds;
        SqlCommandBuilder cb;
        BindingSource bsManagers, bsWorkers;
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            //required objects
            // Get the connection string from the App.config file
            string connectionString = Properties.Settings.Default.ShoesConnectionString;

            // Create a new SqlConnection object using the connection string
            connection = new SqlConnection(connectionString);

            
            ds = new DataSet();
            daManagers = new SqlDataAdapter("SELECT * FROM Manager", connection);
            daWorkers = new SqlDataAdapter("SELECT * FROM Worker", connection);
            cb = new SqlCommandBuilder(daWorkers);
            daManagers.Fill(ds, "Manager");
            daWorkers.Fill(ds, "Worker");
            DataRelation dr = new DataRelation("FK_Worker_Manager",
            ds.Tables["Manager"].Columns["ManagerID"],
            ds.Tables["Worker"].Columns["ManagerID"]);
            ds.Relations.Add(dr);
            //data binding
            bsManagers = new BindingSource();
            bsManagers.DataSource = ds;
            bsManagers.DataMember = "Manager";
            bsWorkers = new BindingSource();
            bsWorkers.DataSource = bsManagers;
            bsWorkers.DataMember = "FK_Worker_Manager";
            managerDataGridView.DataSource = bsManagers;
            workerDataGridView.DataSource = bsWorkers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string sql = "delete Manager where ManagerID ='mid'";
            try
            {
                daManagers.DeleteCommand = connection.CreateCommand();
                daManagers.DeleteCommand.CommandText = sql;
                daManagers.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Row(s) deleted !! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = deleteWorkerTextBox.Text;
            string sql = "delete Worker from Worker where Worker.WorkerID = " + id;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Find the row in the DataTable that corresponds to the deleted Worker record
                    DataRow[] rows = ds.Tables["Worker"].Select("WorkerID = " + id);
                    if (rows.Length > 0)
                    {
                        DataRow row = rows[0];
                        // Remove the row from the DataTable
                        ds.Tables["Worker"].Rows.Remove(row);
                        // Update the DataGridView to reflect the changes
                        //workerDataGridView.DataSource = ds.Tables["Worker"];
                        workerDataGridView.Refresh();
                        MessageBox.Show("Row(s) deleted !! ");
                    }
                }
               }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteManagerTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void managerButton1_Click(object sender, EventArgs e)
        {
            daManagers.Update(ds, "Manager");

            int rowsAffected = daWorkers.Update(ds, "Worker");
            if (rowsAffected > 0)
            {
                workerDataGridView.Update();
            }
            workerDataGridView.Refresh();
            managerDataGridView.Refresh();

        }

        private void managerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

    }
}
