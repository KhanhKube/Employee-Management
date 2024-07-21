using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository iDepartmentRepository;
        EmployeeManagementContext context = new EmployeeManagementContext();

        public DepartmentService()
        {
            iDepartmentRepository = new DepartmentRepository();
        }

        public void DeleteDepartment(Department department)
        {
            iDepartmentRepository.DeleteDepartment(department);
        }

        public Department? GetDepartmentById(int id)
        {
            return iDepartmentRepository.GetDepartmentById(id); 
        }

        public List<Department> GetDepartments()
        {
            return iDepartmentRepository.GetDepartments();
        }

        public void InsertDepartment(Department department)
        {
            iDepartmentRepository.InsertDepartment(department);
        }

        public void UpdateDepartment(Department department)
        {
            iDepartmentRepository.UpdateDepartment(department);
        }

        /* New features */
        /*
        public List<Department> GetDepartmentByName(string name)
        {
            var departments = 
                GetDepartments()
                .Where(d => d.DepartmentName.ToLower().Contains(name))
                .ToList();
            return departments;
        }

        public List<Department> GetDepartmentsByManagerId(int managerId)
        {
            var departments =
                GetDepartments()
                .Where(d => d.ManagerId == managerId)
                .ToList();
            return departments;
        }

        public List<Department> GetDepartmentsByLocationId(string locationId)
        {
            var departments =
                GetDepartments()
                .Where(d => d.LocationId == locationId)
                .ToList();
            return departments;
        }
        */

        public List<Department> FilterDepartment(string? searchName, int? searchManager, string? searchLocation)
        {
            try
            {
                var allDepartments = GetDepartments(); 
                
                var filterDepartments = allDepartments
                    .Where(d => (string.IsNullOrEmpty(searchName) || d.DepartmentName.Contains(searchName, StringComparison.OrdinalIgnoreCase)) &&
                                (searchManager == 0 || d.ManagerId == searchManager) &&
                                (string.IsNullOrEmpty(searchLocation) || d.LocationId == searchLocation))
                    .ToList();

                return filterDepartments;
            }
            catch (Exception ex)
            {
                throw new Exception("Error filtering departments", ex);
            }
        }

        public List<Department> GetDepartmentByRegion(int? regionId)
        {
            try
            {
                if (regionId.HasValue)
                {
                    var filteredDepartments =
                        (from d in context.Departments
                         join l in context.Locations on d.LocationId equals l.LocationId
                         join c in context.Countries on l.CountryId equals c.CountryId
                         join re in context.Regions on c.RegionId equals re.RegionId
                         where re.RegionId == regionId
                         select d).ToList();

                    return filteredDepartments;
                }
                else
                {
                    return new List<Department>();
                }
            } catch (Exception ex)
            {
                throw new Exception("Error filtering Department", ex);
            }
            
        }
    }
}
