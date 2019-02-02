using System.ComponentModel.DataAnnotations;

namespace odata.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
    }
}