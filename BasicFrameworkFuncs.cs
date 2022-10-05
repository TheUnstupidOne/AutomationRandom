using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationRandom
{
    public class Tech
    {
        public static bool ArrayContains(string what, string[] where)
        {
            bool contains = false;
            for (int i = 0; i < where.Length; i++)
            {
                if (where[i] == what)
                {
                    contains = true;
                }
            }
            return contains;
        }
         public static string GetRandomString(string[] input)
        {
            string output = input[Program.rd.Next(0, input.Length - 1)];
            return output;
        }

    }
    public class Data
    {
        public static string GetVagueDate(int year)
        {
            string output = string.Empty;
            if (year <= 1949)
            {
                output = MiscData.dateVague[0];
            }
            else if (year >= 1950 && year <= 1953)
            {
                output = MiscData.dateVague[1];
            }
            else if (year >= 1954 && year <= 1956)
            {
                output = MiscData.dateVague[2];
            }
            else if (year >= 1957 && year <= 1959)
            {
                output = MiscData.dateVague[3];
            }
            else if (year >= 1960 && year <= 1963)
            {
                output = MiscData.dateVague[4];
            }
            else if (year >= 1964 && year <= 1966)
            {
                output = MiscData.dateVague[5];
            }
            else if (year >= 1967 && year <= 1969)
            {
                output = MiscData.dateVague[6];
            }
            else if (year >= 1970 && year <= 1973)
            {
                output = MiscData.dateVague[7];
            }
            else if (year >= 1974 && year <= 1976)
            {
                output = MiscData.dateVague[8];
            }
            else if (year >= 1977 && year <= 1979)
            {
                output = MiscData.dateVague[9];
            }
            else if (year >= 1980 && year <= 1983)
            {
                output = MiscData.dateVague[10];
            }
            else if (year >= 1984 && year <= 1986)
            {
                output = MiscData.dateVague[11];
            }
            else if (year >= 1987 && year <= 1989)
            {
                output = MiscData.dateVague[12];
            }
            else if (year >= 1990 && year <= 1993)
            {
                output = MiscData.dateVague[13];
            }
            else if (year >= 1994 && year <= 1996)
            {
                output = MiscData.dateVague[14];
            }
            else if (year >= 1997 && year <= 1999)
            {
                output = MiscData.dateVague[15];
            }
            else if (year >= 2000 && year <= 2003)
            {
                output = MiscData.dateVague[16];
            }
            else if (year >= 2004 && year <= 2006)
            {
                output = MiscData.dateVague[17];
            }
            else if (year >= 2007 && year <= 2009)
            {
                output = MiscData.dateVague[18];
            }
            else if (year >= 2010 && year <= 2013)
            {
                output = MiscData.dateVague[19];
            }
            else if (year >= 2014 && year <= 2016)
            {
                output = MiscData.dateVague[20];
            }
            else if (year >= 2017 && year <= 2020)
            {
                output = MiscData.dateVague[21];
            }
            else
            {
                output = "what";
            }
            return output;
        }
        public static double GenerateDisplacementNumeric(int from, int to)
        {
            double displacement = 0;
            displacement = Program.rd.Next(from, to) + Program.rd.NextDouble();
            if (displacement < 0.236)
            {
                displacement = displacement + Program.rd.NextDouble();
            }
            if (displacement > 21.715)
            {
                displacement = 21.715;
            }
            displacement = Math.Round(displacement, 2);
            return displacement;
        }
    }
}
