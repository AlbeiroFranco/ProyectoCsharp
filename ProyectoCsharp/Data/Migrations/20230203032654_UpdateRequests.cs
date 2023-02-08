using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoCsharp.Data.Migrations
{
    public partial class UpdateRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                column: "ConcurrencyStamp",
                value: "84676f75-5329-4e30-9893-cac7f68aa0bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                column: "ConcurrencyStamp",
                value: "7b6960ae-76d2-493b-91a9-e447dc5732e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851a296-6b9b-481c-a00e-17f5a5b0bf00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26bb4ae5-0454-429c-939c-eebb4f46bd9c", "AQAAAAEAACcQAAAAEEd8GCAVR+iqF5PQcGZ4Z1lNmk3DlcanJ5cj4IdWEKIJaGi92lcdCherHxueRUyH/A==", "7b81b5f8-a993-4ac0-b311-35745a9c26d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed55405b-f95f-472b-b881-2bcf426aca7d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7f9944d-bea5-4450-9a0a-50a755810df7", "AQAAAAEAACcQAAAAEH3k4ZnUFA/TmF/aOzNfIUieH2/X+DyB3tYx1ry4tVOzLduIjEGYowzcprvrHL0hIg==", "17139dec-be83-442a-beb1-eedaf0bedfe4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                column: "ConcurrencyStamp",
                value: "dcabb6a0-8c57-4fbf-90b6-b522b9b68d06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                column: "ConcurrencyStamp",
                value: "f3550d25-24c5-4a3d-89a3-c5bab608f4a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851a296-6b9b-481c-a00e-17f5a5b0bf00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e55293ed-4825-4ae9-9fb9-fe65fcc6431d", "AQAAAAEAACcQAAAAEIQPSSc9JIGGyNCqXPwAke5lxiEhmVKMpBpMdwxLUKX8IfmMVrxx7MyXLPvrmQAvJw==", "2650eee3-8b4f-4492-90df-c66d205a5775" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed55405b-f95f-472b-b881-2bcf426aca7d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c63afbba-8c2d-4d14-9624-a9c72f910c38", "AQAAAAEAACcQAAAAEFtPjI08OI/qkifRxtraDVDfTxCDM84pQVyltytfAJ51fEGQLvMELdnGLbp8ji0XpQ==", "66a49909-ee95-4175-b44f-9b5f954f9147" });
        }
    }
}
