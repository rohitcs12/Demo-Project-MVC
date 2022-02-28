using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class EmployeeServices : IEmpolyeeServices
    {
        private readonly DbConnect _dbConnect;
        public EmployeeServices(DbConnect dbConnect)
        {
            _dbConnect = dbConnect;
        }
        public int InsertNewEmployee(Employee emp)
        {
            bool isExist = _dbConnect.Employee.Any(u => u.Name == emp.Name);
            if (isExist)
            {
                return -1;
            }
            else
            {
                _dbConnect.Employee.Add(emp);
                _dbConnect.SaveChanges();
                return 1;
            }
        }

        public int updateInfoEmployee(Employee employee, int empcode)
        {
            bool isExist = _dbConnect.Employee.Any(x => x.EmpCode == empcode);
            if(isExist)
            {
                var data = _dbConnect.Employee.First(x => x.EmpCode == empcode);
                data.Name = employee.Name;
                data.Salary = employee.Salary;
                data.Designation = employee.Designation;
                // _dbConnect.Employee.Remove(data);
                _dbConnect.SaveChanges();
                return 1;
            }
            else
            {
                return -1;
            }
           
        }
    }
}
