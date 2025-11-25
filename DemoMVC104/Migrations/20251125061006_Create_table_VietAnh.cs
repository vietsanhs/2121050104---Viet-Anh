using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMVC104.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_VietAnh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Person",
                newName: "PersonId");

            migrationBuilder.CreateTable(
                name: "VietAnh",
                columns: table => new
                {
                    PersonId = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VietAnh", x => x.PersonId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VietAnh");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Person",
                newName: "PersonID");
        }
    }
}
