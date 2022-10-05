using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using static AutomationRandom.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace AutomationRandom
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Random rd = new Random();
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public static void GenerateFile(int quantity, string folderpath)
        {
            string[] print = new string[quantity];
            for (int i = 0; i < quantity; i++)
            {
                print[i] = CreateString();
            }
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream(folderpath, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            Console.WriteLine("Here's your list of Automation creations:");
            foreach (string str in print)
            {
                Console.WriteLine(str);
            }
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
        }
        public static string CreateString()
        {
            Variables.year = rd.Next(Variables.minYear, Variables.maxYear);
            string output = string.Empty;
            if (!Variables.doInspirationMode)
            {
                output += Convert.ToString(Variables.year) + " ";
                if (Variables.generateBody)
                {
                    output += Generator.GenerateBody() + " ";
                }
                if (Variables.generateEngine)
                {
                    output += Generator.GenerateEngine() + " ";
                }
                if (Variables.generateDrivetrainData)
                {
                    output += Generator.GenerateDrivetrain() + " ";
                }
                if (!Variables.noCountries || !Variables.noMarkets)
                {
                    output += Generator.GenerateMiscInfo();
                }
                if (!Variables.generateBody
                    && !Variables.generateEngine
                    && !Variables.generateDrivetrainData
                    && Variables.noCountries
                    && Variables.noMarkets
                    )
                {
                    output += Tech.GetRandomString(BodyData.bodyType);
                }
            }
            else if (Variables.doInspirationMode)
            {
                output = Data.GetVagueDate(Variables.year) + GenerateInspiration(Variables.year);

            }
            return output;
        }


        static string GenerateInspiration(int year)
        {
            string[] adjectives = Generator.GenerateAdjectives();
            string output = Tech.GetRandomString(MiscData.genericSize) + " " + adjectives[0]+ " "+ adjectives[1] + " " + Tech.GetRandomString(BodyData.bodyType) + " made in " +
                Tech.GetRandomString(MiscData.countryTypeReal) + " for sale in " + Tech.GetRandomString(MiscData.countryTypeReal);
            if (Variables.noUtility &&
                (output.Contains(BodyData.bodyType[6])
                || output.Contains(BodyData.bodyType[7])
                || output.Contains(BodyData.bodyType[8])))
            {
                output = GenerateInspiration(year);
            }
            if (Variables.noStupid &&
                ((output.Contains("Soviet Union") && year > 1991)
                || (output.Contains("Yugoslavia") && year > 1992)
                || (output.Contains("East Germany") && year > 1990)
                || (output.Contains("landyacht") &&
                    (output.Contains(MiscData.genericSize[0])
                    || output.Contains(MiscData.genericSize[1])
                    || output.Contains(MiscData.genericSize[2])
                    || output.Contains(MiscData.genericSize[3])
                    )
                || ((output.Contains("environmentally friendly")
                    || output.Contains("low-emission"))
                    && 
                    (output.Contains(BodyData.bodyType[6])
                    || output.Contains(BodyData.bodyType[7])
                    || output.Contains(BodyData.bodyType[8])
                    )
                || (Tech.ArrayContains(adjectives[0], CarAdjectives.firstCheap) && Tech.ArrayContains(adjectives[1], CarAdjectives.secondLuxury))
                || (Tech.ArrayContains(adjectives[0], CarAdjectives.firstLuxury) && Tech.ArrayContains(adjectives[1], CarAdjectives.secondCheap))
                ))))
            {
                output = GenerateInspiration(year);
            }
            return output;
        }


    }

}