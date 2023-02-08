using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoCsharp.Data.Migrations
{
    public partial class Request : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                column: "ConcurrencyStamp",
                value: "6c955fb2-5459-46fd-a6cc-05d964966d5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                column: "ConcurrencyStamp",
                value: "aeb7d61d-0ec8-4116-a001-089ce5042386");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8851a296-6b9b-481c-a00e-17f5a5b0bf00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e50e046e-d2b9-46fd-b8ce-8d1e03cd1f98", "AQAAAAEAACcQAAAAEFdZs3a1oNEpKr72P+LBGBl/vp0yMb+oILkjUwrMTdj6eI9TFtNXjOpAoZrKXNxXdQ==", "01bfbafd-8f98-4a06-9216-db8f105f9cb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed55405b-f95f-472b-b881-2bcf426aca7d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1179b8d6-4475-4b90-8173-df32d537d080", "AQAAAAEAACcQAAAAEEdttaz2FdSLKUg4usmvlIkFb8xM06g5AnUNQmpYi8yWCqOO6ixXPuorGkAcVoNX1w==", "bcfd2579-3d1f-4536-bf4d-5fb591634bb0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
