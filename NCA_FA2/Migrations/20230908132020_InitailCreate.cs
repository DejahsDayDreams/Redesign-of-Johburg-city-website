using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NCA_FA2.Migrations
{
    /// <inheritdoc />
    public partial class InitailCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    Complaint_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Complaint_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complaint_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complaint_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complaint_Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.Complaint_Id);
                });

            migrationBuilder.CreateTable(
                name: "Compliments",
                columns: table => new
                {
                    Compliment_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Compliment_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compliment_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compliment_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compliment_Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compliment", x => x.Compliment_Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackViewModel",
                columns: table => new
                {
                    Compliment_Id = table.Column<int>(type: "int", nullable: false),
                    Compliment_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compliment_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compliment_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compliment_Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complaint_Id = table.Column<int>(type: "int", nullable: false),
                    Complaint_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complaint_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complaint_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complaint_Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.DropTable(
                name: "Compliments");

            migrationBuilder.DropTable(
                name: "FeedbackViewModel");
        }
    }
}
