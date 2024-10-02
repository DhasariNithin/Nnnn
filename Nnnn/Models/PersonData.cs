
using System.ComponentModel.DataAnnotations;

namespace PersonsDetails.Models
{
    public class PersonData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }     
            public int Age { get; set; }



    }
}
