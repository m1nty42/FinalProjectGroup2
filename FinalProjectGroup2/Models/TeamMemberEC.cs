namespace FinalProjectGroup2.Models
{
    public class TeamMemberEC
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string CollegeProgram { get; set; }
        public string YearInProgram { get; set; }
        public int Id { get; internal set; }
    }
}
