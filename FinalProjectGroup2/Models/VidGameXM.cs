namespace FinalProjectGroup2.Models
{
    public class VidGameXM //Xander Marsden
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public DateTime InitialDate { get; set; }
        public required string Platform { get; set; }
        public required string GameName { get; set; }
    }
}
