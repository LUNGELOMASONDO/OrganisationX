using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganisationX.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeNumber = table.Column<int>(type: "int", nullable: false),
                    Attrition = table.Column<bool>(type: "bit", nullable: true),
                    BusinessTravel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DailyRate = table.Column<int>(type: "int", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanceFromeHome = table.Column<int>(type: "int", nullable: true),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationField = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnvironmentSatisfaction = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourlyRate = table.Column<int>(type: "int", nullable: true),
                    JobInvolvement = table.Column<int>(type: "int", nullable: true),
                    JobLevel = table.Column<int>(type: "int", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobSatisfaction = table.Column<int>(type: "int", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlyIncome = table.Column<int>(type: "int", nullable: true),
                    MonthlyRate = table.Column<int>(type: "int", nullable: true),
                    NumCompaniesWorked = table.Column<int>(type: "int", nullable: true),
                    OverTime = table.Column<bool>(type: "bit", nullable: true),
                    PercentSalaryHike = table.Column<int>(type: "int", nullable: true),
                    PerformanceRating = table.Column<int>(type: "int", nullable: true),
                    RelationshipSatisfaction = table.Column<int>(type: "int", nullable: true),
                    StandardHours = table.Column<int>(type: "int", nullable: true),
                    StockOptionLevel = table.Column<int>(type: "int", nullable: true),
                    TotalWorkingYears = table.Column<int>(type: "int", nullable: true),
                    TrianingTimesLastYear = table.Column<int>(type: "int", nullable: true),
                    WorkLifeBalance = table.Column<int>(type: "int", nullable: true),
                    YearsAtCompany = table.Column<int>(type: "int", nullable: true),
                    YearsInCurrentRole = table.Column<int>(type: "int", nullable: true),
                    YearsSinceLastPromotion = table.Column<int>(type: "int", nullable: true),
                    YearsWithCurrManager = table.Column<int>(type: "int", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
