using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMuhasebeServer.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class usermainroleanduserrelationshiptableolustruma2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainRoleAndRoleRelationships_MainRoles_MainRoleId",
                table: "MainRoleAndRoleRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_MainRoleAndRoleRelationships_Roles_RoleId",
                table: "MainRoleAndRoleRelationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainRoleAndRoleRelationships",
                table: "MainRoleAndRoleRelationships");

            migrationBuilder.RenameTable(
                name: "MainRoleAndRoleRelationships",
                newName: "MainRoleAndRoleRelationship");

            migrationBuilder.RenameIndex(
                name: "IX_MainRoleAndRoleRelationships_RoleId",
                table: "MainRoleAndRoleRelationship",
                newName: "IX_MainRoleAndRoleRelationship_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_MainRoleAndRoleRelationships_MainRoleId",
                table: "MainRoleAndRoleRelationship",
                newName: "IX_MainRoleAndRoleRelationship_MainRoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainRoleAndRoleRelationship",
                table: "MainRoleAndRoleRelationship",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MainRoleAndUserRelationships",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MainRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainRoleAndUserRelationships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainRoleAndUserRelationships_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MainRoleAndUserRelationships_MainRoles_MainRoleId",
                        column: x => x.MainRoleId,
                        principalTable: "MainRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MainRoleAndUserRelationships_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MainRoleAndUserRelationships_CompanyId",
                table: "MainRoleAndUserRelationships",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MainRoleAndUserRelationships_MainRoleId",
                table: "MainRoleAndUserRelationships",
                column: "MainRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_MainRoleAndUserRelationships_UserId",
                table: "MainRoleAndUserRelationships",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MainRoleAndRoleRelationship_MainRoles_MainRoleId",
                table: "MainRoleAndRoleRelationship",
                column: "MainRoleId",
                principalTable: "MainRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MainRoleAndRoleRelationship_Roles_RoleId",
                table: "MainRoleAndRoleRelationship",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainRoleAndRoleRelationship_MainRoles_MainRoleId",
                table: "MainRoleAndRoleRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MainRoleAndRoleRelationship_Roles_RoleId",
                table: "MainRoleAndRoleRelationship");

            migrationBuilder.DropTable(
                name: "MainRoleAndUserRelationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainRoleAndRoleRelationship",
                table: "MainRoleAndRoleRelationship");

            migrationBuilder.RenameTable(
                name: "MainRoleAndRoleRelationship",
                newName: "MainRoleAndRoleRelationships");

            migrationBuilder.RenameIndex(
                name: "IX_MainRoleAndRoleRelationship_RoleId",
                table: "MainRoleAndRoleRelationships",
                newName: "IX_MainRoleAndRoleRelationships_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_MainRoleAndRoleRelationship_MainRoleId",
                table: "MainRoleAndRoleRelationships",
                newName: "IX_MainRoleAndRoleRelationships_MainRoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainRoleAndRoleRelationships",
                table: "MainRoleAndRoleRelationships",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MainRoleAndRoleRelationships_MainRoles_MainRoleId",
                table: "MainRoleAndRoleRelationships",
                column: "MainRoleId",
                principalTable: "MainRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MainRoleAndRoleRelationships_Roles_RoleId",
                table: "MainRoleAndRoleRelationships",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
