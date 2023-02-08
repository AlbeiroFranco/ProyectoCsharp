using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoCsharp.Data.Migrations
{
    public partial class LeaveRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                column: "ConcurrencyStamp",
                value: "a365670f-2f48-4583-8921-fb1068ce5985");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                column: "ConcurrencyStamp",
                value: "d926c98f-c166-448c-abfe-0e4e69ac7035");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851a296-6b9b-481c-a00e-17f5a5b0bf00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddf33878-76ba-4269-ab9e-0f11f190382b", "AQAAAAEAACcQAAAAEIQiGO02hjTYCb4IQAG0mJI/DjcqU/o5o3ZsGBpF77UOI+JT4Jse+9WL5x3We2U+WQ==", "274327fd-00d9-43b9-819b-f72f06999899" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed55405b-f95f-472b-b881-2bcf426aca7d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c17094b-7776-4c4f-9f0d-e86691b6a2f9", "AQAAAAEAACcQAAAAEKJvQTwzTmJyW8KIb8SGMW8Y1yIBQo+r67ek/y8j1E/jx66Ju7qLtSI5D9IR483Czg==", "b8434977-3a7b-4e19-8a40-e869a37fd21a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
