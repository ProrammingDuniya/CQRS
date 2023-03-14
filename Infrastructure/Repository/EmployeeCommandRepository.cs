using Core;

namespace Infrastructure.Repository
{
    /// <summary>
    /// EmployeeCommandRepository
    /// </summary>
    public class EmployeeCommandRepository : IEmployeeCommandRepository
    {
        /// <summary>
        /// Creates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public async Task CreateEmployee(Employee employee)
        {
            var emp= Employee.Create(employee.FirstName, employee.LastName, employee.DateOfBirth, employee.City, employee.PostalCode, employee.Street);
            // Create the employee record in a DB
        }
    }
}
