using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_Management_system.Models
{
    public class Room : IValidatableObject
    {

        [Key]
        public int Room_Id { get; set; }
        public string? Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Boolean Status { get; set; }
        [ForeignKey("Hotel")]
        public int Hotel_Id { get; set; }
        public virtual Hotel? Hotel { get; set; }
       


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ToDate < FromDate)
            {
                yield return new ValidationResult("EndDate must be greater than StartDate");
            }
        }


    }
}
