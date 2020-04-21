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


namespace dotNetProjekt
{
    public partial class MainWindow : Window
    {
        public class EmploeeContext : DbContext
        {
            public DbSet<Pracownicy> pracownicies { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseOracle(@"User Id=FIRMA;Password=rk7;Data Source=(DESCRIPTION = " +
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new EmploeeContext())
            {

                var pracownik = new Pracownicy { PracownicyId = Int32.Parse(empIDText.Text), Imie = fNameText.Text, Nazwisko = lNameText.Text, Adres = addressText.Text, Email = emailText.Text, NumerTelefonu = Int32.Parse(phoneText.Text), Stanowisko = positionText.Text };
                db.pracownicies.Add(pracownik);

                db.SaveChanges();
            }
            MessageBox.Show("New employee added successfully! :)");
        }
    }
}
