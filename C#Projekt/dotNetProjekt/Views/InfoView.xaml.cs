using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace dotNetProjekt.Views
{
    public partial class InfoView : UserControl
    {
        public InfoView()
        {
            InitializeComponent();
            MainWindow.logger.Info("Info view initialize");

        }


        List<Employee> emps = new List<Employee>();
        List<WorkTime> times = new List<WorkTime>();


       

        private void showAllDataButton_Click(object sender, RoutedEventArgs e)
        {
            emps.Clear();
            using (var db = new EmploeeContext())
            {
                foreach (var ss in db.employees)
                {
                    emps.Add(ss);
                }
                dataGrid.ItemsSource = emps;

            }
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
            try
            {
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
            catch(System.FormatException e3)
            {
                MainWindow.logger.Info("Error occured", e3);
                MessageBox.Show("Incorrect data. Try again.");
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
