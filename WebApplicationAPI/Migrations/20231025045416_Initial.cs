using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fabrics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabrics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tshirts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tshirts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorTshirt",
                columns: table => new
                {
                    ColorsId = table.Column<int>(type: "int", nullable: false),
                    TshirtsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorTshirt", x => new { x.ColorsId, x.TshirtsId });
                    table.ForeignKey(
                        name: "FK_ColorTshirt_Colors_ColorsId",
                        column: x => x.ColorsId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorTshirt_Tshirts_TshirtsId",
                        column: x => x.TshirtsId,
                        principalTable: "Tshirts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FabricTshirt",
                columns: table => new
                {
                    FabricsId = table.Column<int>(type: "int", nullable: false),
                    TshirtsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FabricTshirt", x => new { x.FabricsId, x.TshirtsId });
                    table.ForeignKey(
                        name: "FK_FabricTshirt_Fabrics_FabricsId",
                        column: x => x.FabricsId,
                        principalTable: "Fabrics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FabricTshirt_Tshirts_TshirtsId",
                        column: x => x.TshirtsId,
                        principalTable: "Tshirts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TshirtImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TshirtId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    FabricId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TshirtImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TshirtImages_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TshirtImages_Fabrics_FabricId",
                        column: x => x.FabricId,
                        principalTable: "Fabrics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TshirtImages_Tshirts_TshirtId",
                        column: x => x.TshirtId,
                        principalTable: "Tshirts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColorTshirt_TshirtsId",
                table: "ColorTshirt",
                column: "TshirtsId");

            migrationBuilder.CreateIndex(
                name: "IX_FabricTshirt_TshirtsId",
                table: "FabricTshirt",
                column: "TshirtsId");

            migrationBuilder.CreateIndex(
                name: "IX_TshirtImages_ColorId",
                table: "TshirtImages",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_TshirtImages_FabricId",
                table: "TshirtImages",
                column: "FabricId");

            migrationBuilder.CreateIndex(
                name: "IX_TshirtImages_TshirtId",
                table: "TshirtImages",
                column: "TshirtId");

            migrationBuilder.Sql(@"
                insert into Tshirts(code, ModelName)
                values('001', 'SKELETON T-SHIRT');

                insert into Tshirts(code, ModelName)
                values('002', 'UNICORN T-SHIRT');

                insert into Tshirts(code, ModelName)
                values('001', 'STAR WARS T-SHIRT');

                insert into Colors(name)
                values('RED');

                insert into Colors(name)
                values('GREEN');

                insert into Colors(name)
                values('BLUE');

                insert into Colors(name)
                values('WHITE');

                insert into Colors(name)
                values('BLACK');

                insert into Fabrics(name)
                values('COTTON');

                insert into Fabrics(name)
                values('LINEN');

                insert into Fabrics(name)
                values('MUSLIN');

                insert into Fabrics(name)
                values('WOOL');

                insert into Fabrics(name)
                values('SILK');

                insert into FabricTshirt(FabricsId, TshirtsId)
                values(1, 1);

                insert into FabricTshirt(FabricsId, TshirtsId)
                values(2, 1);

                insert into FabricTshirt(FabricsId, TshirtsId)
                values(1, 2);

                insert into FabricTshirt(FabricsId, TshirtsId)
                values(2, 2);

                insert into FabricTshirt(FabricsId, TshirtsId)
                values(3, 2);

                insert into FabricTshirt(FabricsId, TshirtsId)
                values(4, 3);

                insert into ColorTshirt(ColorsId, TshirtsId)
                values(1, 1);

                insert into ColorTshirt(ColorsId, TshirtsId)
                values(2, 1);

                insert into ColorTshirt(ColorsId, TshirtsId)
                values(1, 2);

                insert into ColorTshirt(ColorsId, TshirtsId)
                values(2, 2);

                insert into ColorTshirt(ColorsId, TshirtsId)
                values(3, 2);

                insert into ColorTshirt(ColorsId, TshirtsId)
                values(1, 3);

                insert into ColorTshirt(ColorsId, TshirtsId)
                values(4, 3);

                insert into ColorTshirt(ColorsId, TshirtsId)
                values(5, 3);
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColorTshirt");

            migrationBuilder.DropTable(
                name: "FabricTshirt");

            migrationBuilder.DropTable(
                name: "TshirtImages");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Fabrics");

            migrationBuilder.DropTable(
                name: "Tshirts");
        }
    }
}
