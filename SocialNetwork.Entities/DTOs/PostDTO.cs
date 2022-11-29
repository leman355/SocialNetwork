namespace SocialNetwork.Entities.DTOs
{
    public class PostDTO
    {
        public record PostCreateDTO(Guid userId, string Content);
        public record PostDeleteDTO(int Id);
    }
}