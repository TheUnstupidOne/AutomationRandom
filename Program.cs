using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using static AutomationRandom.Form1;

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
            output += Convert.ToString(Variables.year) + " ";
            if (Variables.generateBody)
            {
                output += GenerateBody() + " ";
            }
            if (Variables.generateEngine)
            {
                output += GenerateEngine() + " ";
            }
            if (Variables.generateDrivetrainData)
            {
                output += GenerateDrivetrain() + " ";
            }
            if (!Variables.noCountries || !Variables.noMarkets)
            {
                output += GenerateMiscInfo();
            }
            if (!Variables.generateBody
                && !Variables.generateEngine
                && !Variables.generateDrivetrainData
                && Variables.noCountries
                && Variables.noMarkets
                )
            {
                output += GetRandomString(BodyData.bodyType);
            }
            return output;
        }
        static double GenerateDisplacementNumeric(int from, int to)
        {
            double displacement = 0;
            displacement = rd.Next(from, to) + rd.NextDouble();
            if (displacement < 0.236)
            {
                displacement = displacement + rd.NextDouble();
            }
            if (displacement > 21.715)
            {
                displacement = 21.715;
            }
            displacement = Math.Round(displacement, 2);
            return displacement;
        }
        static string GenerateEngine()
        {
            string output = " with ";
            string position = string.Empty;
            string block = string.Empty; 
            string valves = string.Empty;
            string head = string.Empty;
            string turbo = string.Empty;
            string displacement = string.Empty;
            string fuel = string.Empty;
            string layout = string.Empty;

            if (Variables.generateEnginePosition)
            {
                position = GetRandomString(EngineData.enginePosition) + " ";
            }
            if (Variables.generateEngineMaterials)
            {
                block = GetRandomString(EngineData.engineBlock) + " block and ";
            }
            if (Variables.generateEngineIntake)
            {
                valves = GetRandomString(EngineData.engineIntakeType);
            }
            if (Variables.generateEngineMaterials)
            {
                head += GetRandomString(EngineData.engineTop);
            }
            if (Variables.generateEngineMaterials || Variables.generateEngineIntake)
            {
                head += " head ";
            }
            if (Variables.generateEngineTurbo)
            {
                turbo = GetRandomString(EngineData.engineTurbo);
            }
            if (Variables.generateEngineDisplacement)
            {
                displacement = GenerateDisplacement();
            }

            if (Variables.generateEngineFuel)
            {
                fuel = GetRandomString(EngineData.engineFuelType) + " powered ";
            }
            if (Variables.generateEngineLayout)
            {
                layout = GetRandomString(EngineData.engineLayout) + " ";
            }
            if (Variables.generateEngineType)
            {
                string engineType = GetRandomString(EngineData.engineType) + " ";
                if (engineType.Contains("Inline"))
                {
                    engineType += GetRandomString(EngineData.engineCylinderNumbers[0]);
                }
                else if (engineType.Contains("Boxer"))
                {
                    engineType += GetRandomString(EngineData.engineCylinderNumbers[3]);
                }
                else if (engineType.Contains("V"))
                {
                    string engineAngle = GetRandomString(EngineData.engineCylinderNumbers[5]);
                    if (engineAngle == EngineData.engineCylinderNumbers[5][0])
                    {
                        engineType += GetRandomString(EngineData.engineCylinderNumbers[2]) + " ";
                        engineType = engineAngle + engineType;
                    }
                    else
                    {
                        string crankType = GetRandomString(EngineData.engineCylinderNumbers[4]);
                        if (crankType == EngineData.engineCylinderNumbers[4][0])
                        {
                            crankType += "8 ";

                        }
                        else
                        {
                            crankType += GetRandomString(EngineData.engineCylinderNumbers[1]) + " ";
                        }
                        engineType = engineAngle + crankType + engineType;
                    }

                }
                output = position+ block +valves+head+turbo+fuel+displacement + layout+engineType;
            }
            else
            {
                output = " engine ";
            }
            return output;
        }
        static string GenerateDisplacement()
        {
            string output = string.Empty;
            if(Variables.displacementMode==0)
            {
                output = Convert.ToString(GenerateDisplacementNumeric(0, 2)) + " Liter ";
            }
            if (Variables.displacementMode==1)
            {
                output = Convert.ToString(GenerateDisplacementNumeric(2, 4)) + " Liter ";
            }
            if (Variables.displacementMode == 2)
            {
                output = Convert.ToString(GenerateDisplacementNumeric(5, 8)) + " Liter ";
            }
            if (Variables.displacementMode == 3 && Variables.noStupid)
            {
                output = Convert.ToString(GenerateDisplacementNumeric(1, 8)) + " Liter ";
            }
            else if (Variables.displacementMode ==3 && !Variables.noStupid)
            { 
                output = Convert.ToString(GenerateDisplacementNumeric(0, 21)) + " Liter ";
            }
            return output;
        }
        static string GenerateDrivetrain()
        {
            string output = " with ";
            if (Variables.generateDrivetrainWheels)
            {
                output += GetRandomString(DrivetrainData.drivetrainWheelsType) + " drivetrain ";
            }
            if (Variables.generateDrivetrainGearbox)
            {
                output += GetRandomString(DrivetrainData.drivetrainGearboxType) + " gearbox ";
            }
            if (Variables.generateDrivetrainDiff)
            {
                output += GetRandomString(DrivetrainData.drivetrainDiffType) + " differential ";
            }
            if (Variables.generateDrivetrainTyreCompound)
            {
                output += GetRandomString(DrivetrainData.drivetrainTyreCompound) + " tyres ";
            }
            if (Variables.noUtility &&
                (output.Contains(DrivetrainData.drivetrainWheelsType[2])
                || output.Contains(DrivetrainData.drivetrainDiffType[1])
                || output.Contains(DrivetrainData.drivetrainDiffType[2])
                ))
            {
                output = GenerateDrivetrain();
            }
            return output;
        }
        static string GenerateBody()
        {
            string output = string.Empty;
            string bodyMaterials = string.Empty;
            string bodyChassisMaterials = string.Empty;
            string bodyChassisType = string.Empty;
            string bodyType = string.Empty;
            string suspensionFront = string.Empty;
            string suspensionRear = string.Empty;
            if (Variables.generateBodyMaterials)
            {
                bodyMaterials = GetRandomString(BodyData.bodyMaterials) + " body ";
                
            }
            if (Variables.generateBodyChassisMaterials || Variables.generateBodyChassisType)
            {
                bodyMaterials = bodyMaterials+ "on ";
            }
            if (Variables.generateBodyChassisMaterials)
            {
                bodyChassisMaterials = GetRandomString(BodyData.bodyChassisMaterial) + " ";
            }
            if (Variables.generateBodyChassisType)
            {
                bodyChassisType = GetRandomString(BodyData.bodyChassisType);
            }
            if (Variables.generateBodyChassisMaterials || Variables.generateBodyChassisType)
            {
                bodyChassisType = bodyChassisType + " chassis ";
            }
            else if (Variables.generateBodyMaterials)
            {
                bodyMaterials.Replace(" body", "-bodied");
            }
            if (Variables.generateBodyType)
            {
                bodyType += GetRandomString(BodyData.bodyType);
            }
            if (Variables.generateBodySuspension)
            {
                suspensionFront += " with " + GetRandomString(BodyData.bodyFrontSuspensionType) + " in front ";
                suspensionRear += "and " + GetRandomString(BodyData.bodyRearSuspensionType) + " in the back";
            }
            if (Variables.noUtility &&
                (suspensionFront.Contains(BodyData.bodyFrontSuspensionType[0])
                || suspensionFront.Contains(BodyData.bodyFrontSuspensionType[1])
                || suspensionRear.Contains(BodyData.bodyRearSuspensionType[0])
                || suspensionRear.Contains(BodyData.bodyRearSuspensionType[1])
                || suspensionRear.Contains(BodyData.bodyRearSuspensionType[3])
                || bodyType.Contains(BodyData.bodyType[6])
                || bodyType.Contains(BodyData.bodyType[7])
                || bodyType.Contains(BodyData.bodyType[8])))
            {
                output = GenerateBody();
            }
            else
            {
                output = bodyMaterials + bodyChassisMaterials + bodyChassisType + bodyType + suspensionFront + suspensionRear;
            }
            return output;
        }
        static string GenerateMiscInfo()
        {
            string output = string.Empty;
            if (!Variables.noMarkets && Variables.noUtility)
            {
                output += GetRandomString(MiscData.marketTypeNoUtility);
            }
            else if (!Variables.noMarkets && !Variables.noUtility)
            {
                output += GetRandomString(MiscData.marketType);
            }
            else
            {
                output += " for any market";
            }
            if (!Variables.noCountries && Variables.generateRealCountries)
            {
                output += " in " + GetRandomString(MiscData.countryTypeReal);
            }
            else if (!Variables.noCountries && !Variables.generateRealCountries)
            {
                output += " in " + GetRandomString(MiscData.countryType);
            }
            else
            {
                output += " in any country";
            }
            return output;
        }
        static string GetRandomString(string[] input)
        {
            string output = input[rd.Next(0, input.Length - 1)];
            return output;
        }
    }
    public static class EngineData
    {
        public static string[][] engineCylinderNumbers = new string[][]
        {
        new string[] { "3", "4", "5", "6" },
        new string[] { "6", "10", "16" },
        new string[] { "6", "8", "12" },
        new string[] { "4", "6" },
        new string[] { "Flatplane ", "Crossplane " },
        new string[] { " 60 degree ", " 90 degree " }
        };
        public static string[] enginePosition = { "Front Transverse", "Middle Transverse", "Back Transverse", "Front Longitudional", "Middle Longitudional", "Back Longitudional" };
        public static string[] engineBlock = { "Cast Iron ", "Aluminium ", "AlSi ", "Magnesium " };
        public static string[] engineTop = { "Cast Iron ", "Aluminium ", "AlSi " };
        public static string[] engineIntakeType = { "Push Rod ", "Direct Acting OHC ", "Single Overhead Cam ", "Dual Overhead Cam " };
        public static string[] engineTurbo = { "N/A ", "Single Turbo ", "Twin Turbo " };
        public static string[] engineFuelType = { "Low Quality 85 RON Unleaded Gasoline", "Regular 91 RON Unleaded Gasoline", "Premium 95 RON Unleaded Gasoline", "Super 98 RON Unleaded Gasoline",
                "Ultimate 100 RON Unleaded Gasoline", "Super 98 RON Leaded Gasoline", "Regular 92 RON Leaded Gasoline", "100 RON AvGas Leaded",
                "Ethanol E10 92 RON", "Ethanol E70 106 RON", "Ethanol E85 108 RON", "Ethanol E100 129 RON",
                "Compressed LPG 112RON", "Compressed LNG 150 RON", "Methanol 136 RON", "Nitromethane 136 RON"};
        public static string[] engineType = { "Inline ", "V", "Boxer" };
        public static string[] engineLayout = { "Oversquare", "Square", "Undersquare" };
    }
    public static class DrivetrainData
    {
        public static string[] drivetrainWheelsType = { "FWD", "AWD", "4WD", "RWD" };
        public static string[] drivetrainGearboxType = { "Automatic", "Advanced Automatic", "Manual", "Dual Clutch", "Sequental", "Auto Manual" };
        public static string[] drivetrainDiffType = { "Open diff", "Manual Locker", "Automatic Locker", "Geared LSD", "Viscous LSD", "Electric LSD" };
        public static string[] drivetrainTyreCompound = { "Chunky offroad", "Allterrain", "Utility", "Hard long life", "Medium Compound", "Sports Compound", "Semi-Slicks" };
    }
    public static class BodyData
    {
        public static string[] bodyChassisMaterial = { "Steel", "Galvanized Steel", "Corrosion Resistant Steel", "AHS Steel", "Light AHS Steel", "Glued Aluminium", "Carbon Fibre" };
        public static string[] bodyType = { "Sedan", "Wagon", "Hatchback", "Coupe", "Convertible", "MPV", "SUV", "Utility/Pickup", "Van" };
        public static string[] bodyMaterials = { "Steel", "Treated Steel", "Fibre Glass", "Aluminium", "Partial Alu", "Carbon Fibre" };
        public static string[] bodyChassisType = { "Ladder", "Monocoque", "Space frame", "Semi-space frame", "Light truck monocoque" };
        public static string[] bodyFrontSuspensionType = { "Solid Axle Coil", "Solid Axle Leaf", "Double Wishbone", "MacPherson Strut", "Pushrod" };
        public static string[] bodyRearSuspensionType = { "Solid Axle Coil", "Solid Axle Leaf", "Semi-trailing arm", "Torsion beam", "Double Wishbone", "MacPherson Strut", "Multilink", "Pushrod" };
    }
    public static class MiscData
    {
        public static string[] countryType = { "Dalluha (Saudi Arabia/Quatar/UAE)", "Archana (Iran/Pakistan/Indonesia)","Fruinia (France/Sweden/Italy)",
                "Gasmea (North America)", "Hetvesia(Germany/Austria/Switzerland)" };
        public static string[] marketType = {"Utility Budget", "Utility Sport", "Family Utility Budget", "Utility", "Utility Sport Premium", "Family Utility",
                "Utility Premium", "Utility Sport Luxury", "Family Utility Premium", "Offroad Utility", "Heavy Utility", "Passanger Fleet",
                "Light Delivery", "Delivery", "Heavy Delivery", "Offroad Budget ", "Commuter Budget", "Family Budget", "Fun Budget", "Light Sport Budget",
                "Track Budget", "Convertible Sport Budget", "Convertiible Budget", "Premium Budget", "Offroad", "Commuter", "Family", "Fun", "Light Sport", "Track",
                "Convertible Sport", "Convertible", "Premium", "Offroad Premium", "Commuter Premium", "Family Premium", "Fun Premium", "Light Sport Premium", "Track Premium",
                "Convertible Sport Premium", "Convertible Premium", "Luxury", "City Budget", "City Eco", "Family Sport", "Pony Budget", "Muscle", "Sport Budget", "Super",
                "Convertible Luxury", "Luxury Premium", "City", "City Premium", "Family Sport Premium", "Pony", "Muscle Premium", "Sport", "Hyper", "GT", "GT Premium"};
        public static string[] marketTypeNoUtility = {"Commuter Budget", "Family Budget", "Fun Budget", "Light Sport Budget",
                "Track Budget", "Convertible Sport Budget", "Convertiible Budget", "Premium Budget", "Commuter", "Family", "Fun", "Light Sport", "Track",
                "Convertible Sport", "Convertible", "Premium", "Commuter Premium", "Family Premium", "Fun Premium", "Light Sport Premium", "Track Premium",
                "Convertible Sport Premium", "Convertible Premium", "Luxury", "City Budget", "City Eco", "Family Sport", "Pony Budget", "Muscle", "Sport Budget", "Super",
                "Convertible Luxury", "Luxury Premium", "City", "City Premium", "Family Sport Premium", "Pony", "Muscle Premium", "Sport", "Hyper", "GT", "GT Premium"};
        public static string[] countryTypeReal = {"Australia", "Great Britain", "Gernamy", "France", "Italy",
            "Yugoslavia", "Poland", "Soviet Union", "China", "South Korea", "Japan",
            "United States", "Sweden", "Indonesia", "India"};
    }
}