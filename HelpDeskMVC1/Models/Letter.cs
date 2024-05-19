namespace HelpDeskMVC1.Models
{
    public class Letter
    {
        public int Id { get; set; }
        public Enum.Status Status { get; set; } = 0; //None,Done,Running,Canceled,
        public string Title { get; set; }
        public string? Description { get; set; }
        public Enum.Action ActionType { get; set; } = 0;//None,Delete,Update
        public int? FormaId { get; set; }
        public Forma? Forma { get; set; }
        public int? UserId { get; set; }
    }
}
