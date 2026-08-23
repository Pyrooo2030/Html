namespace BackEnd.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}