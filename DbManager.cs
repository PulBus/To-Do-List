using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace To_Do_List
{
    public class DbManager
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LocalHost"].ConnectionString;
        private string InsertSQL = "InsertTasks";
        private string GetSQL = "GetTasks";
        private string RemoveSQL = "RemoveTasks";
        private string CompleteSQL = "CompleteTasks";
        private string DeleteSQL = "DeleteTasks";
        private string RecoverSQL = "RecoverTasks";
        private string OverdueSQL = "OverdueTasks";
        private string? Status;

        private ListBox List;
        private DateTimePicker? Date;
        private DataRowView selectedRow;

        
        public DbManager(ListBox list, DateTimePicker? date = null, string? status = null)
        {
            List = list;
            Date = date;
            Status = status;
        }

        public void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(GetSQL, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Date", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", Status);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        List.DisplayMember = "Descript";
                        List.DataSource = dataTable;
                    }
                }

                conn.Close();
            }
        }

        public void InsertTask(string descript, DateTime startDate, DateTime dueDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(InsertSQL, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Description", descript);
                    cmd.Parameters.AddWithValue("@DateCreated", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@DueDate", dueDate.Date);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            LoadData();
        }

        public void RemoveTask()
        {
            selectedRow = (DataRowView)List.SelectedItem;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(RemoveSQL, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ToDelete", selectedRow["Descript"].ToString());
                    cmd.Parameters.AddWithValue("@Date", Date.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", Status);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            LoadData();
        }

        public void CompleteTask()
        {
            selectedRow = (DataRowView)List.SelectedItem;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(CompleteSQL, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ToComplete", selectedRow["Descript"].ToString());
                    cmd.Parameters.AddWithValue("@TaskDate", Date.Value.Date);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            LoadData();
        }

        public void DeleteTask()
        {
            selectedRow = (DataRowView)List.SelectedItem;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(DeleteSQL, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ToDelete", selectedRow["Descript"].ToString());
                    cmd.Parameters.AddWithValue("@Date", Date.Value.Date);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            LoadData();
        }

        public void RecoverTask()
        {
            selectedRow = (DataRowView)List.SelectedItem;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(RecoverSQL, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ToRecover", selectedRow["Descript"].ToString());
                    cmd.Parameters.AddWithValue("@Date", Date.Value.Date);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            LoadData();
        }

        public void OverdueTasks()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(OverdueSQL, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        List.DisplayMember = "OverdueTask";
                        List.DataSource = dataTable;
                    }
                }
            }

        }
    }
}
