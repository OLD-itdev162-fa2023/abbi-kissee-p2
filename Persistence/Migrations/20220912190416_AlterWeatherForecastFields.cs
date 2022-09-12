using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AlterWeatherForecastFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Temperature",
                table: "WeatherForecasts",
                newName: "TemperatureC");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "WeatherForecasts",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "WeatherForecasts",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "WeatherForecasts");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "WeatherForecasts");

            migrationBuilder.RenameColumn(
                name: "TemperatureC",
                table: "WeatherForecasts",
                newName: "Temperature");
        }
    }
}
