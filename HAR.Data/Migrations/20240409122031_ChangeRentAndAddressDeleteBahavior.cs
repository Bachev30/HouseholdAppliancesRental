﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HAR.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRentAndAddressDeleteBahavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Addresses_AddressId",
                table: "Rents");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Addresses_AddressId",
                table: "Rents",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Addresses_AddressId",
                table: "Rents");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Addresses_AddressId",
                table: "Rents",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
