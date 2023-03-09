using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    ImgUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoryID", "Nombre", "Url" },
                values: new object[,]
                {
                    { 1, "Jabon Barra", "JabonBarra" },
                    { 2, "Jabon Liquido", "JabonLiguido" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ID", "CategoriaID", "Descripcion", "ImgUrl", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, 1, "Irish Spring", "https://desiweb.com.do/DesiWebEcommerce/views/document/product/201/1460/JAB20.jpg", "Jabon en barra Irish Spring", 30m },
                    { 2, 1, "Asepxia", "https://supermercadosnacional.com/media/catalog/product/cache/fde49a4ea9a339628caa0bc56aea00ff/2/1/2162627-1.jpg", "Jabon en barra Asepxia ", 30m },
                    { 3, 2, "Irish Spring", "https://almacen.do/wp-content/uploads/2020/06/Jabo%CC%81n-Li%CC%81quido-de-Ducha-Corporal-Irish-Spring-Original-20-oz-Front.jpg", "Jabon en Liquido Irish Spring ", 70m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaID",
                table: "Productos",
                column: "CategoriaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
