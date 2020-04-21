using System;
using System.Collections.Generic;
using System.Text;

namespace dotNetProjekt
{
    public class CzasPracy
    {
        public int CzasPracyId { get; set; }
        public Pracownicy Pracownicy { get; set; }

        public int PracownicyId { get; set; }

        public DateTime CzasRozpoczęcia { get; set; }

        public DateTime CzasZakończenia { get; set; }
    }
}
