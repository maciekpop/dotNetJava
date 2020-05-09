using System;

namespace dotNetProjekt
{
    public class WorkTime
    {
        public int WorkTimeId { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime BeginningTime { get; set; }

        public DateTime EndTime { get; set; }

        public double Hours { get; set; }

    }
}