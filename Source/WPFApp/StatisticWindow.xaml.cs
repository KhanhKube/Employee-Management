using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for StatisticWindow.xaml
    /// </summary>
    public partial class StatisticWindow : Window
    {
        private readonly IRegionService iRegionService;
        private readonly IEmployeeService iEmployeeService;
        private readonly IDepartmentService iDepartmentService;

        EmployeeManagementContext context = new EmployeeManagementContext();
        public StatisticWindow()
        { 
            InitializeComponent();
            iRegionService = new RegionService();
            iEmployeeService = new EmployeeService();
            iDepartmentService = new DepartmentService();
        }

        private void LoadEmployee()
        {
            try
            {
                var employees = iEmployeeService.GetEmployees();
                cboId.ItemsSource = employees;
                cboId.SelectedValuePath = "EmployeeId";
                cboId.DisplayMemberPath = "EmployeeId";
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error: Can not load employees");
            }
        }

        private void LoadRegion()
        {
            try
            {
                var regions = iRegionService.GetRegions();
                cboRegion.ItemsSource = regions;
                cboRegion.SelectedValuePath = "RegionId";
                cboRegion.DisplayMemberPath = "RegionName";
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error: Can not load regions");
            }
        }

        private void LoadStatistics()
        {
            LoadHeadCount();
            LoadTotalEmployeeByDepartment();
            LoadAvgEmployeeSalaryByJob();
            LoadAvgEmployeeSalaryByDepartment();
        }

        private void LoadHeadCount()
        {
            DateTime? startDate = dpStartDate.SelectedDate;
            DateTime? endDate = dpEndDate.SelectedDate;

            int totalEmployees = iEmployeeService.TotalEmployeeBHireDate(startDate, endDate);

            txtHeadCount.Text = totalEmployees.ToString();
        }

        private void LoadTotalEmployeeByDepartment()
        {
            DateTime? startDate = dpStartDate.SelectedDate;
            DateTime? endDate = dpEndDate.SelectedDate;

            try
            {
                var data = iEmployeeService.TotalEmployeeByDepartment(startDate, endDate);

                // Chuyển dữ liệu sang kiểu danh sách đối tượng để phù hợp với DataGrid
                var displayData = data.Select(d => new
                {
                    DepartmentName = d.Key,
                    TotalEmployees = d.Value
                }).ToList();

                // Gán dữ liệu vào DataGrid
                dgData_1.ItemsSource = displayData;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error: Can not load data.");
            }
        }


        private void LoadAvgEmployeeSalaryByJob()
        {
            DateTime? startDate = dpStartDate.SelectedDate;
            DateTime? endDate = dpEndDate.SelectedDate;

            var data = iEmployeeService.AvgEmployeeSalaryByJob(startDate, endDate);
            dgData_2.ItemsSource = data.Select(d => new { JobTitle = d.Key, AverageSalary = d.Value }).ToList();
        }

        private void LoadAvgEmployeeSalaryByDepartment()
        {
            DateTime? startDate = dpStartDate.SelectedDate;
            DateTime? endDate = dpEndDate.SelectedDate;

            var data = iEmployeeService.AvgEmployeeSalaryByDepartment(startDate, endDate);
            dgData_3.ItemsSource = data.Select(d => new { DepartmentName = d.Key, AverageSalary = d.Value }).ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadRegion();
            LoadEmployee();
            LoadStatistics();
        }

        private void dpDateFilter_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadStatistics();
        }


        private void cboId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboId.SelectedValue != null && int.TryParse(cboId.SelectedValue.ToString(), out int id))
            {
                var employees = iEmployeeService.GetEmployees().AsQueryable();

                var selectedEmployee = (from em in context.Employees
                                       join d in context.Departments on em.DepartmentId equals d.DepartmentId
                                       join j in context.Jobs on em.JobId equals j.JobId
                                       join l in context.Locations on d.LocationId equals l.LocationId
                                       join c in context.Countries on l.CountryId equals c.CountryId
                                       join r in context.Regions on c.RegionId equals r.RegionId
                                       where em.EmployeeId == id
                                       select new
                                       {
                                           Name = em.FirstName + " " + em.LastName,
                                           em.Email,
                                           em.Phone,
                                           em.HireDate,
                                           j.JobTitle,
                                           em.Salary,
                                           em.CommissionPct,
                                           d.DepartmentName,
                                           l.StreetAddress,
                                           l.PostalCode,
                                           l.City,
                                           l.StateProvince,
                                           c.CountryName,
                                           r.RegionName
                                       }).FirstOrDefault();

                if (selectedEmployee != null)
                {
                    txtName.Text = selectedEmployee.Name ?? "";
                    txtEmail.Text = selectedEmployee.Email ?? "";
                    txtPhone.Text = selectedEmployee.Phone ?? "";
                    txtHireDate.Text = selectedEmployee.HireDate?.ToString("dd-MMM-yyyy") ?? "";
                    txtJob.Text = selectedEmployee.JobTitle ?? "";
                    txtSalary.Text = selectedEmployee.Salary?.ToString() ?? "";
                    txtCommission.Text = selectedEmployee.CommissionPct?.ToString() ?? "";
                    txtDepartment.Text = selectedEmployee.DepartmentName ?? "";
                    txtStressAddress.Text = selectedEmployee.StreetAddress ?? "";
                    txtPostalCode.Text = selectedEmployee.PostalCode ?? "";
                    txtCity.Text = selectedEmployee.City ?? "";
                    txtStateProvince.Text = selectedEmployee.StateProvince ?? "";
                    txtCountry.Text = selectedEmployee.CountryName ?? "";
                    txtRegion.Text = selectedEmployee.RegionName ?? "";
                }
                else
                {
                    ClearEmployeeInfo();
                }
            }
            else
            {
                ClearEmployeeInfo();
            }
        }

        private void ClearEmployeeInfo()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtHireDate.Text = "";
            txtJob.Text = "";
            txtSalary.Text = "";
            txtCommission.Text = "";
            txtDepartment.Text = "";
            txtStressAddress.Text = "";
            txtPostalCode.Text = "";
            txtCity.Text = "";
            txtStateProvince.Text = "";
            txtCountry.Text = "";
            txtRegion.Text = "";
        }


        private void cboRegion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboRegion.SelectedValue != null)
            {
                int idRegion = int.Parse(cboRegion.SelectedValue.ToString());
                var filteredDepartments = iDepartmentService.GetDepartmentByRegion(idRegion);
                dgData_4.ItemsSource = filteredDepartments;
                //System.Windows.MessageBox.Show(idRegion.ToString());
                //System.Windows.MessageBox.Show($"{filteredDepartments}");
            }
        }
    }
}
