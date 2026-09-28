using ComponentModel.Annotations;

namespace MyApp.Core.Entity
{
    public class EmployeeModel
    {
        [Key]
        [Required]
        public int EmployeeId{get;set;}

        [Required]
        public string FirstName{get;set;}

        public string? LastName{get;set;}
    }
}