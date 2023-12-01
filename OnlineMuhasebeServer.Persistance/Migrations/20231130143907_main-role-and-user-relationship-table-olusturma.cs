using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMuhasebeServer.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mainroleanduserrelationshiptableolusturma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAndCompanyRelationships_Companies_CompanyId",
                table: "UserAndCompanyRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAndCompanyRelationships_Users_AppUserId",
                table: "UserAndCompanyRelationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAndCompanyRelationships",
                table: "UserAndCompanyRelationships");

            migrationBuilder.RenameTable(
                name: "UserAndCompanyRelationships",
                newName: "UserAndCompanyRelationship");

            migrationBuilder.RenameIndex(
                name: "IX_UserAndCompanyRelationships_CompanyId",
                table: "UserAndCompanyRelationship",
                newName: "IX_UserAndCompanyRelationship_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAndCompanyRelationships_AppUserId",
                table: "UserAndCompanyRelationship",
                newName: "IX_UserAndCompanyRelationship_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAndCompanyRelationship",
                table: "UserAndCompanyRelationship",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAndCompanyRelationship_Companies_CompanyId",
                table: "UserAndCompanyRelationship",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAndCompanyRelationship_Users_AppUserId",
                table: "UserAndCompanyRelationship",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAndCompanyRelationship_Companies_CompanyId",
                table: "UserAndCompanyRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAndCompanyRelationship_Users_AppUserId",
                table: "UserAndCompanyRelationship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAndCompanyRelationship",
                table: "UserAndCompanyRelationship");

            migrationBuilder.RenameTable(
                name: "UserAndCompanyRelationship",
                newName: "UserAndCompanyRelationships");

            migrationBuilder.RenameIndex(
                name: "IX_UserAndCompanyRelationship_CompanyId",
                table: "UserAndCompanyRelationships",
                newName: "IX_UserAndCompanyRelationships_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAndCompanyRelationship_AppUserId",
                table: "UserAndCompanyRelationships",
                newName: "IX_UserAndCompanyRelationships_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAndCompanyRelationships",
                table: "UserAndCompanyRelationships",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAndCompanyRelationships_Companies_CompanyId",
                table: "UserAndCompanyRelationships",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAndCompanyRelationships_Users_AppUserId",
                table: "UserAndCompanyRelationships",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
