using System.ComponentModel.DataAnnotations;
namespace AVEVA_code_test.Models
{
    public class Employee
    {
        public Employee(int id, string firstName, string lastName, string email, DateTime dateOfBirth, bool currentlyEmployed)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            CurrentlyEmployed = currentlyEmployed;
        }
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(60)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public bool CurrentlyEmployed { get; set; }
    }

   public struct EmployeeDTO
    {
        private bool currentlemployed;

        public EmployeeDTO(string firstname, string lastname, string email, DateTime dateofbirth, bool currentlemployed) : this()
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            DateOfBirth = dateofbirth;
            CurrentlyEmployed = currentlemployed;
        }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(60)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public bool CurrentlyEmployed { get; set; }
    }
}
