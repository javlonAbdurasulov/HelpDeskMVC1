using HelpDeskMVC1.Models.Enum;

namespace HelpDeskMVC1.Models
{
    public class LetterCreateDTO
    {
        public string Title { get; set; }
        public int UserId { get; set; }

        //Forma
        public string? DescriptionForm { get; set; }
        public Texnika TexnikaForm { get; set; }
        public Korpus KorpusForm { get; set; }
        public string KabinetForm { get; set; }
    }
}
