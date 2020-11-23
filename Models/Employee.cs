using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Models
{
    public class Employee
    {
        //Employee
        [Range(16, 100, ErrorMessage = "Can only be between 16 .. 100")]
        [Required]
        int Age { get; set; }
        public bool Attrition { get; set; }
        [StringRange(AllowableValues = new[] { "Travel_Rarely", "Travel_Frequently", "Non-Travel" }, ErrorMessage = "BusinessTravel must be either 'Travel_Rarely', 'Travel_Frequently' or 'Non-Travel'.")]
        public string BusinessTravel { get; set; }
        public int DailyRate { get; set; }
        [StringRange(AllowableValues = new[] { "Human Resources", "Sales", "Research & Development" }, ErrorMessage = "Department must be either must be either 'Yes or 'No'.")]
        public string Department { get; set; }
        public int DistanceFromeHome { get; set; }
        public string Education { get; set; }
        public string EducationField { get; set; }
        //public int EmployeeCount { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int EmployeeNumber { get; set; }
        public int EnvironmentSatisfaction { get; set; }
        public string Gender { get; set; }
        public int HourlyRate { get; set; }
        public int JobInvolvement { get; set; }
        public int JobLevel { get; set; }
        public string Role { get; set; }
        public int JobSatisfaction { get; set; }
        public string MaritalStatus { get; set; }
        public int MonthlyIncome { get; set; }
        public int MonthlyRate { get; set; }
        public int NumCompaniesWorked { get; set; }
        //public bool Over18 { get; set; }
        public bool OverTime { get; set; }
        public int PercentSalaryHike { get; set; }
        public int PerformanceRating { get; set; }
        public int RelationshipSatisfaction { get; set; }
        public int StandardHours { get; set; }
        public int StockOptionLevel { get; set; }
        public int TotalWorkingYears { get; set; }
        public int TrianingTimesLastYear { get; set; }
        public int WorkLifeBalance { get; set; }
        public int YearsAtCompany { get; set; }
        public int YearsInCurrentRole { get; set; }
        public int YearsSinceLastPromotion { get; set; }
        public int YearsWithCurrManager { get; set; }
        public string Token { get; set; }

        private class StringRangeAttribute : ValidationAttribute
        {
            public string[] AllowableValues { get; set; }

            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (AllowableValues?.Contains(value?.ToString()) == true)
                {
                    return ValidationResult.Success;
                }

                var msg = $"Please enter one of the allowable values: {string.Join(", ", (AllowableValues ?? new string[] { "No allowable values found" }))}.";
                return new ValidationResult(msg);
            }
        }
    }
}
