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
    /// Logika interakcji dla klasy TimeView.xaml
    /// </summary>
    public partial class TimeView : UserControl
    {
        public TimeView()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new EmploeeContext())
            {
                var actualMaxRegisterIdnumber = db.workTimes.DefaultIfEmpty().Max(x => x.WorkTimeId);
                int num = LoginScreen.acutalEmployeeId;
                DateTime begin = DateTime.Parse(DateTimePickerBegin.Text);
                DateTime end = DateTime.Parse(DateTimePickerEnd.Text);
                double hourSpan = (end - begin).TotalHours;
                var workT = new WorkTime { WorkTimeId = actualMaxRegisterIdnumber + 1,  BeginningTime=begin, EndTime =end, EmployeeId= num, Hours=hourSpan};
                db.workTimes.Add(workT);
                db.SaveChanges();
            }
            MessageBox.Show("Time registered successfully! :)");
        }
    }
}
