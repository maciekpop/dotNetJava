using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;

namespace dotNetProjekt
{
    public class DataForTest
    {

        public static void setTestWorker()
        {
            using (var db = new EmploeeContext())
            {
                var emp = db.employees.Where(x => x.Position == "tester");
                if (!emp.Any())
                {
                    var actualMaxIdnumber = db.employees.DefaultIfEmpty().Max(x => x.EmployeeId);
                    var testEmp = new Employee { EmployeeId = actualMaxIdnumber + 1, FirstName = "Jan", LastName = "Kowalski", Address = "Warszawa", Email = "jank@gmail.com", PhoneNumber = 725321843, Position = "tester" };
                    db.employees.Add(testEmp);
                    db.SaveChanges();

                }


            }
        }

        public static string giveName()
        {
            using (var db = new EmploeeContext())
            {
                return db.employees.Where(x => x.Position == "tester").Select(u => u.FirstName).FirstOrDefault().ToString();
            }
        }

        public static string giveSurame()
        {
            using (var db = new EmploeeContext())
            {
                return db.employees.Where(x => x.Position == "tester").Select(u => u.LastName).FirstOrDefault().ToString();
            }
        }

        public static int givePhone()
        {
            using (var db = new EmploeeContext())
            {
                return db.employees.Where(x => x.Position == "tester").Select(u => u.PhoneNumber).FirstOrDefault();
            }
        }

        public static string giveAddress()
        {
            using (var db = new EmploeeContext())
            {
                return db.employees.Where(x => x.Position == "tester").Select(u => u.Address).FirstOrDefault().ToString();
            }
        }

        public static string giveEmail()
        {
            using (var db = new EmploeeContext())
            {
                return db.employees.Where(x => x.Position == "tester").Select(u => u.Email).FirstOrDefault().ToString();
            }
        }

        public static void setTestTime()
        {
            using (var db = new EmploeeContext())
            {
                var wt = db.workTimes.Where(x => x.WorkTimeId == 123);
                if (!wt.Any())
                {
                    DateTime begin = new DateTime(2020, 5, 10, 4, 0, 0);
                    DateTime end = new DateTime(2020, 5, 10, 12, 0, 0);
                    double hourSpan = (end - begin).TotalHours;
                    var workT = new WorkTime { WorkTimeId = 123, BeginningTime = begin, EndTime = end, EmployeeId = 1, Hours = hourSpan };
                    db.workTimes.Add(workT);
                    db.SaveChanges();
                }
            }
        }

        public static double giveHourSpan()
        {
            using (var db = new EmploeeContext())
            {
                return db.workTimes.Where(x => x.WorkTimeId == 123).Select(u => u.Hours).FirstOrDefault();
            }
        }


        public static DateTime giveBeginTime()
        {
            using (var db = new EmploeeContext())
            {
                return db.workTimes.Where(x => x.WorkTimeId == 123).Select(u => u.BeginningTime).FirstOrDefault();
            }
        }

        public static DateTime giveEndTime()
        {
            using (var db = new EmploeeContext())
            {
                return db.workTimes.Where(x => x.WorkTimeId == 123).Select(u => u.EndTime).FirstOrDefault();
            }
        }
    }
}