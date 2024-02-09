using Microsoft.Data.SqlClient;

namespace NCA_FA2.Models
{
    public class ComplimentModel
    {
        public int Compliment_Id { get; set; }
        public string? Compliment_Name { get; set; }
        public string? Compliment_Email { get; set; }
        public string? Compliment_Phone { get; set; }
        public string? Compliment_Text { get; set; }

        public int SaveComplimentDetails()
        {
            // Replace the connection string with your actual database connection string
            string connectionString = "Data Source=SammyAntha;Initial Catalog=dbUserFeedback;User ID=SAMMYANTHA/SammyAntha;Password=; Integrated Security=True; Persist Security Info=false; MultipleActiveResultSets=False; Encrypt=False; TrustServerCertificate=True; Connection Timeout=30";


            // Use a parameterized query to avoid SQL injection
            string query = "INSERT INTO tblCompliments (Compliment_Name, Compliment_Email, Compliment_Phone, Compliment_Text)\r\nVALUES (@Compliment_Name, @Compliment_Email, @Compliment_Phone, @Compliment_Text)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Compliment_Id", Compliment_Id);
                    command.Parameters.AddWithValue("@Compliment_Name", Compliment_Name);
                    command.Parameters.AddWithValue("@Compliment_Email", Compliment_Email);
                    command.Parameters.AddWithValue("@Compliment_Phone", Compliment_Phone);
                    command.Parameters.AddWithValue("@Compliment_Text", Compliment_Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected; // Return the number of rows affected by the insert operation
                }
            }
        }
    }
}