using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroservicesBus.User.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstMidName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaOfCoverage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    NumberOfAppointments = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "AreaOfCoverage", "Email", "FirstMidName", "Gender", "LastName", "NumberOfAppointments", "PhoneNumber", "Role", "Specialization", "UserName" },
                values: new object[,]
                {
                    { 1, "110011", "testOne@gmail.com", "testOne", 1, "testOne", 9, "999999999", 3, "Plumber", "testOne" },
                    { 2, "110011", "testTwo@gmail.com", "testTwo", 2, "testTwo", 0, "1234567890", 3, "Electrician", "testTwo" },
                    { 3, "110011", "testThree@gmail.com", "testThree", 1, "testThree", 0, "9102837465", 3, "Mechanic", "testThree" },
                    { 4, "110011", "testFour@gmail.com", "testFour", 1, "testFour", 0, "999888999", 3, "Carpenter", "testFour" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
