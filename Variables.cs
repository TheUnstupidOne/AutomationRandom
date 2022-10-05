using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationRandom
{
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
        public static string[] drivetrainWheelsTypeInspiration = { "four-wheel drive", "front-wheel drive", "all-wheel drive", "rear-wheel drive" };
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
            "United States", "Sweden", "Indonesia", "India", "East Germany"};
        public static string[] dateVague = {"Late 1940s ", "Early 1950s ", "Mid-1950s ", "Late 1950s ", "Early 1960s ", "Mid-1960s ",
            "Late 1960s ", "Early 1970s ", "Mid-1970s ", "Late 1970s ",  "Early 1980s ", "Mid-1980s ", "Late 1980s ",
            "Early 1990s ", "Mid-1990s ", "Late 1990s ", "Early 2000s ", "Mid-2000s ", "Late 2000s ", "Early 2010s ", "Mid-2010s ", "Late 2010s ",};
        public static string[] genericSize = { "Tiny", "Small", "Compact", "Medium", "Big", "Large", "Extra-large" };
        public static string[][][] carAdjectives = {
            new string[][] {
                new string[]{},
                new string[]{ } },
            new string[][] { 
            }
        };
    }
    public static class CarAdjectives
    {
        public static string[] firstLuxury = { "top-dollar", "top-level", "ultimate", "ultra", "unparalleled", "vintage",  "classic",
            "custom-built", "custom-designed", "customized", "distinctive",  "super",  };
        public static string[] firstGeneric = {"advanced",  "carefully tuned", "versatile",   "futuristic",
            "progressive", "quick-shifting", "effective", "elegant", "thoroughly engineered",
            "entertaining", "flashy", "overengineered",
            "ergonomically designed",   "fast", "speedy",   };
        public static string[] firstCheap = { "affordable", "throwaway", "standard", "cheap", "barebones" };
        public static string[] firstUtility = { "dependable", "reliable", "sturdy", "extreme", };
        public static string[] secondLuxury = { "noteworthy", "performance-inspired", "loaded", "luxurious", "luxury", "expensive", };
        public static string[] secondGeneric = {"safe", "agile",  "powerful", "functional",
            "high-agility", "innovative", "low-emission", "dynamic",
            "nimble", "lightweight", "easy-to-drive",
            "environmentally friendly", "family friendly","flex-fuel",
            "sleek", "stylish","sporty",  "cute", "prestigious" };
        public static string[] secondCheap = { "rustbucket", "beater", "low maintenance", "economical", "sluggish", };
        public static string[] secondUtility = { "heavy", "heavy duty",
            "utilitarian",  "reinforced", "landyacht",};
    }
    public class Variables
    {
        static public string folderpath;
        static public int minYear;
        static public int maxYear;
        static public int quantity;

        static public bool noUtility;

        static public bool doInspirationMode;

        static public int year;



        static public bool noMarkets;
        static public bool noCountries;
        static public bool generateRealCountries;

        static public bool noStupid;
        //emgine stuff (finished)
        static public bool generateEngineType;
        static public bool generateEngine;
        static public bool generateEngineLayout;
        static public bool generateEngineDisplacement;
        static public bool generateEngineFuel;
        static public bool generateEngineMaterials;
        static public bool generateEngineIntake;
        static public bool generateEnginePosition;
        static public bool generateEngineTurbo;
        static public int displacementMode;
        //drivetrain stuff (finished for now)
        static public bool generateDrivetrainData;
        static public bool generateDrivetrainGearbox;
        static public bool generateDrivetrainDiff;
        static public bool generateDrivetrainTyreCompound;
        static public bool generateDrivetrainWheels;
        //body stuff
        static public bool generateBody;
        static public bool generateBodyMaterials;
        static public bool generateBodyChassisType;
        static public bool generateBodyChassisMaterials;
        static public bool generateBodyType;
        static public bool generateBodySuspension;
    }
}
