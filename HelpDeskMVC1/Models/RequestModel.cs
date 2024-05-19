namespace HelpDeskMVC1.Models
{
    public class RequestModel<T>
    {
        public User User { get; set; }
        public T obj { get; set; }

    }
}
