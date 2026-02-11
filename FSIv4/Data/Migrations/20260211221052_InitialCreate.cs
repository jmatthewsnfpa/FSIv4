using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSIv4.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FSI",
                columns: table => new
                {
                    NfpaFdid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NfirsId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountyNo = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    StateGroup = table.Column<int>(type: "int", nullable: false),
                    StateGroupOverride = table.Column<int>(type: "int", nullable: true),
                    Zipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zipcode2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    AddressDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactRank = table.Column<int>(type: "int", nullable: false),
                    ContactRankId = table.Column<int>(type: "int", nullable: true),
                    ContactDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordType = table.Column<int>(type: "int", nullable: false),
                    RecordTypeId = table.Column<int>(type: "int", nullable: true),
                    RecordStatus = table.Column<int>(type: "int", nullable: false),
                    CrossRefId = table.Column<int>(type: "int", nullable: true),
                    SmSa = table.Column<int>(type: "int", nullable: true),
                    DataSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SquareMiles = table.Column<int>(type: "int", nullable: true),
                    Community = table.Column<int>(type: "int", nullable: false),
                    CommunityId = table.Column<int>(type: "int", nullable: true),
                    Population = table.Column<int>(type: "int", nullable: true),
                    PopInterval = table.Column<int>(type: "int", nullable: false),
                    PopIntervalId = table.Column<int>(type: "int", nullable: true),
                    TypeEmps = table.Column<int>(type: "int", nullable: false),
                    TypeEmpsId = table.Column<int>(type: "int", nullable: true),
                    PaidEmps = table.Column<int>(type: "int", nullable: true),
                    PaidEmpsWomen = table.Column<int>(type: "int", nullable: true),
                    WorkWeek = table.Column<int>(type: "int", nullable: true),
                    EmpsPerShift = table.Column<int>(type: "int", nullable: true),
                    VolsComp = table.Column<int>(type: "int", nullable: false),
                    Vols = table.Column<int>(type: "int", nullable: true),
                    VolsWomen = table.Column<int>(type: "int", nullable: true),
                    Pumpers = table.Column<int>(type: "int", nullable: true),
                    Ladders = table.Column<int>(type: "int", nullable: true),
                    Combo = table.Column<int>(type: "int", nullable: true),
                    MarineVessels = table.Column<int>(type: "int", nullable: true),
                    OtherSupport = table.Column<int>(type: "int", nullable: true),
                    OtherVehicles = table.Column<int>(type: "int", nullable: true),
                    ThermalEquipment = table.Column<int>(type: "int", nullable: true),
                    Stations = table.Column<int>(type: "int", nullable: true),
                    Ems = table.Column<int>(type: "int", nullable: false),
                    EmsId = table.Column<int>(type: "int", nullable: true),
                    Ambulance = table.Column<int>(type: "int", nullable: false),
                    Dispatch = table.Column<int>(type: "int", nullable: false),
                    DispatchId = table.Column<int>(type: "int", nullable: true),
                    Training = table.Column<int>(type: "int", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: true),
                    CodeEnforcement = table.Column<int>(type: "int", nullable: false),
                    CodeEnforcementId = table.Column<int>(type: "int", nullable: true),
                    LastReturned = table.Column<int>(type: "int", nullable: true),
                    LastSent = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FdSurveyStatus1 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyStatus2 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyStatus3 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyStatus4 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyStatus5 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyStatus6 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyStatus7 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyYears1 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyYears2 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyYears3 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyYears4 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyYears5 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyYears6 = table.Column<int>(type: "int", nullable: true),
                    FdSurveyYears7 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FSI", x => x.NfpaFdid);
                });

            migrationBuilder.CreateTable(
                name: "ProtectedTowns",
                columns: table => new
                {
                    TownProtectedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TownProtectedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NfpaFdid = table.Column<int>(type: "int", nullable: false),
                    FdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    StateGroup = table.Column<int>(type: "int", nullable: false),
                    StateGroupOverride = table.Column<int>(type: "int", nullable: true),
                    CreatedDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectedTowns", x => x.TownProtectedId);
                    table.ForeignKey(
                        name: "FK_ProtectedTowns_FSI_NfpaFdid",
                        column: x => x.NfpaFdid,
                        principalTable: "FSI",
                        principalColumn: "NfpaFdid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProtectedTowns_NfpaFdid",
                table: "ProtectedTowns",
                column: "NfpaFdid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProtectedTowns");

            migrationBuilder.DropTable(
                name: "FSI");
        }
    }
}
