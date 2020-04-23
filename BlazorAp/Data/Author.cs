using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAp.Data
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        public  string Phonenumber { get; set; }
        
        [StringLength(20, ErrorMessage = "City name can not be longer than 20 chars")]
        public string City{ get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter valid email address")]
        public  string EmailAddress{ get; set; }

        [Range(500, 999999999, ErrorMessage = "Salary should be great than €500")]
        public  int Salary { get; set; }

        public Author()
        {

        }

        public Author(int authorId, string firstName, string lastName, string phonenumber, string city, string emailAddress, int salary)
        {
            AuthorId = authorId;
            FirstName  = firstName;
            LastName  = lastName;
            Phonenumber = phonenumber;
            City = city;
            EmailAddress  = emailAddress;
            Salary  = salary;
        }
    }
}
