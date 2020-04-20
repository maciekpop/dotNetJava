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
using Microsoft.EntityFrameworkCore;

namespace Nauka
{
   
    public partial class MainWindow : Window
    {
        public class EmploeeContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseOracle(@"User Id=TEST;Password=rk7;Data Source=(DESCRIPTION = " +
   " (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
    "(CONNECT_DATA =" +
     " (SERVER = DEDICATED)" +
      "(SERVICE_NAME = XEPDB1)" +
    "));");
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        
    }
}
