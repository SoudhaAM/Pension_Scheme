using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PravasiPensionScheme.Migrations
{
    /// <inheritdoc />
    public partial class alter1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "tbl_Plan",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "tbl_Plan");
        }
    }
}
