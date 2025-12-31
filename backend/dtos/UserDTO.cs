using Models;

namespace DTOs
{
    public class UserDTO
    {
        // should I be sending Ids?
        // over-posting security risk for user setting id over
        // other db entry?
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Email { get; set; }

        public DateTime? CreationDate { get; set; }

        public UserDTO() { }
        public UserDTO(User user) => 
            (Id, Name, Email, CreationDate) = (user.Id, user.Name, user.Email, user.CreationDate);
    }   
}