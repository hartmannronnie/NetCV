using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SettingsImagesNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PortraitImageFileName",
                table: "Settings",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FavIconFileName",
                table: "Settings",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundImageFileName",
                table: "Settings",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "ABOUT_EMAIL",
                column: "Value",
                value: "john@netcv.com");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "ABOUT_EMAIL_LINK",
                column: "Value",
                value: "mailto:john@netcv.com");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "ABOUT_GITHUB",
                column: "Value",
                value: "hartmannronnie");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "ABOUT_GITHUB_LINK",
                column: "Value",
                value: "https://github.com/hartmannronnie");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "PROFILE_EMPLOYMENT",
                column: "Value",
                value: "Software Engineer");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "PROFILE_FULLNAME",
                column: "Value",
                value: "John Doe");

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BackgroundImageFileName", "FavIconFileName", "PortraitImageFileName" },
                values: new object[] { null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "PortraitImageFileName",
                keyValue: null,
                column: "PortraitImageFileName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PortraitImageFileName",
                table: "Settings",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "FavIconFileName",
                keyValue: null,
                column: "FavIconFileName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FavIconFileName",
                table: "Settings",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "BackgroundImageFileName",
                keyValue: null,
                column: "BackgroundImageFileName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundImageFileName",
                table: "Settings",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "ABOUT_EMAIL",
                column: "Value",
                value: "max@ronniehartmann.ch");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "ABOUT_EMAIL_LINK",
                column: "Value",
                value: "mailto:max@ronniehartmann.ch");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "ABOUT_GITHUB",
                column: "Value",
                value: "ronniehartmann");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "ABOUT_GITHUB_LINK",
                column: "Value",
                value: "https://github.com/ronniehartmann");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "PROFILE_EMPLOYMENT",
                column: "Value",
                value: "Applikationsentwickler");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Key",
                keyValue: "PROFILE_FULLNAME",
                column: "Value",
                value: "Max Mustermann");

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BackgroundImageFileName", "FavIconFileName", "PortraitImageFileName" },
                values: new object[] { "profile-background.jpg", "favicon.ico", "portrait.jpg" });
        }
    }
}
