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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dotNetProjekt.Views
{
    /// <summary>
    /// Logika interakcji dla klasy InfoView.xaml
    /// </summary>
    public partial class InfoView : UserControl
    {
        public InfoView()
        {
            InitializeComponent();
            MainWindow.logger.Info("Info view initialize");
        }


        List<Employee> emps = new List<Employee>();
        List<WorkTime> times = new List<WorkTime>();


        private void dataListBoxChanged(object sender, SelectionChangedEventArgs e)
        {
            // MessageBox.Show(dataListBox.SelectedItem.ToString());
        }

        private void showAllDataButton_Click(object sender, RoutedEventArgs e)
        {
            emps.Clear();
            // dataLabel.Content = "Id FirstName SecondName Address PhoneNumber Email Position";
            using (var db = new EmploeeContext())
            {
                foreach (var ss in db.employees)
                {
                    emps.Add(ss);
                }
                //dataListBox.ItemsSource = emps;
                dataGrid.ItemsSource = emps;

            }
        }

        private void dataGridChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void showOneWorker_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.logger.Info("Show one worker button clicked");
            emps.Clear();
            var name = textWorkerName.Text;

            using (var db = new EmploeeContext())
            {
                var rec = db.employees.Where(x => x.LastName == name).ToList();
                foreach (var ss in rec)
                {
                    emps.Add(ss);
                }

                dataGrid.ItemsSource = emps;

            }

        }

        private void showWorkerTimes_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.logger.Info("Show workers time button clicked");
            times.Clear();
            int id = Int32.Parse(textWorkerID.Text);
            using (var db = new EmploeeContext())
            {
                var rec = db.workTimes.Where(x => x.EmployeeId == id).ToList();

                foreach (var ss in rec)
                {
                    times.Add(ss);
                }

                dataGrid.ItemsSource = times;
            }
        }

        private void schowMyTimes_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.logger.Info("Show my times button clicked");
            times.Clear();
            int num = LoginScreen.acutalEmployeeId;
            using (var db = new EmploeeContext())
            {
                var rec = db.workTimes.Where(x => x.EmployeeId == num).ToList();

                foreach (var ss in rec)
                {
                    times.Add(ss);
                }

                dataGrid.ItemsSource = times;
            }
        }
    }
}
