using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IEmpolyeeServices
    {

        int InsertNewEmployee(Employee emp);
        int updateInfoEmployee(Employee employee, int empcode);
    }
}
