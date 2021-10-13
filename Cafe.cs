using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    class Cafe
    {
        public Cafe()
        {
            newcocap = 0.0;
            newspp = 0.0;
            newmjp = 0.0;
            newojp = 0.0;
            newteap = 0.0;
            newcofp = 0.0;
            newwatp = 0.0;

            newburp = 0.0;
            newpizp = 0.0;
            newnop = 0.0;
            newricep = 0.0;
            newmeatp = 0.0;
            newvegep = 0.0;
            newcakep = 0.0;
        }

        public Cafe(double cocap, double spp, double mjp, double ojp, double teap, double cofp, double watp, double burp,
            double pizp, double nop, double ricep, double meatp, double vegep, double cakep)
        {
            newcocap = cocap;
            newspp = spp;
            newmjp = mjp;
            newojp = ojp;
            newteap = teap;
            newcofp = cofp;
            newwatp = watp;

            newburp = burp;
            newpizp = pizp;
            newnop = nop;
            newricep = ricep;
            newmeatp = meatp;
            newvegep = vegep;
            newcakep = cakep;
    }

        public double getcocap()
        {
            return newcocap;
        }
        public double getspp()
        {
            return newspp;
        }
        public double getmjp()
        {
            return newmjp;
        }
        public double getojp()
        {
            return newojp;
        }
        public double getteap()
        {
            return newteap;
        }
        public double getcofp()
        {
            return newcofp;
        }
        public double getwatp()
        {
            return newwatp;
        }
        public double getburp()
        {
            return newburp;
        }
        public double getpizp()
        {
            return newpizp;
        }
        public double getnop()
        {
            return newnop;
        }
        public double getricep()
        {
            return newricep;
        }
        public double getmeatp()
        {
            return newmeatp;
        }
        public double getvegep()
        {
            return newvegep;
        }
        public double getcakep()
        {
            return newcakep;
        }

        private double newcocap;
        private double newspp;
        private double newmjp;
        private double newojp;
        private double newteap;
        private double newcofp;
        private double newwatp;

        private double newburp;
        private double newpizp;
        private double newnop;
        private double newricep;
        private double newmeatp;
        private double newvegep;
        private double newcakep;

    }
}
