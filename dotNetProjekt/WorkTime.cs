using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetProjekt
{
    public class WorkTime
    {
        public int WorkTimeId { get; set; }
        public Employee Employee { get; set; }

        public int EmpId { get; set; }

        public DateTime BeginningTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}