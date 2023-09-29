using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvisionStudioPokemonAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedSpritesToFavorite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Back_Sprite",
                table: "FavoritePokemons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Front_Sprite",
                table: "FavoritePokemons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Back_Sprite",
                table: "FavoritePokemons");

            migrationBuilder.DropColumn(
                name: "Front_Sprite",
                table: "FavoritePokemons");
        }
    }
}
