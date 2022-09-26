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
        public static void GenerateFile(int quantity)
        {
            string[] print = new string[quantity];
            for (int i = 0; i < quantity; i++)
            {
                print[i] = CreateString();
            }
        }
        public static string CreateString()
        {
            string[] bodyMaterials = { "Steel", "TreatedSteel", "Fibre Glass", "Aluminium", "Partial Alu", "Carbon Fibre" };
            string[] chassisMaterial = { "Steel", "Galvanized Steel", "Corrosion Resistant Steel", "AHS Steel", "Light AHS Steel", "Glued Aluminium", "Carbon Fibre" };
            string[] bodyType = { "Sedan", "Wagon", "Hatchback", "Coupe", "Convertible", "SUV", "Utility", "MPV", "Van" };
            string[] enginePosition = { "Front Transverse", "Middle Transverse", "Back Transverse", "Front Longitudional", "Middle Longitudional", "Back Longitudional" };
            string[] engineBlock = { "Cast Iron", "Aluminium", "AlSi", "Magnesium" };
            string[] engineTop = { "Cast Iron", "Aluminium", "AlSi" };
            string[] engineTurbo = { "N/A", "Single Turbo", "Twin Turbo" };
            string[] fuelType = { "Low Quality 85 RON Unleaded Gasoline", "Regular 91 RON Unleaded Gasoline", "Premium 95 RON Unleaded Gasoline", "Super 98 RON Unleaded Gasoline",
                "Ultimate 100 RON Unleaded Gasoline", "Super 98 RON Leaded Gasoline", "Regular 92 RON Leaded Gasoline", "100 RON AvGas Leaded",
                "Ethanol E10 92 RON", "Ethanol E70 106 RON", "Ethanol E85 108 RON", "Ethanol E100 129 RON",
                "Compressed LPG 112RON", "Compressed LNG 150 RON", "Methanol 136 RON", "Nitromethane 136 RON"};
            string[] engineType = { "Inline", "V", "Boxer" };
            string[] drivetrainType = { "FWD", "AWD", "4WD", "RWD" };
            string[] gearboxType = { "Automatic", "Advanced Automatic", "Manual", "Dual Clutch", "Sequental", "Auto Manual" };
            string[] differentialType = { "Open diff", "Manual Locker", "Automatic Locker", "Geared LSD", "Viscous LSD", "Electric LSD" };
            string[] countryType = { "Dalluha (Saudi Arabia/Quatar", "Archana (Iran/Pakistan/Indonesia)","Fruinia (France/Sweden/Italy)",
                "Gasmea (North America)", "Hetvesia(Germany/Austria/Switzerland)" };
            string[] marketType = {"Utility Budget", "Utility Sport", "Family Utility Budget", "Utility", "Utility Sport Premium", "Family Utility",
                "Utility Premium", "Utility Sport Luxury", "Family Utility Premium", "Offroad Utility", "Heavy Utility", "Passanger Fleet",
                "Light Delivery", "Delivery", "Heavy Delivery", "Offroad Budget ", "Commuter Budget", "Family Budget", "Fun Budget", "Light Sport Budget",
                "Track Budget", "Convertible Sport Budget", "Convertiible Budget", "Premium Budget", "Offroad", "Commuter", "Family", "Fun", "Light Sport", "Track",
                "Convertible Sport", "Convertible", "Premium", "Offroad Premium", "Commuter Premium", "Family Premium", "Fun Premium", "Light Sport Premium", "Track Premium",
                "Convertible Sport Premium", "Convertible Premium", "Luxury", "City Budget", "City Eco", "Family Sport", "Pony Budget", "Muscle", "Sport Budget", "Super",
                "Convertible Luxury", "Luxury Premium", "City", "City Premium", "Family Sport Premium", "Pony", "Muscle Premium", "Sport", "Hyper", "GT", "GT Premium"};
            Random rd = new Random();
            string[] elements = new string[13];
            elements[0] = Convert.ToString(rd.Next(Variables.minYear, Variables.maxYear));
            if (Variables.noBody)
            {
                elements[1] = " " + bodyMaterials[rd.Next(0, bodyMaterials.Length - 1)] + " body on ";
                elements[2] = chassisMaterial[rd.Next(0, marketType.Length - 1)] + " chassis";
            }
            else
            {
                elements[1] = String.Empty;
                elements[2] = String.Empty;
            }
            elements[3] = " "+bodyType[rd.Next(0, bodyType.Length - 1)] + "with ";
            if (Variables.noEngine)
            {
                elements[4] = enginePosition[rd.Next(0, enginePosition.Length - 1)] + " ";
                if (Variables.noEngineMaterials)
                {
                    elements[5] = engineBlock[rd.Next(0, engineBlock.Length - 1)] + " block and ";
                    elements[6] = engineTop[rd.Next(0, engineTop.Length - 1)]+ " head ";
                    if(Variables.noIntake)
                    {
                        elements[7] = " ";
                    }
                }
            }
            else
            {
                elements[4] = String.Empty;
                elements[5] = string.Empty;
                elements[6] = string.Empty;
                elements[7] = string.Empty;
            }
                if (Variables.noUtility)
            {
                elements[12]= marketType[rd.Next(15, marketType.Length - 1)];
            }
            else
            {
                elements[12] = marketType[rd.Next(0, marketType.Length - 1)];
            }
            string output = elements.ToString();    
            return output;
        }
    }
}