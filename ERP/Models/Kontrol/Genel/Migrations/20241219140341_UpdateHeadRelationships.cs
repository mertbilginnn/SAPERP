using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Migrations
{
    /// <inheritdoc />
    public partial class UpdateHeadRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMCCMHEAD_BSMGRNNMGEN001_COMCODE",
                table: "BSMGRNNMCCMHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN001_COMCODE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropTable(
                name: "BSMGRNNMBOMCONTENT");

            migrationBuilder.DropTable(
                name: "BSMGRNNMCCMTEXT");

            migrationBuilder.DropTable(
                name: "BSMGRNNMMATTEXT");

            migrationBuilder.DropTable(
                name: "BSMGRNNMROTBOMCONTENT");

            migrationBuilder.DropTable(
                name: "BSMGRNNMROTOPRCONTENT");

            migrationBuilder.DropTable(
                name: "BSMGRNNMWCMOPR");

            migrationBuilder.DropTable(
                name: "BSMGRNNMWCMTEXT");

            migrationBuilder.AlterColumn<string>(
                name: "WCMDOCTYPE",
                table: "BSMGRNNMWCMHEAD",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<string>(
                name: "LANCODE",
                table: "BSMGRNNMWCMHEAD",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OPRDOCTYPE",
                table: "BSMGRNNMWCMHEAD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WCMLTWXT",
                table: "BSMGRNNMWCMHEAD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WCMSTEXT",
                table: "BSMGRNNMWCMHEAD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ROTDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<string>(
                name: "BOMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(25)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(25)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "COMPONENT",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CONTENTNUM",
                table: "BSMGRNNMROTHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "LABOURTIME",
                table: "BSMGRNNMROTHEAD",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MACHINETIME",
                table: "BSMGRNNMROTHEAD",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "OPRNUM",
                table: "BSMGRNNMROTHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SETUPTIME",
                table: "BSMGRNNMROTHEAD",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "WCMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(4)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WCMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(4)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "STUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NWUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MATDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "BWUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCNUM",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "LANCODE",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MATLTEXT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MATSTEXT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "MAINUNITCODE",
                table: "BSMGRNNMGEN005",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CCMDOCTYPE",
                table: "BSMGRNNMCCMHEAD",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<string>(
                name: "CCMLTEXT",
                table: "BSMGRNNMCCMHEAD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CCMSTEXT",
                table: "BSMGRNNMCCMHEAD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LANCODE",
                table: "BSMGRNNMCCMHEAD",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCTYPE",
                table: "BSMGRNNMBOMHEAD",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCNUM",
                table: "BSMGRNNMBOMHEAD",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AddColumn<string>(
                name: "COMPONENT",
                table: "BSMGRNNMBOMHEAD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CONTENTNUM",
                table: "BSMGRNNMBOMHEAD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMWCMHEAD_LANCODE",
                table: "BSMGRNNMWCMHEAD",
                column: "LANCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMWCMHEAD_WCMDOCTYPE",
                table: "BSMGRNNMWCMHEAD",
                column: "WCMDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTHEAD_BOMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                column: "BOMDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTHEAD_BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "BOMDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTHEAD_ROTDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "ROTDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTHEAD_WCMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                column: "WCMDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMROTHEAD_WCMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "WCMDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATHEAD_BOMDOCNUM",
                table: "BSMGRNNMMATHEAD",
                column: "BOMDOCNUM");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATHEAD_BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                column: "BOMDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATHEAD_BWUNIT",
                table: "BSMGRNNMMATHEAD",
                column: "BWUNIT");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATHEAD_LANCODE",
                table: "BSMGRNNMMATHEAD",
                column: "LANCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATHEAD_MATDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                column: "MATDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATHEAD_NWUNIT",
                table: "BSMGRNNMMATHEAD",
                column: "NWUNIT");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATHEAD_STUNIT",
                table: "BSMGRNNMMATHEAD",
                column: "STUNIT");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMCCMHEAD_CCMDOCTYPE",
                table: "BSMGRNNMCCMHEAD",
                column: "CCMDOCTYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMCCMHEAD_LANCODE",
                table: "BSMGRNNMCCMHEAD",
                column: "LANCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMBOMHEAD_BOMDOCTYPE",
                table: "BSMGRNNMBOMHEAD",
                column: "BOMDOCTYPE");

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMBOMHEAD_BSMGRNNMBOM001_BOMDOCTYPE",
                table: "BSMGRNNMBOMHEAD",
                column: "BOMDOCTYPE",
                principalTable: "BSMGRNNMBOM001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMCCMHEAD_BSMGRNNMCCM001_CCMDOCTYPE",
                table: "BSMGRNNMCCMHEAD",
                column: "CCMDOCTYPE",
                principalTable: "BSMGRNNMCCM001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMCCMHEAD_BSMGRNNMGEN001_COMCODE",
                table: "BSMGRNNMCCMHEAD",
                column: "COMCODE",
                principalTable: "BSMGRNNMGEN001",
                principalColumn: "COMCODE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMCCMHEAD_BSMGRNNMGEN002_LANCODE",
                table: "BSMGRNNMCCMHEAD",
                column: "LANCODE",
                principalTable: "BSMGRNNMGEN002",
                principalColumn: "LANCODE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMBOMHEAD_BOMDOCNUM",
                table: "BSMGRNNMMATHEAD",
                column: "BOMDOCNUM",
                principalTable: "BSMGRNNMBOMHEAD",
                principalColumn: "BOMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMBOMHEAD_BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                column: "BOMDOCTYPE",
                principalTable: "BSMGRNNMBOMHEAD",
                principalColumn: "BOMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN001_COMCODE",
                table: "BSMGRNNMMATHEAD",
                column: "COMCODE",
                principalTable: "BSMGRNNMGEN001",
                principalColumn: "COMCODE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN002_LANCODE",
                table: "BSMGRNNMMATHEAD",
                column: "LANCODE",
                principalTable: "BSMGRNNMGEN002",
                principalColumn: "LANCODE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN005_BWUNIT",
                table: "BSMGRNNMMATHEAD",
                column: "BWUNIT",
                principalTable: "BSMGRNNMGEN005",
                principalColumn: "UNITCODE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN005_NWUNIT",
                table: "BSMGRNNMMATHEAD",
                column: "NWUNIT",
                principalTable: "BSMGRNNMGEN005",
                principalColumn: "UNITCODE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN005_STUNIT",
                table: "BSMGRNNMMATHEAD",
                column: "STUNIT",
                principalTable: "BSMGRNNMGEN005",
                principalColumn: "UNITCODE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMMAT001_MATDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                column: "MATDOCTYPE",
                principalTable: "BSMGRNNMMAT001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMBOMHEAD_BOMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                column: "BOMDOCNUM",
                principalTable: "BSMGRNNMBOMHEAD",
                principalColumn: "BOMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMBOMHEAD_BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "BOMDOCTYPE",
                principalTable: "BSMGRNNMBOMHEAD",
                principalColumn: "BOMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMAT001_ROTDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "ROTDOCTYPE",
                principalTable: "BSMGRNNMMAT001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMWCMHEAD_WCMDOCNUM",
                table: "BSMGRNNMROTHEAD",
                column: "WCMDOCNUM",
                principalTable: "BSMGRNNMWCMHEAD",
                principalColumn: "WCMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMWCMHEAD_WCMDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "WCMDOCTYPE",
                principalTable: "BSMGRNNMWCMHEAD",
                principalColumn: "WCMDOCNUM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMGEN002_LANCODE",
                table: "BSMGRNNMWCMHEAD",
                column: "LANCODE",
                principalTable: "BSMGRNNMGEN002",
                principalColumn: "LANCODE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMWCM001_WCMDOCTYPE",
                table: "BSMGRNNMWCMHEAD",
                column: "WCMDOCTYPE",
                principalTable: "BSMGRNNMWCM001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMBOMHEAD_BSMGRNNMBOM001_BOMDOCTYPE",
                table: "BSMGRNNMBOMHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMCCMHEAD_BSMGRNNMCCM001_CCMDOCTYPE",
                table: "BSMGRNNMCCMHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMCCMHEAD_BSMGRNNMGEN001_COMCODE",
                table: "BSMGRNNMCCMHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMCCMHEAD_BSMGRNNMGEN002_LANCODE",
                table: "BSMGRNNMCCMHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMBOMHEAD_BOMDOCNUM",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMBOMHEAD_BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN001_COMCODE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN002_LANCODE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN005_BWUNIT",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN005_NWUNIT",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN005_STUNIT",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMMAT001_MATDOCTYPE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMBOMHEAD_BOMDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMBOMHEAD_BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMAT001_ROTDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMWCMHEAD_WCMDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMWCMHEAD_WCMDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMGEN002_LANCODE",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMWCMHEAD_BSMGRNNMWCM001_WCMDOCTYPE",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMWCMHEAD_LANCODE",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMWCMHEAD_WCMDOCTYPE",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMROTHEAD_BOMDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMROTHEAD_BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMROTHEAD_ROTDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMROTHEAD_WCMDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMROTHEAD_WCMDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMMATHEAD_BOMDOCNUM",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMMATHEAD_BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMMATHEAD_BWUNIT",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMMATHEAD_LANCODE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMMATHEAD_MATDOCTYPE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMMATHEAD_NWUNIT",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMMATHEAD_STUNIT",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMCCMHEAD_CCMDOCTYPE",
                table: "BSMGRNNMCCMHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMCCMHEAD_LANCODE",
                table: "BSMGRNNMCCMHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMBOMHEAD_BOMDOCTYPE",
                table: "BSMGRNNMBOMHEAD");

            migrationBuilder.DropColumn(
                name: "LANCODE",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropColumn(
                name: "OPRDOCTYPE",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropColumn(
                name: "WCMLTWXT",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropColumn(
                name: "WCMSTEXT",
                table: "BSMGRNNMWCMHEAD");

            migrationBuilder.DropColumn(
                name: "BOMDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropColumn(
                name: "BOMDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropColumn(
                name: "COMPONENT",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropColumn(
                name: "CONTENTNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropColumn(
                name: "LABOURTIME",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropColumn(
                name: "MACHINETIME",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropColumn(
                name: "OPRNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropColumn(
                name: "SETUPTIME",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropColumn(
                name: "WCMDOCNUM",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropColumn(
                name: "WCMDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropColumn(
                name: "LANCODE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropColumn(
                name: "MATLTEXT",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropColumn(
                name: "MATSTEXT",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropColumn(
                name: "CCMLTEXT",
                table: "BSMGRNNMCCMHEAD");

            migrationBuilder.DropColumn(
                name: "CCMSTEXT",
                table: "BSMGRNNMCCMHEAD");

            migrationBuilder.DropColumn(
                name: "LANCODE",
                table: "BSMGRNNMCCMHEAD");

            migrationBuilder.DropColumn(
                name: "COMPONENT",
                table: "BSMGRNNMBOMHEAD");

            migrationBuilder.DropColumn(
                name: "CONTENTNUM",
                table: "BSMGRNNMBOMHEAD");

            migrationBuilder.AlterColumn<string>(
                name: "WCMDOCTYPE",
                table: "BSMGRNNMWCMHEAD",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "ROTDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "STUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NWUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)");

            migrationBuilder.AlterColumn<string>(
                name: "MATDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "BWUNIT",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)");

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCNUM",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "MAINUNITCODE",
                table: "BSMGRNNMGEN005",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "CCMDOCTYPE",
                table: "BSMGRNNMCCMHEAD",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCTYPE",
                table: "BSMGRNNMBOMHEAD",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "BOMDOCNUM",
                table: "BSMGRNNMBOMHEAD",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.CreateTable(
                name: "BSMGRNNMBOMCONTENT",
                columns: table => new
                {
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    BOMDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    BOMDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    COMPBOMDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COMPBOMDOCTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COMPONENT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONTENTNUM = table.Column<int>(type: "int", nullable: false),
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
                name: "BSMGRNNMCCMTEXT",
                columns: table => new
                {
                    CCMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CCMDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CCMDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CCMLTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCMSTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    LANCODE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MATDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MATDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MATLTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MATSTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "BSMGRNNMROTBOMCONTENT",
                columns: table => new
                {
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BOMDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    BOMDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    COMPONENT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONTENTNUM = table.Column<int>(type: "int", nullable: false),
                    OPRNUM = table.Column<int>(type: "int", nullable: false),
                    QUANTITY = table.Column<double>(type: "float", nullable: false),
                    ROTDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ROTDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "BSMGRNNMROTOPRCONTENT",
                columns: table => new
                {
                    ROTDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    MATDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    MATDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    OPRDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    LABOURTIME = table.Column<double>(type: "float", nullable: false),
                    MACHINETIME = table.Column<double>(type: "float", nullable: false),
                    OPRNUM = table.Column<int>(type: "int", nullable: false),
                    ROTDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ROTDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ROTDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SETUPTIME = table.Column<double>(type: "float", nullable: false)
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
                name: "BSMGRNNMWCMOPR",
                columns: table => new
                {
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    OPRDOCTYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WCMDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    WCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "BSMGRNNMWCMTEXT",
                columns: table => new
                {
                    WCMDOCNUM = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    COMCODE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    LANCODE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WCMDOCFROM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WCMDOCTYPE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    WCMDOCUNTIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WCMLTWXT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WCMSTEXT = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "IX_BSMGRNNMCCMTEXT_COMCODE",
                table: "BSMGRNNMCCMTEXT",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMCCMTEXT_LANCODE",
                table: "BSMGRNNMCCMTEXT",
                column: "LANCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATTEXT_COMCODE",
                table: "BSMGRNNMMATTEXT",
                column: "COMCODE");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATTEXT_LANCODE",
                table: "BSMGRNNMMATTEXT",
                column: "LANCODE");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMCCMHEAD_BSMGRNNMGEN001_COMCODE",
                table: "BSMGRNNMCCMHEAD",
                column: "COMCODE",
                principalTable: "BSMGRNNMGEN001",
                principalColumn: "COMCODE",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMGEN001_COMCODE",
                table: "BSMGRNNMMATHEAD",
                column: "COMCODE",
                principalTable: "BSMGRNNMGEN001",
                principalColumn: "COMCODE",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
