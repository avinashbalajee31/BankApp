using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Models
{
    public class CustomerModel
    {
        [Key]
        public int CustomerId { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Please Enter Name.")]
        public string CustomerFirstName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string CustomerLastName { get; set; }


        [Column(TypeName = "varchar(20)")]
        public string AccountType { get; set; }

        [Required(AllowEmptyStrings = true)]
        public int Age { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Location { get; set; }


    }
}
