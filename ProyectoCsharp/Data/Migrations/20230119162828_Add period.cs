using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoCsharp.Data.Migrations
{
    public partial class Addperiod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                column: "ConcurrencyStamp",
                value: "e854e255-0571-4704-bf2b-78c6af6031de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                column: "ConcurrencyStamp",
                value: "655404d6-f984-4ef6-8b5b-fbac61e8df39");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851a296-6b9b-481c-a00e-17f5a5b0bf00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a449c5d-0dcc-4686-8b26-e4719250c595", "AQAAAAEAACcQAAAAEPv1tn5Rtq9drlSLCSaewYwOzmU3d4e5HTLX+PcRCIrfULtWunbtCNBW2FcmJ9onvw==", "ef819aaf-c72b-4d70-9272-b595a3aa136d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed55405b-f95f-472b-b881-2bcf426aca7d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b018b2c-5751-43a2-aebc-da72a27c3192", "AQAAAAEAACcQAAAAEH2p//vkwgyDmMiAFfwO7+9tXx8dAP7lQQI9qlkeFf1jSnI9ccVfB3vaileNW39CNg==", "6da060e4-d7b8-4371-9e24-9bd9acf3f753" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocation");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                column: "ConcurrencyStamp",
                value: "9b196ed5-3d69-46bc-8fee-178f249d8fa1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                column: "ConcurrencyStamp",
                value: "6d5de9d5-267e-4f4f-9e23-24d4ea83369c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851a296-6b9b-481c-a00e-17f5a5b0bf00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3983dd2b-c46c-49b8-9cf1-a926a4dc8730", "AQAAAAEAACcQAAAAECEYEjM3CdovatML08OEPtEY2VSdk17826TOeTpIXOnRMEUUXx+92ZSmvKUKH5w9qw==", "f6a6838d-39bc-404c-9ecf-94fdf9dc1067" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed55405b-f95f-472b-b881-2bcf426aca7d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c4d205c-dcc2-4a48-b15e-5d25347eb3b5", "AQAAAAEAACcQAAAAEHM6iBe+Ldw8muOZ3bpPnfCfQwGNhmfMFDBFZR5qHV9EikQv68EZymgjrfNsYEWfzw==", "fe6d8486-6ecc-45e4-be79-bde6bdb520dc" });
        }
    }
}
