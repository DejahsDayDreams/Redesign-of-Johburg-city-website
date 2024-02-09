
using Microsoft.EntityFrameworkCore;
using NCA_FA2;
using NCA_FA2.Models;

namespace NCA_FA2.Data
{
    public class FeedbackDBContext : DbContext
    {
        public FeedbackDBContext(DbContextOptions<FeedbackDBContext> options) : base(options)
        {

        }

        // DbSet properties for your actual entity types (ComplimentModel and ComplaintModel) go here
        public DbSet<ComplimentModel> Compliments { get; set; }
        public DbSet<ComplaintModel> Complaints { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure FeedbackViewModel as a keyless entity type
            modelBuilder.Entity<FeedbackViewModel>().HasNoKey();

            // Configure ComplimentModel
            modelBuilder.Entity<ComplimentModel>()
                .HasKey(c => c.Compliment_Id);

            // Configure ComplaintModel
            modelBuilder.Entity<ComplaintModel>()
                .HasKey(c => c.Complaint_Id);

            // Other configurations for ComplimentModel and ComplaintModel go here

            base.OnModelCreating(modelBuilder);
        }

    }
}