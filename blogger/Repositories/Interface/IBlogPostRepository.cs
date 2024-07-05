using blogger.Models.Domain;

namespace blogger.Repositories.Interface
{
    
    
        public interface IBlogPostRepository
        {
            Task<BlogPost> CreateAsync(BlogPost blogPost);
            Task<IEnumerable<BlogPost>> GetAllAsync();
        }
    
}
