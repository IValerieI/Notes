namespace Notes.Domain
{

    public class Note
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }

        //public string Image { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
    }



}
