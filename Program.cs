using System.Web;
using static AutomationRandom.Form1;

namespace AutomationRandom
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
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
            Random rd = new Random();
            Variables.year = rd.Next(Variables.minYear,Variables.maxYear);
            string[] bodyMaterials = { "Steel", "TreatedSteel", "Fibre Glass", "Aluminium", "Partial Alu", "Carbon Fibre" };
            string[] chassisMaterial = { "Steel", "Galvanized Steel", "Corrosion Resistant Steel", "AHS Steel", "Light AHS Steel", "Glued Aluminium", "Carbon Fibre" };
            string[] bodyType = { "Sedan", "Wagon", "Hatchback", "Coupe", "Convertible", "MPV", "SUV", "Utility/Pickup", "Van" };
            string[] enginePosition = { "Front Transverse", "Middle Transverse", "Back Transverse", "Front Longitudional", "Middle Longitudional", "Back Longitudional" };
            string[] engineBlock = { "Cast Iron " , "Aluminium ", "AlSi ", "Magnesium " };
            string[] engineTop = { "Cast Iron " , "Aluminium " , "AlSi " };
            string[] intakeType = { "Push Rod ", "Direct Acting OHC ", "Single Overhead Cam ", "Dual Overhead Cam "  };
            string[] engineTurbo = { "N/A ", "Single Turbo ", "Twin Turbo " };
            string[] fuelType = { "Low Quality 85 RON Unleaded Gasoline", "Regular 91 RON Unleaded Gasoline", "Premium 95 RON Unleaded Gasoline", "Super 98 RON Unleaded Gasoline",
                "Ultimate 100 RON Unleaded Gasoline", "Super 98 RON Leaded Gasoline", "Regular 92 RON Leaded Gasoline", "100 RON AvGas Leaded",
                "Ethanol E10 92 RON", "Ethanol E70 106 RON", "Ethanol E85 108 RON", "Ethanol E100 129 RON",
                "Compressed LPG 112RON", "Compressed LNG 150 RON", "Methanol 136 RON", "Nitromethane 136 RON"};
            string[] engineType = { "Inline ", "V", "Boxer" };
            string[] engineLayout = { "Oversquare", "Square", "Undersquare" };
            string[] drivetrainType = { "FWD", "AWD", "4WD", "RWD" };
            string[] gearboxType = { "Automatic", "Advanced Automatic", "Manual", "Dual Clutch", "Sequental", "Auto Manual" };
            string[] differentialType = { "Open diff", "Manual Locker", "Automatic Locker", "Geared LSD", "Viscous LSD", "Electric LSD" };
            string[] countryType = { "Dalluha (Saudi Arabia/Quatar/UAE)", "Archana (Iran/Pakistan/Indonesia)","Fruinia (France/Sweden/Italy)",
                "Gasmea (North America)", "Hetvesia(Germany/Austria/Switzerland)" };
            string[] marketType = {"Utility Budget", "Utility Sport", "Family Utility Budget", "Utility", "Utility Sport Premium", "Family Utility",
                "Utility Premium", "Utility Sport Luxury", "Family Utility Premium", "Offroad Utility", "Heavy Utility", "Passanger Fleet",
                "Light Delivery", "Delivery", "Heavy Delivery", "Offroad Budget ", "Commuter Budget", "Family Budget", "Fun Budget", "Light Sport Budget",
                "Track Budget", "Convertible Sport Budget", "Convertiible Budget", "Premium Budget", "Offroad", "Commuter", "Family", "Fun", "Light Sport", "Track",
                "Convertible Sport", "Convertible", "Premium", "Offroad Premium", "Commuter Premium", "Family Premium", "Fun Premium", "Light Sport Premium", "Track Premium",
                "Convertible Sport Premium", "Convertible Premium", "Luxury", "City Budget", "City Eco", "Family Sport", "Pony Budget", "Muscle", "Sport Budget", "Super",
                "Convertible Luxury", "Luxury Premium", "City", "City Premium", "Family Sport Premium", "Pony", "Muscle Premium", "Sport", "Hyper", "GT", "GT Premium"};
            string[][] cylinderNumbers = new string[6][];
            cylinderNumbers[0] = new string[]{ "3", "4", "5", "6" };
            cylinderNumbers[1] = new string[] { "6", "10", "16" };
            cylinderNumbers[2] = new string[] { "6", "8", "12" };
            cylinderNumbers[3] = new string[] { "4", "6" };
            cylinderNumbers[4] = new string[] { "Flatplane", "Crossplane" };
            cylinderNumbers[5] = new string[] { " 60 degree ", " 90 degree " }; 
            string[] elements = new string[21];
            elements[0] = Convert.ToString(Variables.year);
            if (Variables.noBody)
            {
                elements[1] = " " + bodyMaterials[rd.Next(0, bodyMaterials.Length - 1)] + " body on ";
                elements[2] = chassisMaterial[rd.Next(0, chassisMaterial.Length - 1)] + " chassis";
            }
            else
            {
                elements[1] = String.Empty;
                elements[2] = String.Empty;
            }
            elements[3] = " "+bodyType[rd.Next(0, bodyType.Length - 1)] + " with ";
            if (Variables.noEngine)
            {
                elements[4] = enginePosition[rd.Next(0, enginePosition.Length - 1)] + " ";
                if (Variables.noEngineMaterials)
                {
                    elements[5] = engineBlock[rd.Next(0, engineBlock.Length - 1)] + " block and ";
                    elements[7] = engineTop[rd.Next(0, engineTop.Length - 1)]+ " head ";
                }
                else
                {
                    elements[5] = string.Empty;
                    elements[7] = string.Empty;
                }
                if (Variables.noIntake)
                {
                    elements[6] = intakeType[rd.Next(0, intakeType.Length - 1)];
                    if (!Variables.noEngineMaterials)
                    {
                        elements[6] = elements[6]+ " head ";
                    }
                }
                else
                {
                    elements[6] = string.Empty;
                }
                if (Variables.noTurbo)
                {
                    elements[8] = engineTurbo[rd.Next(0, engineTurbo.Length - 1)];
                }
                if (Variables.noDisplacement)
                {
                    switch(Variables.displacementMode)
                    {
                        case 0:
                            elements[10] = Convert.ToString(Math.Round(GenerateDisplacement(0, 2),2 ))+" Liter";
                            break;
                        case 1:
                            elements[10] = Convert.ToString(Math.Round(GenerateDisplacement(2, 4), 2)) + " Liter";
                            break;
                        case 2:
                            elements[10] = Convert.ToString(Math.Round(GenerateDisplacement(5, 8), 2)) + " Liter";
                            break;
                        case 3:
                            elements[10] = Convert.ToString(Math.Round(GenerateDisplacement(0, 21), 2)) + " Liter";
                            break;
                    }
                }
                else
                {
                    elements[10] = string.Empty;
                }
                if(Variables.noFuel)
                {
                    elements[9] = fuelType[rd.Next(0, fuelType.Length - 1)] + " powered ";
                }
                elements[11] = engineLayout[rd.Next(0, engineLayout.Length - 1)];
                elements[12] = engineType[rd.Next(0, engineType.Length - 1)]+ " ";
                if (elements[12].Contains("Inline"))
                {
                    elements[13] = cylinderNumbers[0][rd.Next(0, cylinderNumbers[0].Length-1)];
                    elements[14] = string.Empty;
                    elements[15] = string.Empty;
                }
                else if (elements[12].Contains("Boxer"))
                {
                    elements[13] = cylinderNumbers[3][rd.Next(0, cylinderNumbers[3].Length - 1)];
                    elements[14] = string.Empty;
                    elements[15] = string.Empty;
                }
                else if (elements[12].Contains("V"))
                {
                    string temp = cylinderNumbers[5][rd.Next(0, 1)];
                    elements[13] = elements[12];
                    elements[12] = temp;
                    if (temp == cylinderNumbers[5][0])
                    {
                        elements[14] = cylinderNumbers[2][rd.Next(0, cylinderNumbers[2].Length - 1)] + " ";
                    }   
                    else
                    {
                        string temp2 = cylinderNumbers[4][rd.Next(0, 1)];
                        elements[14] = elements[13];
                        elements[13] = temp2;
                        if (temp2 == cylinderNumbers[4][0])
                        {
                            
                            elements[15] = "8 ";
                        }
                        else
                        {
                            elements[15] = cylinderNumbers[1][rd.Next(0, cylinderNumbers[1].Length - 1)] + " ";
                        }
                    }
                }
            }
            else
            {
                elements[4] = String.Empty;
                elements[5] = string.Empty;
                elements[6] = string.Empty;
                elements[7] = string.Empty;
                elements[8] = string.Empty;
                elements[9] = string.Empty;
                elements[10] = string.Empty;
                elements[11] = string.Empty;
                elements[12] = string.Empty;
                elements[13] = string.Empty;
                elements[14] = string.Empty;
                elements[15] = string.Empty;
            }
            elements[16] = " with " + drivetrainType[rd.Next(0, gearboxType.Length - 1)] +" drivetrain";
            if(Variables.noGearbox)
            {
                elements[17] = ", " + gearboxType[rd.Next(0, gearboxType.Length - 1)];
            }
            else { elements[17] = string.Empty; }
            if(Variables.noLSD)
            {
                elements[18] = " and " + differentialType[rd.Next(0, differentialType.Length - 1)];
            }
            else { elements[18] = string.Empty; }
            elements[19] = " for ";
            if (Variables.noMarkets)
            {
            }
            else
            {
                if (Variables.noUtility)
                {
                    elements[19] += marketType[rd.Next(15, marketType.Length - 1)] +" market";
                }
                else
                {
                    elements[19] += marketType[rd.Next(0, marketType.Length - 1)] +" market";
                }
                if (Variables.noCountries)
                {
                    elements[20] = string.Empty;
                }
                else
                {
                    elements[20] = " in "+countryType[rd.Next(0, countryType.Length - 1)];
                }
            }
            string output = elements[0] + elements[1] + elements[2] + elements[3] + elements[4] + elements[5] + elements[6]
                + elements[7] + elements[8] + elements[9] + elements[10] + elements[11] + elements[12]
                + elements[13] + elements[14] + elements[15] + elements[16] + elements[17] + elements[18] + elements[18] + elements[19] + elements[20] ;     
            return output;
        }
        static double GenerateDisplacement(int from, int to)
        {
            double displacement = 0;
            Random rd = new Random();
            displacement = rd.Next(from, to) + rd.NextDouble();
            if (displacement<0.236)
                {
                displacement = displacement + rd.NextDouble();
            }
            if (displacement > 21.715)
            {
                displacement = 21.715;
            }
            Math.Round(displacement, 2);
            return displacement;
        }
    }
}