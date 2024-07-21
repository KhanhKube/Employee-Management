using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int? CurrentUserRole { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDepartment_Click(object sender, RoutedEventArgs e)
        {
            DepartmentWindow departmentWindow = new DepartmentWindow();
            departmentWindow.Owner = this; // Set the owner of the DepartmentWindow
            departmentWindow.CurrentUserRole = CurrentUserRole; // Pass role to DepartmentWindow
            //MessageBox.Show("Current role: "+  CurrentUserRole);
            //this.Hide();
            departmentWindow.ShowDialog();

        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeeWindow = new EmployeeWindow();
            employeeWindow.Owner = this; // Set the owner of the EmployeeWindow
            employeeWindow.CurrentUserRole = CurrentUserRole; // Pass role to EmployeeWindow
            employeeWindow.ShowDialog();
        }

        private void btnJob_Click(object sender, RoutedEventArgs e)
        {
            JobWindow jobWindow = new JobWindow();
            jobWindow.Owner = this; // Set the owner of the JobWindow
            jobWindow.CurrentUserRole = CurrentUserRole; // Pass role to JobWindow
            jobWindow.ShowDialog();
        }

        private void btnRegion_Click(object sender, RoutedEventArgs e)
        {
            RegionWindow regionWindow = new RegionWindow();
            regionWindow.Owner = this; // Set the owner of the RegionWindow
            regionWindow.CurrentUserRole = CurrentUserRole; // Pass role to RegionWindow
            regionWindow.ShowDialog();
        }

        private void btnCountry_Click(object sender, RoutedEventArgs e)
        {
            CountryWindow countryWindow = new CountryWindow();
            countryWindow.Owner = this; // Set the owner of the CountryWindow
            countryWindow.CurrentUserRole = CurrentUserRole; // Pass role to CountryWindow
            countryWindow.ShowDialog();
        }

        private void btnLocation_Click(object sender, RoutedEventArgs e)
        {
            LocationWindow locationWindow = new LocationWindow();
            locationWindow.Owner = this; // Set the owner of the LocationWindow
            locationWindow.CurrentUserRole = CurrentUserRole; // Pass role to LocationWindow
            locationWindow.ShowDialog();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnStatistic_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentUserRole == 1 || CurrentUserRole == 2)
            {
                StatisticWindow statisticWindow = new StatisticWindow();
                statisticWindow.Owner = this; // Set the owner of the LocationWindow
                statisticWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have permission to access the statistics.", "Access Denied", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}