using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoCsharp.Data.Migrations
{
    public partial class actulizacionBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                column: "ConcurrencyStamp",
                value: "8d5b197d-dba6-4d78-be88-bb0ae2b1ef2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                column: "ConcurrencyStamp",
                value: "1fb95c4a-eec6-423a-85b0-9fbab864a9f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851a296-6b9b-481c-a00e-17f5a5b0bf00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc038e2e-fb32-4489-a270-ade214996b72", "AQAAAAEAACcQAAAAEAWuLQJ5uYMdscpwqCFK4bnDvikwnolLbI5mQc5sFw5AlK89y5HumfZ9pioC9teynQ==", "13a616d4-2503-4e56-a09a-f2efa71cbb80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed55405b-f95f-472b-b881-2bcf426aca7d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da03604e-04c3-4f5b-bccf-4489f26d9578", "AQAAAAEAACcQAAAAEMAbHFycL3j4nu0e11ckR16qDmkbn9FT8KstsFhftsiC4PzYQBQjanPDU1zcp5/vTA==", "865af67a-0247-4b11-b782-40602074ff12" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
