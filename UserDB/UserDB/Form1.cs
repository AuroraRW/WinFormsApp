using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UserDB
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=A018932;Initial Catalog=UserDB;Integrated Security=True";
        private ErrorProvider errorProvider = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
            LoadAllUsers();
            //dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void LoadAllUsers()
        {
            string query = "SELECT UserId, UserName, Email FROM Users";
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No users found.");
                        }

                        // Set up autocomplete
                        var userNames = new AutoCompleteStringCollection();
                        //userNames.AddRange(new string[] { "Alice", "Amy", "Bob", "Charlie" });

                        // With LINQ: IEnumerable<DataRow>, IEnumerable<string> 
                        //string?[] userNamesArray = dataTable.AsEnumerable()
                        //              .Select(row => row["UserName"].ToString())
                        //              .ToArray();
                        //userNames.AddRange(userNamesArray);


                        // Without LINQ
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string userName = row["UserName"].ToString();
                            userNames.Add(userName);
                        }

                        txtSearchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtSearchName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtSearchName.AutoCompleteCustomSource = userNames;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fail: " + ex.Message);
                }
            }
        }
        // Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userInput = txtSearchName.Text;
            if (userInput == "")
            {
                MessageBox.Show("Please input user ID!");
                return;
            }

            string query = "SELECT UserName, Email FROM Users WHERE UserName = @UserName";
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", userInput);

                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Not found");
                        }
                        txtSearchName.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fail: " + ex.Message);
                }
            }
        }

        // Add 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string email = txtEmail.Text;
            // validation for username

            if (string.IsNullOrWhiteSpace(userName))
            {
                errorProvider.SetError(txtUserName, "Username must contain only letters and numbers");
                return;
            }

            string insertQuery = "INSERT INTO Users (UserName, Email) VALUES (@UserName, @Email)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Email", email);
                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "User added successfully!" : "Failed to add user.");
                        LoadAllUsers();
                        txtEmail.Text = "";
                        txtUserName.Text = "";
                        errorProvider.SetError(txtUserName, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fail: " + ex.Message);
                }
            }
        }

        // Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string userInput = txtUserId.Text;
            //if (userInput == "")
            //{
            //    MessageBox.Show("Please input user ID!");
            //    return;
            //}
            //int userId = Convert.ToInt32(userInput);

            //// select a row to update
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int userId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);

            string userName = txtUserName.Text;
            string email = txtEmail.Text;

            string updateQuery = "UPDATE Users SET UserName = @UserName, Email = @Email WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Email", email);
                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "User updated successfully!" : "Failed to update user.");
                        LoadAllUsers();
                        txtUserId.Text = "";
                        txtUserName.Text = "";
                        txtEmail.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fail: " + ex.Message);
                }
            }
        }

        // Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // get the user ID to delete
            //string userInput = txtUserId.Text;
            //if (userInput == "")
            //{
            //    MessageBox.Show("Please input user ID!");
            //    return;
            //}
            //int userId = Convert.ToInt32(userInput);

            //// select a row to delete
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int userId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);

            string deleteQuery = "DELETE FROM Users WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully!");
                            LoadAllUsers();
                            txtEmail.Text = "";
                            txtUserName.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete user.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fail: " + ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string userName = selectedRow.Cells["UserName"].Value?.ToString();
                string email = selectedRow.Cells["Email"].Value?.ToString();

                txtUserName.Text = userName;
                txtEmail.Text = email;
            }
        }
    }
}
