﻿using Microsoft.EntityFrameworkCore.Migrations;
using ShoppingCartEF.Extensions;

#nullable disable

namespace ShoppingCartEF.Migrations
{
    public partial class createUserBob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateUser("Bob", "password");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropUser("Bob");
        }
    }
}
