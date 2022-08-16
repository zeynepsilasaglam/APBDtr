using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace p2.Migrations
{
    public partial class myf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BreedTypes",
                columns: table => new
                {
                    IdBreedType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedTypes", x => x.IdBreedType);
                });

            migrationBuilder.CreateTable(
                name: "Voluenteers",
                columns: table => new
                {
                    IdVoluenteer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSupervisor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voluenteers", x => x.IdVoluenteer);
                    table.ForeignKey(
                        name: "FK_Voluenteers_Voluenteers_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "Voluenteers",
                        principalColumn: "IdVoluenteer");
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    IdPet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    isMale = table.Column<bool>(type: "bit", nullable: false),
                    DateRegistered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApproximateDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateAdopted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdBreedType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.IdPet);
                    table.ForeignKey(
                        name: "FK_Pets_BreedTypes_IdBreedType",
                        column: x => x.IdBreedType,
                        principalTable: "BreedTypes",
                        principalColumn: "IdBreedType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoluenteerPets",
                columns: table => new
                {
                    IdVoluenteer = table.Column<int>(type: "int", nullable: false),
                    IdPet = table.Column<int>(type: "int", nullable: false),
                    DateAccepted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoluenteerPets", x => new { x.IdPet, x.IdVoluenteer });
                    table.ForeignKey(
                        name: "FK_VoluenteerPets_Pets_IdPet",
                        column: x => x.IdPet,
                        principalTable: "Pets",
                        principalColumn: "IdPet",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoluenteerPets_Voluenteers_IdVoluenteer",
                        column: x => x.IdVoluenteer,
                        principalTable: "Voluenteers",
                        principalColumn: "IdVoluenteer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BreedTypes",
                columns: new[] { "IdBreedType", "Description", "Name" },
                values: new object[] { 1, "ddkd", "djdjd" });

            migrationBuilder.InsertData(
                table: "Voluenteers",
                columns: new[] { "IdVoluenteer", "IdSupervisor", "Name", "StartingDate", "Surname" },
                values: new object[] { 1, 1, "sjdj", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsjdd" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "IdPet", "ApproximateDateOfBirth", "DateAdopted", "DateRegistered", "IdBreedType", "Name", "isMale" },
                values: new object[] { 1, new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "djjdjd", false });

            migrationBuilder.InsertData(
                table: "VoluenteerPets",
                columns: new[] { "IdPet", "IdVoluenteer", "DateAccepted" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_IdBreedType",
                table: "Pets",
                column: "IdBreedType");

            migrationBuilder.CreateIndex(
                name: "IX_VoluenteerPets_IdVoluenteer",
                table: "VoluenteerPets",
                column: "IdVoluenteer");

            migrationBuilder.CreateIndex(
                name: "IX_Voluenteers_IdSupervisor",
                table: "Voluenteers",
                column: "IdSupervisor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VoluenteerPets");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Voluenteers");

            migrationBuilder.DropTable(
                name: "BreedTypes");
        }
    }
}
