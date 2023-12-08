using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMuhasebeServer.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class entityupdateddateduzeltildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "UserAndCompanyRelationship",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "MainRoles",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "MainRoleAndUserRelationships",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "MainRoleAndRoleRelationship",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Companies",
                newName: "UpdatedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "UserAndCompanyRelationship",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "MainRoles",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "MainRoleAndUserRelationships",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "MainRoleAndRoleRelationship",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Companies",
                newName: "UpdateDate");
        }
    }
}
