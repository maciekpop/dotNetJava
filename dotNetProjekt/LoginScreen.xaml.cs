using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace dotNetProjekt
{
    /// <summary>
    /// Logika interakcji dla klasy LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public static int acutalEmployeeId { get; set; }
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new EmploeeContext())
            {
                var tempUser = db.employees.FirstOrDefault(x => x.FirstName == textEmpFirstName.Text && x.LastName == textEmpLastName.Text);

                if (tempUser == null)
                {
                    MessageBox.Show("Błąd! Nie ma takiego pracownika.");
                }
                else
                {
                    acutalEmployeeId = tempUser.EmployeeId;
                    MessageBox.Show("Zalogowano pomyślnie");
                    MainWindow window = new MainWindow();
                    window.Show();
                    this.Close();
                }
            }
        }
    }
}
