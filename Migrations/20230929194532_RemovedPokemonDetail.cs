using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvisionStudioPokemonAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemovedPokemonDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoritePokemons_PokemonDetail_PokemonDetailId",
                table: "FavoritePokemons");

            migrationBuilder.DropTable(
                name: "AbilityInfo");

            migrationBuilder.DropTable(
                name: "MoveInfo");

            migrationBuilder.DropTable(
                name: "StatInfo");

            migrationBuilder.DropTable(
                name: "TypeInfo");

            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "Move");

            migrationBuilder.DropTable(
                name: "Stat");

            migrationBuilder.DropTable(
                name: "PokemonDetail");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "Sprites");

            migrationBuilder.DropIndex(
                name: "IX_FavoritePokemons_PokemonDetailId",
                table: "FavoritePokemons");

            migrationBuilder.DropColumn(
                name: "PokemonDetailId",
                table: "FavoritePokemons");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PokemonDetailId",
                table: "FavoritePokemons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Move",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Move", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sprites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BackDefault = table.Column<string>(type: "TEXT", nullable: false),
                    BackFemale = table.Column<string>(type: "TEXT", nullable: false),
                    BackShiny = table.Column<string>(type: "TEXT", nullable: false),
                    BackShinyFemale = table.Column<string>(type: "TEXT", nullable: false),
                    FrontDefault = table.Column<string>(type: "TEXT", nullable: false),
                    FrontFemale = table.Column<string>(type: "TEXT", nullable: false),
                    FrontShiny = table.Column<string>(type: "TEXT", nullable: false),
                    FrontShinyFemale = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SpritesId = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseExperience = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Order = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonDetail_Sprites_SpritesId",
                        column: x => x.SpritesId,
                        principalTable: "Sprites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbilityInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AbilityId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsHidden = table.Column<bool>(type: "INTEGER", nullable: false),
                    PokemonDetailId = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbilityInfo_Ability_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbilityInfo_PokemonDetail_PokemonDetailId",
                        column: x => x.PokemonDetailId,
                        principalTable: "PokemonDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MoveInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MoveId = table.Column<int>(type: "INTEGER", nullable: false),
                    PokemonDetailId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoveInfo_Move_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Move",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoveInfo_PokemonDetail_PokemonDetailId",
                        column: x => x.PokemonDetailId,
                        principalTable: "PokemonDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StatInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StatId = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseStat = table.Column<int>(type: "INTEGER", nullable: false),
                    Effort = table.Column<int>(type: "INTEGER", nullable: false),
                    PokemonDetailId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatInfo_PokemonDetail_PokemonDetailId",
                        column: x => x.PokemonDetailId,
                        principalTable: "PokemonDetail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StatInfo_Stat_StatId",
                        column: x => x.StatId,
                        principalTable: "Stat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PokemonDetailId = table.Column<int>(type: "INTEGER", nullable: true),
                    Slot = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeInfo_PokemonDetail_PokemonDetailId",
                        column: x => x.PokemonDetailId,
                        principalTable: "PokemonDetail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TypeInfo_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoritePokemons_PokemonDetailId",
                table: "FavoritePokemons",
                column: "PokemonDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityInfo_AbilityId",
                table: "AbilityInfo",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityInfo_PokemonDetailId",
                table: "AbilityInfo",
                column: "PokemonDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveInfo_MoveId",
                table: "MoveInfo",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_MoveInfo_PokemonDetailId",
                table: "MoveInfo",
                column: "PokemonDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonDetail_SpritesId",
                table: "PokemonDetail",
                column: "SpritesId");

            migrationBuilder.CreateIndex(
                name: "IX_StatInfo_PokemonDetailId",
                table: "StatInfo",
                column: "PokemonDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_StatInfo_StatId",
                table: "StatInfo",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeInfo_PokemonDetailId",
                table: "TypeInfo",
                column: "PokemonDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeInfo_TypeId",
                table: "TypeInfo",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoritePokemons_PokemonDetail_PokemonDetailId",
                table: "FavoritePokemons",
                column: "PokemonDetailId",
                principalTable: "PokemonDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
