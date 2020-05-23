using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace dotNetProjekt.Views
{

    public partial class TimeView : UserControl
    {
        public TimeView()
        {
            MainWindow.logger.Info("TimeView initialize");
            InitializeComponent();
        }

        private async void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.logger.Info("Register Button in TimeView clicked");
            try
            {
                using (var db = new EmploeeContext())
                {
                    var actualMaxRegisterIdnumber = db.workTimes.DefaultIfEmpty().Max(x => x.WorkTimeId);
                    int num = LoginScreen.acutalEmployeeId;
                    DateTime begin = DateTime.Parse(DateTimePickerBegin.Text);
                    DateTime end = DateTime.Parse(DateTimePickerEnd.Text);
                    double hourSpan = (end - begin).TotalHours;
                    var workT = new WorkTime { WorkTimeId = actualMaxRegisterIdnumber + 1, BeginningTime = begin, EndTime = end, EmployeeId = num, Hours = hourSpan };
                    await db.workTimes.AddAsync(workT);
                    await db.SaveChangesAsync();
                }
                MessageBox.Show("Time registered successfully! :)");
            }
            catch(System.ArgumentNullException e2)
            {
                MainWindow.logger.Info("Error occured", e2);
                MessageBox.Show("Incorrect data. Try again.");
            }
        }
    }
}
