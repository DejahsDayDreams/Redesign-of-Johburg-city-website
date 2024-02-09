using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace NCA_FA2.Models
{
    public class FeedbackViewModel
    {
        // Properties from ComplimentModel
        public int Compliment_Id { get; set; }
        public string? Compliment_Name { get; set; }
        public string? Compliment_Email { get; set; }
        public string? Compliment_Phone { get; set; }
        public string? Compliment_Text { get; set; }

        // Properties from ComplaintModel
        public int Complaint_Id { get; set; }
        public string? Complaint_Name { get; set; }
        public string? Complaint_Email { get; set; }
        public string? Complaint_Phone { get; set; }
        public string? Complaint_Text { get; set; }
    }
   
}

