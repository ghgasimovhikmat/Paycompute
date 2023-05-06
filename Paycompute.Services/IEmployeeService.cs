using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services
{
    public interface IEmployeeService
    {
        Task CreateAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task UpdateAsync(int employeeId);
        Task DeleteAsync(int employeeId);
        Employee GetById(int employeeId);
        decimal UnionFees(int Id);
        decimal StudentLoanRepaymentAmount(int Id, decimal totalAmount);
        IEnumerable<Employee> GetALL();
    }
}
