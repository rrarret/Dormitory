﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dormitory.Migrations
{
    public partial class AddRoomForAnnouncements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Announcements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_RoomId",
                table: "Announcements",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Announcements",
                table: "Announcements",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Announcements",
                table: "Announcements");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_RoomId",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Announcements");
        }
    }
}
