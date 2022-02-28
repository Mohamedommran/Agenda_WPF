using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agenda_WPF.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_brokers",
                table: "brokers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointments",
                table: "appointments");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "brokers",
                newName: "Brokers");

            migrationBuilder.RenameTable(
                name: "appointments",
                newName: "Appointments");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Customers",
                newName: "mail");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customers",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Budget",
                table: "Customers",
                newName: "budget");

            migrationBuilder.RenameColumn(
                name: "IdCustomer",
                table: "Customers",
                newName: "idCustomer");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customers",
                newName: "phone");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "idCustomer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brokers",
                table: "Brokers",
                column: "IdBroker");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "IdAppointment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brokers",
                table: "Brokers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customers");

            migrationBuilder.RenameTable(
                name: "Brokers",
                newName: "brokers");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "appointments");

            migrationBuilder.RenameColumn(
                name: "mail",
                table: "customers",
                newName: "Mail");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "customers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "budget",
                table: "customers",
                newName: "Budget");

            migrationBuilder.RenameColumn(
                name: "idCustomer",
                table: "customers",
                newName: "IdCustomer");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "customers",
                newName: "PhoneNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "IdCustomer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_brokers",
                table: "brokers",
                column: "IdBroker");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointments",
                table: "appointments",
                column: "IdAppointment");
        }
    }
}
