using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoCsharp.Data.Migrations
{
    public partial class UpdateRequests1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                column: "ConcurrencyStamp",
                value: "0ca74c8a-9bb1-41e9-8876-e1cdca70f92a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                column: "ConcurrencyStamp",
                value: "d7aeb9ba-bc31-4a89-b1c3-8282e311473f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851a296-6b9b-481c-a00e-17f5a5b0bf00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dcb4808-1ba2-4510-a966-e5530aa72515", "AQAAAAEAACcQAAAAEPknc+d0t3jc++VxFK2I/F/yxbB2evbGvCRJWv0CEEioX2j69KA7J15EurzMHGbfZw==", "4b99327f-9df1-417e-90f3-1d5b9c977d37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed55405b-f95f-472b-b881-2bcf426aca7d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7613d46-bd94-48af-878e-e0c07470a747", "AQAAAAEAACcQAAAAELRyC3TGVsxxm+0M7x8D9u04wPtgbdQrb1jpCcdKra4zNUfWPzhZGwsB1pIYhU97Nw==", "9032ae4c-d61a-43b7-a96c-34ec4bd03a5c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
