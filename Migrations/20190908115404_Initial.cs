using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace LinkShortener.Migrations
{
	public partial class Initial : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Links",
				columns: table => new
				{
					ShortUrl = table.Column<string>(nullable: false),
					Url = table.Column<string>(nullable: true),
					CreationDate = table.Column<DateTime>(nullable: false),
					Counter = table.Column<uint>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Links", x => x.ShortUrl);
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Links");
		}
	}
}
