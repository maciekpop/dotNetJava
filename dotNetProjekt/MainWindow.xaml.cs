using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using dotNetProjekt.ViewModels;
using Microsoft.EntityFrameworkCore;
using log4net;
using System.Reflection;
using System.IO;
using log4net.Config;

namespace dotNetProjekt
{
    public partial class MainWindow : Window
    {
        public static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public MainWindow()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            InitializeComponent();
            logger.Info("Created main window");
            
        }

        

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new TimeViewModel();
            logger.Info("Button register clicked");
        }

        private void addingButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new AddingEmployeeModel();
            logger.Info("Button add employee clicked");
        }

        private void dataButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new InfoViewModel();
            logger.Info("Button show times clicked");
        }

        private void weatherButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new WeatherViewModel();
            logger.Info("Button show weather clicked");
        }
    }
}
