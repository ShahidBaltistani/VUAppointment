using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appointment.Database.Migrations
{
    public partial class appointment_inatial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowAddDate = table.Column<DateTime>(nullable: false),
                    RowAddUser = table.Column<string>(nullable: false),
                    RowEditDate = table.Column<DateTime>(nullable: false),
                    RowEditUser = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    ClinicID = table.Column<int>(nullable: false),
                    DoctorID = table.Column<int>(nullable: false),
                    AppointmentType = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowAddDate = table.Column<DateTime>(nullable: false),
                    RowAddUser = table.Column<string>(nullable: false),
                    RowEditDate = table.Column<DateTime>(nullable: false),
                    RowEditUser = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Address = table.Column<string>(maxLength: 150, nullable: true),
                    ContactPerson = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowAddDate = table.Column<DateTime>(nullable: false),
                    RowAddUser = table.Column<string>(nullable: false),
                    RowEditDate = table.Column<DateTime>(nullable: false),
                    RowEditUser = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    DesignationID = table.Column<int>(nullable: true),
                    DepartmentID = table.Column<int>(nullable: true),
                    Email = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowAddDate = table.Column<DateTime>(nullable: false),
                    RowAddUser = table.Column<string>(nullable: false),
                    RowEditDate = table.Column<DateTime>(nullable: false),
                    RowEditUser = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowAddDate = table.Column<DateTime>(nullable: false),
                    RowAddUser = table.Column<string>(nullable: false),
                    RowEditDate = table.Column<DateTime>(nullable: false),
                    RowEditUser = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 150, nullable: false),
                    SecondName = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    Contact = table.Column<string>(maxLength: 15, nullable: false),
                    Notes = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Registrations_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_UserID",
                table: "Registrations",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
