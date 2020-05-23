using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace dotNetProjekt.Views
{
    public partial class AddingEmployeeView : UserControl
    {
        public  AddingEmployeeView()
        {
            MainWindow.logger.Info("AddingEmployeeView Initialize");
            InitializeComponent();
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.logger.Info("Save button in AddingEmployeeView clicked");
            try
            {
                using (var db = new EmploeeContext())
                {
                    var actualMaxIdnumber = db.employees.DefaultIfEmpty().Max(x => x.EmployeeId);
                    var emp = new Employee { EmployeeId = actualMaxIdnumber + 1, FirstName = fNameText.Text, LastName = lNameText.Text, Address = addressText.Text, Email = emailText.Text, PhoneNumber = Int32.Parse(phoneText.Text), Position = positionText.Text };
                    await db.employees.AddAsync(emp);

                    await db.SaveChangesAsync();
                }
                MessageBox.Show("New employee added successfully! :)");
            }
            catch(System.FormatException e1)
            {
                MainWindow.logger.Info("Error occured", e1);
                MessageBox.Show("Incorrect data. Try again.");
            }
        }

       
    }
}
