using Microsoft.Data.SqlClient;
using System.Numerics;

namespace NCA_FA2.Models
{
    public class ComplaintModel
    {
        public int Complaint_Id { get; set; }
        public string? Complaint_Name { get; set; }
        public string? Complaint_Email { get; set; }
        public string? Complaint_Phone { get; set; }
        public string? Complaint_Text { get; set; }

        public int SaveComplaintDetails()
        {
            // Replace the connection string with your actual database connection string
            string connectionString = "Data Source=SammyAntha;Initial Catalog=dbUserFeedback;User ID=SAMMYANTHA/SammyAntha;Password=; Integrated Security=True; Persist Security Info=false; MultipleActiveResultSets=False; Encrypt=False; TrustServerCertificate=True; Connection Timeout=30";


            // Use a parameterized query to avoid SQL injection
            string query = "INSERT INTO tblComplaints (Complaint_Name, Complaint_Email, Complaint_Phone, Complaint_Text)\r\nVALUES (@Complaint_Name, @Complaint_Email, @Complaint_Phone, @Complaint_Text)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Complaint_Id", Complaint_Id);
                    command.Parameters.AddWithValue("@Complaint_Name", Complaint_Name);
                    command.Parameters.AddWithValue("@Complaint_Email", Complaint_Email);
                    command.Parameters.AddWithValue("@Complaint_Phone", Complaint_Phone);
                    command.Parameters.AddWithValue("@Complaint_Text", Complaint_Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected; // Return the number of rows affected by the insert operation
                }
            }
        }
    }
}


