using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoCsharp.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3983dd2b-c46c-49b8-9cf1-a926a4dc8730", "JOSE@TEST.COM", "AQAAAAEAACcQAAAAECEYEjM3CdovatML08OEPtEY2VSdk17826TOeTpIXOnRMEUUXx+92ZSmvKUKH5w9qw==", "f6a6838d-39bc-404c-9ecf-94fdf9dc1067", "jose@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed55405b-f95f-472b-b881-2bcf426aca7d",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4c4d205c-dcc2-4a48-b15e-5d25347eb3b5", "USER@TEST.COM", "AQAAAAEAACcQAAAAEHM6iBe+Ldw8muOZ3bpPnfCfQwGNhmfMFDBFZR5qHV9EikQv68EZymgjrfNsYEWfzw==", "fe6d8486-6ecc-45e4-be79-bde6bdb520dc", "user@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                column: "ConcurrencyStamp",
                value: "a8e19a0b-67a3-40b0-bfab-3e0e7690975e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                column: "ConcurrencyStamp",
                value: "ccf1cb8a-2667-4b62-a4eb-207b6e2a5a1a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851a296-6b9b-481c-a00e-17f5a5b0bf00",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2d4a52cc-0913-4de2-99ef-f28f5ebcd7f4", null, "AQAAAAEAACcQAAAAED8J8MQOEayA10/GvBJ2Vssbn6sFCRaNjV7ieEuGNM2d94cHpWDn6ocCyQJ4JJ6oaA==", "984a5162-b517-4d38-b0a4-17458411c821", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed55405b-f95f-472b-b881-2bcf426aca7d",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b689a994-9e79-4d7c-92e1-cb15dc67dc97", null, "AQAAAAEAACcQAAAAEIo5mBS/FSXGr3l0NUcEXde+ap180ozbACleDRf4tftG0Jb4OETLbhJmL/bQnGK6Pw==", "cb013c0c-d461-4713-a19b-0089b5441162", null });
        }
    }
}
