using MongoDbProject.Models;

namespace MongoDbProject.Services.Abstract
{
    public interface ICommentService
    {
        Task<List<Comment>> GetAllComments();
        Task<Comment> GetCommentById(string id);
        Task CreateComment(Comment comment);
        Task UpdateComment(Comment comment);
        Task DeleteComment(string id);
    }
}
