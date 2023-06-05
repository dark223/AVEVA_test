using System.ComponentModel.DataAnnotations;
namespace WebAPI.Models

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
