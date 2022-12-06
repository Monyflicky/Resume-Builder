using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesResume.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false),
                    profession = table.Column<string>(nullable: false),
                    city = table.Column<string>(nullable: false),
                    province = table.Column<string>(nullable: false),
                    postalcode = table.Column<string>(nullable: false),
                    phoneNumber = table.Column<string>(nullable: false),
                    emailAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
