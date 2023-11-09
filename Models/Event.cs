using System.ComponentModel.DataAnnotations;

namespace ASPNET_Calendar2.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime EndTime { get; set; }

        
        public virtual Location location { get; set; }
    }
}
