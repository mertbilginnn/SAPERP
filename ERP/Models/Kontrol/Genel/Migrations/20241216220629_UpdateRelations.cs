using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BSMGRNNMGEN003",
                columns: table => new
                {
                    COUNTRYCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COUNTRYNAME = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMGEN003", x => x.COUNTRYCODE);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMGEN004",
                columns: table => new
                {
                    CITYCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CITYTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COUNTRYCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMGEN004", x => x.CITYCODE);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMGEN004_BSMGRNNMGEN003_COUNTRYCODE",
                        column: x => x.COUNTRYCODE,
                        principalTable: "BSMGRNNMGEN003",
                        principalColumn: "COUNTRYCODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMGEN001",
                columns: table => new
                {
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMTEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ADRESS1 = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ADRESS2 = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    CITYCODE = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    COUNTRYCODE = table.Column<string>(type: "nvarchar(4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMGEN001", x => x.COMCODE);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMGEN001_BSMGRNNMGEN003_COUNTRYCODE",
                        column: x => x.COUNTRYCODE,
                        principalTable: "BSMGRNNMGEN003",
                        principalColumn: "COUNTRYCODE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMGEN001_BSMGRNNMGEN004_CITYCODE",
                        column: x => x.CITYCODE,
                        principalTable: "BSMGRNNMGEN004",
                        principalColumn: "CITYCODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMBOM001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<int>(type: "int", nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMBOM001", x => x.DOCTYPE);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMBOM001_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMCCM001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<int>(type: "int", nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMCCM001", x => x.DOCTYPE);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMCCM001_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMCCMHEAD",
                columns: table => new
                {
                    CCMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CCMDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CCMDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MAINCCMDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAINCCMDOCTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISDELETED = table.Column<int>(type: "int", nullable: false),
                    ISPASSIVE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMCCMHEAD", x => x.CCMDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMCCMHEAD_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMGEN002",
                columns: table => new
                {
                    LANCODE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LANTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMGEN002", x => x.LANCODE);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMGEN002_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMGEN005",
                columns: table => new
                {
                    UNITCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    UNITTEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISMAINUNIT = table.Column<int>(type: "int", nullable: false),
                    MAINUNITCODE = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMGEN005", x => x.UNITCODE);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMGEN005_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMMAT001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<int>(type: "int", nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMMAT001", x => x.DOCTYPE);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMMAT001_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMMATHEAD",
                columns: table => new
                {
                    MATDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MATDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SUPPLYTYPE = table.Column<int>(type: "int", nullable: false),
                    STUNIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NETWEIGHT = table.Column<double>(type: "float", nullable: false),
                    NWUNIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BRUTWEIGHT = table.Column<double>(type: "float", nullable: false),
                    BWUNIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBOM = table.Column<int>(type: "int", nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISROUTE = table.Column<int>(type: "int", nullable: false),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISDELETED = table.Column<int>(type: "int", nullable: false),
                    ISPASSIVE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMMATHEAD", x => x.MATDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMOPR001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<int>(type: "int", nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMOPR001", x => x.DOCTYPE);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMOPR001_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMROT001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<int>(type: "int", nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMROT001", x => x.DOCTYPE);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROT001_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMWCM001",
                columns: table => new
                {
                    DOCTYPE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DOCTYPETEXT = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ISPASSIVE = table.Column<int>(type: "int", nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMWCM001", x => x.DOCTYPE);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMWCM001_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMWCMOPR",
                columns: table => new
                {
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    WCMDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OPRDOCTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMWCMOPR", x => x.WCMDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMWCMOPR_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMWCMHEAD",
                columns: table => new
                {
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    WCMDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MAINWCMDOCTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAINWCMDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCMDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    CCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    WORKTIME = table.Column<double>(type: "float", nullable: false),
                    ISDELETED = table.Column<int>(type: "int", nullable: false),
                    ISPASSIVE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMWCMHEAD", x => x.WCMDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMCCMHEAD_CCMDOCNUM",
                        column: x => x.CCMDOCNUM,
                        principalTable: "BSMGRNNMCCMHEAD",
                        principalColumn: "CCMDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMCCMHEAD_CCMDOCTYPE",
                        column: x => x.CCMDOCTYPE,
                        principalTable: "BSMGRNNMCCMHEAD",
                        principalColumn: "CCMDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMCCMTEXT",
                columns: table => new
                {
                    CCMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CCMDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CCMDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CCMSTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCMLTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMCCMTEXT", x => x.CCMDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMCCMTEXT_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMCCMTEXT_BSMGRNNMGEN002_LANCODE",
                        column: x => x.LANCODE,
                        principalTable: "BSMGRNNMGEN002",
                        principalColumn: "LANCODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMMATTEXT",
                columns: table => new
                {
                    MATDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MATDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MATSTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MATLTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMMATTEXT", x => x.MATDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMMATTEXT_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMMATTEXT_BSMGRNNMGEN002_LANCODE",
                        column: x => x.LANCODE,
                        principalTable: "BSMGRNNMGEN002",
                        principalColumn: "LANCODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMWCMTEXT",
                columns: table => new
                {
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    WCMDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WCMSTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WCMLTWXT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMWCMTEXT", x => x.WCMDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMWCMTEXT_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMWCMTEXT_BSMGRNNMGEN002_LANCODE",
                        column: x => x.LANCODE,
                        principalTable: "BSMGRNNMGEN002",
                        principalColumn: "LANCODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMBOMCONTENT",
                columns: table => new
                {
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    BOMDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BOMDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    CONTENTNUM = table.Column<int>(type: "int", nullable: false),
                    COMPONENT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COMPBOMDOCTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COMPBOMDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QUANTITY = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMBOMCONTENT", x => x.BOMDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMBOMCONTENT_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMBOMCONTENT_BSMGRNNMMATHEAD_MATDOCNUM",
                        column: x => x.MATDOCNUM,
                        principalTable: "BSMGRNNMMATHEAD",
                        principalColumn: "MATDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMBOMCONTENT_BSMGRNNMMATHEAD_MATDOCTYPE",
                        column: x => x.MATDOCTYPE,
                        principalTable: "BSMGRNNMMATHEAD",
                        principalColumn: "MATDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMBOMHEAD",
                columns: table => new
                {
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    BOMDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BOMDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    QUANTITY = table.Column<double>(type: "float", nullable: false),
                    ISDELETED = table.Column<int>(type: "int", nullable: false),
                    ISPASSIVE = table.Column<int>(type: "int", nullable: false),
                    DRAWNUM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMBOMHEAD", x => x.BOMDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMBOMHEAD_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMBOMHEAD_BSMGRNNMMATHEAD_MATDOCNUM",
                        column: x => x.MATDOCNUM,
                        principalTable: "BSMGRNNMMATHEAD",
                        principalColumn: "MATDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMBOMHEAD_BSMGRNNMMATHEAD_MATDOCTYPE",
                        column: x => x.MATDOCTYPE,
                        principalTable: "BSMGRNNMMATHEAD",
                        principalColumn: "MATDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMROTHEAD",
                columns: table => new
                {
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ROTDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ROTDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    QUANTITY = table.Column<double>(type: "float", nullable: false),
                    ISDELETED = table.Column<int>(type: "int", nullable: false),
                    ISPASSIVE = table.Column<int>(type: "int", nullable: false),
                    DRAWNUM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMROTHEAD", x => x.ROTDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTHEAD_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMATHEAD_MATDOCNUM",
                        column: x => x.MATDOCNUM,
                        principalTable: "BSMGRNNMMATHEAD",
                        principalColumn: "MATDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMATHEAD_MATDOCTYPE",
                        column: x => x.MATDOCTYPE,
                        principalTable: "BSMGRNNMMATHEAD",
                        principalColumn: "MATDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMROTOPRCONTENT",
                columns: table => new
                {
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ROTDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ROTDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    OPRNUM = table.Column<int>(type: "int", nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    OPRDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    SETUPTIME = table.Column<double>(type: "float", nullable: false),
                    MACHINETIME = table.Column<double>(type: "float", nullable: false),
                    LABOURTIME = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMROTOPRCONTENT", x => x.ROTDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTOPRCONTENT_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTOPRCONTENT_BSMGRNNMMATHEAD_MATDOCNUM",
                        column: x => x.MATDOCNUM,
                        principalTable: "BSMGRNNMMATHEAD",
                        principalColumn: "MATDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTOPRCONTENT_BSMGRNNMMATHEAD_MATDOCTYPE",
                        column: x => x.MATDOCTYPE,
                        principalTable: "BSMGRNNMMATHEAD",
                        principalColumn: "MATDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTOPRCONTENT_BSMGRNNMWCMHEAD_OPRDOCTYPE",
                        column: x => x.OPRDOCTYPE,
                        principalTable: "BSMGRNNMWCMHEAD",
                        principalColumn: "WCMDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTOPRCONTENT_BSMGRNNMWCMHEAD_WCMDOCNUM",
                        column: x => x.WCMDOCNUM,
                        principalTable: "BSMGRNNMWCMHEAD",
                        principalColumn: "WCMDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTOPRCONTENT_BSMGRNNMWCMHEAD_WCMDOCTYPE",
                        column: x => x.WCMDOCTYPE,
                        principalTable: "BSMGRNNMWCMHEAD",
                        principalColumn: "WCMDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BSMGRNNMROTBOMCONTENT",
                columns: table => new
                {
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ROTDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ROTDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    OPRNUM = table.Column<int>(type: "int", nullable: false),
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    CONTENTNUM = table.Column<int>(type: "int", nullable: false),
                    COMPONENT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QUANTITY = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BSMGRNNMROTBOMCONTENT", x => x.ROTDOCNUM);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTBOMCONTENT_BSMGRNNMBOMHEAD_BOMDOCNUM",
                        column: x => x.BOMDOCNUM,
                        principalTable: "BSMGRNNMBOMHEAD",
                        principalColumn: "BOMDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTBOMCONTENT_BSMGRNNMBOMHEAD_BOMDOCTYPE",
                        column: x => x.BOMDOCTYPE,
                        principalTable: "BSMGRNNMBOMHEAD",
                        principalColumn: "BOMDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTBOMCONTENT_BSMGRNNMGEN001_COMCODE",
                        column: x => x.COMCODE,
                        principalTable: "BSMGRNNMGEN001",
                        principalColumn: "COMCODE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTBOMCONTENT_BSMGRNNMMATHEAD_MATDOCNUM",
                        column: x => x.MATDOCNUM,
                        principalTable: "BSMGRNNMMATHEAD",
                        principalColumn: "MATDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BSMGRNNMROTBOMCONTENT_BSMGRNNMMATHEAD_MATDOCTYPE",
                        column: x => x.MATDOCTYPE,
                        principalTable: "BSMGRNNMMATHEAD",
                        principalColumn: "MATDOCNUM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMBOM001_COMCODE",
                table: "BSMGRNNMBOM001",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMBOMCONTENT_COMCODE",
                table: "BSMGRNNMBOMCONTENT",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMBOMCONTENT_MATDOCNUM",
                table: "BSMGRNNMBOMCONTENT",
                column: "MATDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMBOMCONTENT_MATDOCTYPE",
                table: "BSMGRNNMBOMCONTENT",
                column: "MATDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMBOMHEAD_COMCODE",
                table: "BSMGRNNMBOMHEAD",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMBOMHEAD_MATDOCNUM",
                table: "BSMGRNNMBOMHEAD",
                column: "MATDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMBOMHEAD_MATDOCTYPE",
                table: "BSMGRNNMBOMHEAD",
                column: "MATDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMCCM001_COMCODE",
                table: "BSMGRNNMCCM001",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMCCMHEAD_COMCODE",
                table: "BSMGRNNMCCMHEAD",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMCCMTEXT_COMCODE",
                table: "BSMGRNNMCCMTEXT",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMCCMTEXT_LANCODE",
                table: "BSMGRNNMCCMTEXT",
                column: "LANCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMGEN001_CITYCODE",
                table: "BSMGRNNMGEN001",
                column: "CITYCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMGEN001_COUNTRYCODE",
                table: "BSMGRNNMGEN001",
                column: "COUNTRYCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMGEN002_COMCODE",
                table: "BSMGRNNMGEN002",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMGEN004_COUNTRYCODE",
                table: "BSMGRNNMGEN004",
                column: "COUNTRYCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMGEN005_COMCODE",
                table: "BSMGRNNMGEN005",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMAT001_COMCODE",
                table: "BSMGRNNMMAT001",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATHEAD_COMCODE",
                table: "BSMGRNNMMATHEAD",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATTEXT_COMCODE",
                table: "BSMGRNNMMATTEXT",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATTEXT_LANCODE",
                table: "BSMGRNNMMATTEXT",
                column: "LANCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMOPR001_COMCODE",
                table: "BSMGRNNMOPR001",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROT001_COMCODE",
                table: "BSMGRNNMROT001",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTBOMCONTENT_BOMDOCNUM",
                table: "BSMGRNNMROTBOMCONTENT",
                column: "BOMDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTBOMCONTENT_BOMDOCTYPE",
                table: "BSMGRNNMROTBOMCONTENT",
                column: "BOMDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTBOMCONTENT_COMCODE",
                table: "BSMGRNNMROTBOMCONTENT",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTBOMCONTENT_MATDOCNUM",
                table: "BSMGRNNMROTBOMCONTENT",
                column: "MATDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTBOMCONTENT_MATDOCTYPE",
                table: "BSMGRNNMROTBOMCONTENT",
                column: "MATDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTHEAD_COMCODE",
                table: "BSMGRNNMROTHEAD",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTHEAD_MATDOCNUM",
                table: "BSMGRNNMROTHEAD",
                column: "MATDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTHEAD_MATDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "MATDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTOPRCONTENT_COMCODE",
                table: "BSMGRNNMROTOPRCONTENT",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTOPRCONTENT_MATDOCNUM",
                table: "BSMGRNNMROTOPRCONTENT",
                column: "MATDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTOPRCONTENT_MATDOCTYPE",
                table: "BSMGRNNMROTOPRCONTENT",
                column: "MATDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTOPRCONTENT_OPRDOCTYPE",
                table: "BSMGRNNMROTOPRCONTENT",
                column: "OPRDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTOPRCONTENT_WCMDOCNUM",
                table: "BSMGRNNMROTOPRCONTENT",
                column: "WCMDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTOPRCONTENT_WCMDOCTYPE",
                table: "BSMGRNNMROTOPRCONTENT",
                column: "WCMDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMWCM001_COMCODE",
                table: "BSMGRNNMWCM001",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMWCMHEAD_CCMDOCNUM",
                table: "BSMGRNNMWCMHEAD",
                column: "CCMDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMWCMHEAD_CCMDOCTYPE",
                table: "BSMGRNNMWCMHEAD",
                column: "CCMDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMWCMHEAD_COMCODE",
                table: "BSMGRNNMWCMHEAD",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMWCMOPR_COMCODE",
                table: "BSMGRNNMWCMOPR",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMWCMTEXT_COMCODE",
                table: "BSMGRNNMWCMTEXT",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMWCMTEXT_LANCODE",
                table: "BSMGRNNMWCMTEXT",
                column: "LANCODE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BSMGRNNMBOM001");

            migrationBuilder.DropTable(
                name: "BSMGRNNMBOMCONTENT");

            migrationBuilder.DropTable(
                name: "BSMGRNNMCCM001");

            migrationBuilder.DropTable(
                name: "BSMGRNNMCCMTEXT");

            migrationBuilder.DropTable(
                name: "BSMGRNNMGEN005");

            migrationBuilder.DropTable(
                name: "BSMGRNNMMAT001");

            migrationBuilder.DropTable(
                name: "BSMGRNNMMATTEXT");

            migrationBuilder.DropTable(
                name: "BSMGRNNMOPR001");

            migrationBuilder.DropTable(
                name: "BSMGRNNMROT001");

            migrationBuilder.DropTable(
                name: "BSMGRNNMROTBOMCONTENT");

            migrationBuilder.DropTable(
                name: "BSMGRNNMROTHEAD");

            migrationBuilder.DropTable(
                name: "BSMGRNNMROTOPRCONTENT");

            migrationBuilder.DropTable(
                name: "BSMGRNNMWCM001");

            migrationBuilder.DropTable(
                name: "BSMGRNNMWCMOPR");

            migrationBuilder.DropTable(
                name: "BSMGRNNMWCMTEXT");

            migrationBuilder.DropTable(
                name: "BSMGRNNMBOMHEAD");

            migrationBuilder.DropTable(
                name: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropTable(
                name: "BSMGRNNMGEN002");

            migrationBuilder.DropTable(
                name: "BSMGRNNMMATHEAD");

            migrationBuilder.DropTable(
                name: "BSMGRNNMCCMHEAD");

            migrationBuilder.DropTable(
                name: "BSMGRNNMGEN001");

            migrationBuilder.DropTable(
                name: "BSMGRNNMGEN004");

            migrationBuilder.DropTable(
                name: "BSMGRNNMGEN003");
        }
    }
}
