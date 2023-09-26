using MongoDbProject.Models;

namespace MongoDbProject.Services.Abstract
{
    public interface IServiceService
    {
        Task<List<Service>> GetAllServices();
        Task<Service> GetServiceById(string id);
        Task CreateService(Service service);
        Task UpdateService(Service service);
        Task DeleteService(string id);
    }
}
