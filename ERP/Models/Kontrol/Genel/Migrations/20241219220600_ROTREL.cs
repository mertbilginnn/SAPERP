using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP.Migrations
{
    /// <inheritdoc />
    public partial class ROTREL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMAT001_ROTDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.AlterColumn<string>(
                name: "ROTDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_BSMGRNNMMATHEAD_ROTDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                column: "ROTDOCTYPE");

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMROT001_ROTDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                column: "ROTDOCTYPE",
                principalTable: "BSMGRNNMROT001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMROT001_ROTDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "ROTDOCTYPE",
                principalTable: "BSMGRNNMROT001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMMATHEAD_BSMGRNNMROT001_ROTDOCTYPE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.DropForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMROT001_ROTDOCTYPE",
                table: "BSMGRNNMROTHEAD");

            migrationBuilder.DropIndex(
                name: "IX_BSMGRNNMMATHEAD_ROTDOCTYPE",
                table: "BSMGRNNMMATHEAD");

            migrationBuilder.AlterColumn<string>(
                name: "ROTDOCTYPE",
                table: "BSMGRNNMMATHEAD",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AddForeignKey(
                name: "FK_BSMGRNNMROTHEAD_BSMGRNNMMAT001_ROTDOCTYPE",
                table: "BSMGRNNMROTHEAD",
                column: "ROTDOCTYPE",
                principalTable: "BSMGRNNMMAT001",
                principalColumn: "DOCTYPE",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
