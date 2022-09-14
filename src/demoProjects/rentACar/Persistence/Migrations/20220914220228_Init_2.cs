using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Init_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SomeFeatureEntities",
                table: "SomeFeatureEntities");

            migrationBuilder.RenameTable(
                name: "SomeFeatureEntities",
                newName: "Brand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.RenameTable(
                name: "Brand",
                newName: "SomeFeatureEntities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SomeFeatureEntities",
                table: "SomeFeatureEntities",
                column: "Id");
        }
    }
}
