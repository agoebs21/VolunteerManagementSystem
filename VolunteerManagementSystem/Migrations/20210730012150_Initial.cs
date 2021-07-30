using Microsoft.EntityFrameworkCore.Migrations;

namespace VolunteerManagementSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    VolunteerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CentersPreferred = table.Column<string>(nullable: true),
                    SkillsInterests = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    Licenses = table.Column<string>(nullable: true),
                    EmergencyName = table.Column<string>(nullable: true),
                    EmergencyPhone = table.Column<string>(nullable: true),
                    EmergencyEmail = table.Column<string>(nullable: true),
                    EmergencyAddress = table.Column<string>(nullable: true),
                    ValidLicense = table.Column<bool>(nullable: false),
                    ValidSocial = table.Column<bool>(nullable: false),
                    Approval = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.VolunteerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volunteers");
        }
    }
}
