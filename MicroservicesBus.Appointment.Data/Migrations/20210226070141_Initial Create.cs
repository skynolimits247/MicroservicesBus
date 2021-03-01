using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroservicesBus.Appointment.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignedTo = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    AppointmentStatus = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Address", "AppointmentStatus", "AssignedTo", "City", "CreatedBy", "Description", "Specialization", "State", "Zip" },
                values: new object[] { 1, "omaxe building flat 304", 1, 2, "Delhi", 1, "electric switch not working", "electrician", "Delhi", "110011" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Address", "AppointmentStatus", "AssignedTo", "City", "CreatedBy", "Description", "Specialization", "State", "Zip" },
                values: new object[] { 2, "omaxe building flat 304", 1, 4, "Delhi", 1, "door fixtures are broken and latches are not fitting well", "carpenter", "Delhi", "110011" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Address", "AppointmentStatus", "AssignedTo", "City", "CreatedBy", "Description", "Specialization", "State", "Zip" },
                values: new object[] { 3, "omaxe building flat 304", 1, 3, "Delhi", 1, "car needs servicing", "mechanic", "Delhi", "110011" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
