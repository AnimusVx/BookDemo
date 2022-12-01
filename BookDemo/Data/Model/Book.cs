namespace BookDemo.Data.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public override string ToString()
        {
            return Id + " - " + Title;
        }
    }
}
