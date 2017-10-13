using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Photerva.Lib.Migrations
{
    public partial class SessionOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Session",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Session_OwnerID",
                table: "Session",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Session_AspNetUsers_OwnerID",
                table: "Session",
                column: "OwnerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Session_AspNetUsers_OwnerID",
                table: "Session");

            migrationBuilder.DropIndex(
                name: "IX_Session_OwnerID",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Session");
        }
    }
}
