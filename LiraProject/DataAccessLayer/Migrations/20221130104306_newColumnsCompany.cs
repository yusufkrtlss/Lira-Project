using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class newColumnsCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CompanyEBITDA",
                table: "Companies",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "CompanyRegularMarketChange",
                table: "Companies",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "CompanyRegularMarketChangePercent",
                table: "Companies",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "CompanyRegularMarketDayHigh",
                table: "Companies",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "CompanyRegularMarketDayLow",
                table: "Companies",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "CompanyRegularMarketPrice",
                table: "Companies",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "CompanyRegularMarketVolume",
                table: "Companies",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyEBITDA",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyRegularMarketChange",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyRegularMarketChangePercent",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyRegularMarketDayHigh",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyRegularMarketDayLow",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyRegularMarketPrice",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyRegularMarketVolume",
                table: "Companies");
        }
    }
}
