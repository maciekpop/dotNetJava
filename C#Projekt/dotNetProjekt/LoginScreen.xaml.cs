using System.Linq;
using System.Windows;

namespace dotNetProjekt
{
    public partial class LoginScreen : Window
    {
        public static int acutalEmployeeId { get; set; }
        public LoginScreen()
        {
            MainWindow.logger.Info("Initalize login");
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new EmploeeContext())
            {
                var tempUser = db.employees.FirstOrDefault(x => x.FirstName == textEmpFirstName.Text && x.LastName == textEmpLastName.Text);

                if (tempUser == null)
                {
                    MainWindow.logger.Info("Incorrect login to system");
                    MessageBox.Show("Błąd! Nie ma takiego pracownika.");
                }
                else
                {
                    acutalEmployeeId = tempUser.EmployeeId;
                    MainWindow.logger.Info("Correct login to system");
                    MessageBox.Show("Zalogowano pomyślnie");
                    MainWindow window = new MainWindow();
                    window.Show();
                    this.Close();
                }
            }
        }
    }
}
