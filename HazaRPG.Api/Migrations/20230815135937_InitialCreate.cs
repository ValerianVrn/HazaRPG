using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HazaRPG.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    Dodge = table.Column<int>(type: "int", nullable: false),
                    Aggro = table.Column<int>(type: "int", nullable: false),
                    AttackEquipmentId = table.Column<int>(type: "int", nullable: false),
                    DefenseEquipmentId = table.Column<int>(type: "int", nullable: false),
                    ArtifactEquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Equipments_ArtifactEquipmentId",
                        column: x => x.ArtifactEquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Equipments_AttackEquipmentId",
                        column: x => x.AttackEquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Equipments_DefenseEquipmentId",
                        column: x => x.DefenseEquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stamina = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentActions_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Dices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Faces = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiceType = table.Column<int>(type: "int", nullable: false),
                    EquipmentActionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dices_EquipmentActions_EquipmentActionId",
                        column: x => x.EquipmentActionId,
                        principalTable: "EquipmentActions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ArtifactEquipmentId",
                table: "Characters",
                column: "ArtifactEquipmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AttackEquipmentId",
                table: "Characters",
                column: "AttackEquipmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_DefenseEquipmentId",
                table: "Characters",
                column: "DefenseEquipmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dices_EquipmentActionId",
                table: "Dices",
                column: "EquipmentActionId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentActions_EquipmentId",
                table: "EquipmentActions",
                column: "EquipmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Dices");

            migrationBuilder.DropTable(
                name: "EquipmentActions");

            migrationBuilder.DropTable(
                name: "Equipments");
        }
    }
}
