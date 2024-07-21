using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository iEmployeeRepository;
        EmployeeManagementContext context = new EmployeeManagementContext();

        public EmployeeService()
        {
            iEmployeeRepository = new EmployeeRepository();
        }

        public void DeleteEmployee(Employee employee)
        {
            iEmployeeRepository.DeleteEmployee(employee);
        }

        public Employee? GetEmployeeById(int id)
        {
            return iEmployeeRepository.GetEmployeeById(id);
        }

        public List<Employee> GetEmployees()
        {
            //return iEmployeeRepository.GetEmployees();
            var employees = iEmployeeRepository.GetEmployees();
            return employees ?? new List<Employee>(); // Trả về danh sách trống nếu employees là null
        }

        public void InsertEmployee(Employee employee)
        {
            iEmployeeRepository.InsertEmployee(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            iEmployeeRepository.UpdateEmployee(employee);
        }

        /* New features */

        
        public List<Employee> GetManagers()
        {
            var employees = GetEmployees();
            var managers =
                employees
                .Where(e => e.ManagerId.HasValue)
                .Join(
                    employees,
                    e => e.ManagerId,
                    m => m.EmployeeId,
                    (e, m) => m)
                .Distinct()
                .GroupBy(m => m.EmployeeId)
                .Select(g => g.First())
                .ToList();

            return managers;
        }

        /*
        public List<Employee> GetEmployeesByName(string name)
        {
            var employees = GetEmployees();
            var employeeFilter =
                employees
                .Where( e => e.FirstName.Contains(name) || e.LastName.Contains(name))
                .ToList();
            return employeeFilter;
        }

        public List<Employee> GetEmployeesBySalary(double minSalary, double maxSalary)
        {
            var employees = GetEmployees();
            var employeeFilter =
                employees
                .Where(e => e.Salary >= minSalary && e.Salary <= maxSalary)
                .OrderBy(e => e.Salary) 
                .ToList();
            return employeeFilter;
        }

        public List<Employee> GetEmployeesByJobId(string jobId)
        {
            var employees = GetEmployees();
            var employeeFilter =
                employees
                .Where (e => e.JobId == jobId)
                .ToList();
            return employeeFilter;
        }

        public List<Employee> GetEmployeesByManagerId(int managerId)
        {
            var employees = GetEmployees();
            var employeeFilter =
                employees
                .Where(e => e.ManagerId == managerId)
                .ToList();
            return employeeFilter;
        }

        public List<Employee> GetEmployeesByDepartmentId(int departmentId)
        {
            var employees = GetEmployees();
            var employeeFilter =
                employees
                .Where(e => e.DepartmentId == departmentId)
                .ToList();
            return employeeFilter;
        }

        public List<Employee> GetEmployeesByYearOfHireDate(int yearOfHireDate)
        {
            var employees = GetEmployees();
            var employeeFilter =
                employees
                .Where(e => e.HireDate.Value.Year == yearOfHireDate)
                .ToList();
            return employeeFilter;
        }

        public List<Employee> GetEmployeesByCommission(double minCommission, double maxCommission)
        {
            var employees = GetEmployees();
            var employeeFilter =
                employees
                .Where(e => e.CommissionPct >= minCommission && e.CommissionPct <= maxCommission)
                .OrderBy(e => e.CommissionPct)
                .ToList();
            return employeeFilter;
        }
        */

        public bool checkIdExist(int id)
        {
            var employeeFilter =
                GetEmployees()
                .Any(e => e.EmployeeId == id); //Any(): được sử dụng để kiểm tra xem có bất kỳ phần tử nào trong một tập hợp thỏa mãn một điều kiện cụ thể hay không
            return employeeFilter;
        }

        public bool checkPhoneExist(string phone)
        {
            var employeeFilter = 
                GetEmployees()
                .Any (e => e.Phone == phone);   
            return employeeFilter;
        }

        public bool checkEmailExist(string email)
        {
            var employeeFilter =
                GetEmployees()
                .Any(e => e.Email == email);
            return employeeFilter;
        }

        public List<Employee> FilterEmployees(
            string? name, 
            double? minSalary, 
            double? maxSalary, 
            double? minCommission, 
            double? maxCommission, 
            string? jobId, 
            int? managerId, 
            int? departmentId, 
            int? yearOfHireDate)
        {
            try
            {
                var employeeFilter = GetEmployees().AsQueryable();

                if (!string.IsNullOrEmpty(name))
                {
                    employeeFilter = employeeFilter
                        .Where(e => e.FirstName.Contains(name, StringComparison.OrdinalIgnoreCase) 
                        || e.LastName.Contains(name, StringComparison.OrdinalIgnoreCase));
                }
                if (minSalary.HasValue && maxSalary.HasValue)
                {
                    employeeFilter = employeeFilter.Where(e => e.Salary >= minSalary && e.Salary <= maxSalary);
                }

                if (!string.IsNullOrEmpty(jobId) && jobId != "ALL")
                {
                    employeeFilter = employeeFilter.Where(e => e.JobId == jobId);
                }

                if (managerId.HasValue && managerId.Value != 0)
                {
                    employeeFilter = employeeFilter.Where(e => e.ManagerId == managerId);
                }

                if (departmentId.HasValue && departmentId != 0)
                {
                    employeeFilter = employeeFilter.Where(e => e.DepartmentId == departmentId);
                }

                if (yearOfHireDate.HasValue)
                {
                    employeeFilter = employeeFilter.Where(e => e.HireDate.HasValue && e.HireDate.Value.Year == yearOfHireDate);
                }

                if (minCommission.HasValue && maxCommission.HasValue)
                {
                    employeeFilter = employeeFilter.Where(e => e.CommissionPct >= minCommission && e.CommissionPct <= maxCommission);
                }

                return employeeFilter.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error filtering employees", ex);
            }
        }

        public int TotalEmployeeBHireDate(DateTime? startDate, DateTime? endDate)
        {
            DateOnly? startHireDate = startDate.HasValue ? DateOnly.FromDateTime(startDate.Value) : (DateOnly?)null;
            DateOnly? endHireDate = endDate.HasValue ? DateOnly.FromDateTime(endDate.Value) : (DateOnly?)null;

            var employees = GetEmployees().AsQueryable();

            if (startHireDate.HasValue)
            {
                employees = employees.Where(e => e.HireDate >= startHireDate);
            }
            if (endHireDate.HasValue)
            {
                employees = employees.Where(e => e.HireDate <= endHireDate.Value);
            }

            return employees.Count();
        }

        public Dictionary<string, int> TotalEmployeeByDepartment(DateTime? startDate, DateTime? endDate)
        {
            DateOnly? startHireDate = startDate.HasValue ? DateOnly.FromDateTime(startDate.Value) : (DateOnly?)null;
            DateOnly? endHireDate = endDate.HasValue ? DateOnly.FromDateTime(endDate.Value) : (DateOnly?)null;

            var departmentEmployeeCounts = from e in context.Employees
                                           join d in context.Departments on e.DepartmentId equals d.DepartmentId
                                           where (!startHireDate.HasValue || e.HireDate >= startHireDate.Value) &&
                                                 (!endHireDate.HasValue || e.HireDate <= endHireDate.Value)
                                           group e by d.DepartmentName into departmentGroup
                                           select new
                                           {
                                               DepartmentName = departmentGroup.Key,
                                               TotalEmployee = departmentGroup.Count()
                                           };



            return departmentEmployeeCounts.ToDictionary(g => g.DepartmentName, g => g.TotalEmployee);
        }

        public Dictionary<string, double?> AvgEmployeeSalaryByJob(DateTime? startDate, DateTime? endDate)
        {
            DateOnly? startHireDate = startDate.HasValue ? DateOnly.FromDateTime(startDate.Value) : (DateOnly?)null;
            DateOnly? endHireDate = endDate.HasValue ? DateOnly.FromDateTime(endDate.Value) : (DateOnly?)null;

            // Lấy dữ liệu từ Employees với điều kiện lọc ngày nếu có
            var employeeGroups = (from e in context.Employees
                                  join j in context.Jobs on e.JobId equals j.JobId
                                  where (!startHireDate.HasValue || e.HireDate >= startHireDate.Value) &&
                                        (!endHireDate.HasValue || e.HireDate <= endHireDate.Value)
                                  group e by j.JobTitle into jobGroup
                                  select new
                                  {
                                      JobTitle = jobGroup.Key,
                                      AvgSalary = jobGroup.Any(e => e.Salary.HasValue) ? jobGroup.Average(e => e.Salary) : (double?)null
                                  }).ToList();

            // Chuyển đổi kết quả thành Dictionary
            return employeeGroups.ToDictionary(g => g.JobTitle, g => g.AvgSalary);
        }


        public Dictionary<string, double?> AvgEmployeeSalaryByDepartment(DateTime? startDate, DateTime? endDate)
        {
            DateOnly? startHireDate = startDate.HasValue ? DateOnly.FromDateTime(startDate.Value) : (DateOnly?)null;
            DateOnly? endHireDate = endDate.HasValue ? DateOnly.FromDateTime(endDate.Value) : (DateOnly?)null;

            var departmentGroups = from e in context.Employees
                                   join d in context.Departments on e.DepartmentId equals d.DepartmentId
                                   where (!startHireDate.HasValue || e.HireDate >= startHireDate.Value) &&
                                         (!endHireDate.HasValue || e.HireDate <= endHireDate.Value)
                                   group e by d.DepartmentName into departmentGroup
                                   select new
                                   {
                                       DepartmentName = departmentGroup.Key,
                                       AvgSalary = departmentGroup.Any(e => e.Salary.HasValue) ? departmentGroup.Average(e => e.Salary) : (double?)null
                                   };

            return departmentGroups.ToDictionary(g => g.DepartmentName, g => g.AvgSalary);
        }

    }
}
