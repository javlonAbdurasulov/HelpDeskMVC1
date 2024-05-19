using HelpDeskMVC1.Models.Enum;

namespace HelpDeskMVC1.Models
{
    public class Forma
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public string? Description { get; set; }
        public Texnika Texnika { get; set; }
        public Korpus Korpus { get; set; }
        public string Kabinet { get; set; }
    }
}
