using JoinAndNavigationProperty.Models;

namespace JoinAndNavigationProperty.Repositories
{
    public interface IManagerRepository
    {
        void AddManager(Manager manager);
        void DeleteManager(int id);
        List<Manager> GetAllManagers();
        Manager GetManagerById(int id);
        void Updater(Manager manager);
    }
}