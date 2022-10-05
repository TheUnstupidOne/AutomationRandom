using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationRandom
{
    public class Generator
    {
       
        public static string GenerateEngine()
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
                position = Tech.GetRandomString(EngineData.enginePosition) + " ";
            }
            if (Variables.generateEngineMaterials)
            {
                block = Tech.GetRandomString(EngineData.engineBlock) + " block and ";
            }
            if (Variables.generateEngineIntake)
            {
                valves = Tech.GetRandomString(EngineData.engineIntakeType);
            }
            if (Variables.generateEngineMaterials)
            {
                head += Tech.GetRandomString(EngineData.engineTop);
            }
            if (Variables.generateEngineMaterials || Variables.generateEngineIntake)
            {
                head += " head ";
            }
            if (Variables.generateEngineTurbo)
            {
                turbo = Tech.GetRandomString(EngineData.engineTurbo);
            }
            if (Variables.generateEngineDisplacement)
            {
                displacement = GenerateDisplacement();
            }

            if (Variables.generateEngineFuel)
            {
                fuel = Tech.GetRandomString(EngineData.engineFuelType) + " powered ";
            }
            if (Variables.generateEngineLayout)
            {
                layout = Tech.GetRandomString(EngineData.engineLayout) + " ";
            }
            if (Variables.generateEngineType)
            {
                string engineType = Tech.GetRandomString(EngineData.engineType) + " ";
                if (engineType.Contains("Inline"))
                {
                    engineType += Tech.GetRandomString(EngineData.engineCylinderNumbers[0]);
                }
                else if (engineType.Contains("Boxer"))
                {
                    engineType += Tech.GetRandomString(EngineData.engineCylinderNumbers[3]);
                }
                else if (engineType.Contains("V"))
                {
                    string engineAngle = Tech.GetRandomString(EngineData.engineCylinderNumbers[5]);
                    if (engineAngle == EngineData.engineCylinderNumbers[5][0])
                    {
                        engineType += Tech.GetRandomString(EngineData.engineCylinderNumbers[2]) + " ";
                        engineType = engineAngle + engineType;
                    }
                    else
                    {
                        string crankType = Tech.GetRandomString(EngineData.engineCylinderNumbers[4]);
                        if (crankType == EngineData.engineCylinderNumbers[4][0])
                        {
                            crankType += "8 ";

                        }
                        else
                        {
                            crankType += Tech.GetRandomString(EngineData.engineCylinderNumbers[1]) + " ";
                        }
                        engineType = engineAngle + crankType + engineType;
                    }

                }
                output = position + block + valves + head + turbo + fuel + displacement + layout + engineType;
            }
            else
            {
                output = " engine ";
            }
            return output;
        }
        public static string GenerateDisplacement()
        {
            string output = string.Empty;
            if (Variables.displacementMode == 0)
            {
                output = Convert.ToString(Data.GenerateDisplacementNumeric(0, 2)) + " Liter ";
            }
            if (Variables.displacementMode == 1)
            {
                output = Convert.ToString(Data.GenerateDisplacementNumeric(2, 4)) + " Liter ";
            }
            if (Variables.displacementMode == 2)
            {
                output = Convert.ToString(Data.GenerateDisplacementNumeric(5, 8)) + " Liter ";
            }
            if (Variables.displacementMode == 3 && Variables.noStupid)
            {
                output = Convert.ToString(Data.GenerateDisplacementNumeric(1, 8)) + " Liter ";
            }
            else if (Variables.displacementMode == 3 && !Variables.noStupid)
            {
                output = Convert.ToString(Data.GenerateDisplacementNumeric(0, 21)) + " Liter ";
            }
            return output;
        }
        public static string GenerateDrivetrain()
        {
            string output = " with ";
            if (Variables.generateDrivetrainWheels)
            {
                output += Tech.GetRandomString(DrivetrainData.drivetrainWheelsType) + " drivetrain ";
            }
            if (Variables.generateDrivetrainGearbox)
            {
                output += Tech.GetRandomString(DrivetrainData.drivetrainGearboxType) + " gearbox ";
            }
            if (Variables.generateDrivetrainDiff)
            {
                output += Tech.GetRandomString(DrivetrainData.drivetrainDiffType) + " differential ";
            }
            if (Variables.generateDrivetrainTyreCompound)
            {
                output += Tech.GetRandomString(DrivetrainData.drivetrainTyreCompound) + " tyres ";
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
        public static string GenerateBody()
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
                bodyMaterials = Tech.GetRandomString(BodyData.bodyMaterials) + " body ";

            }
            if (Variables.generateBodyChassisMaterials || Variables.generateBodyChassisType)
            {
                bodyMaterials = bodyMaterials + "on ";
            }
            if (Variables.generateBodyChassisMaterials)
            {
                bodyChassisMaterials = Tech.GetRandomString(BodyData.bodyChassisMaterial) + " ";
            }
            if (Variables.generateBodyChassisType)
            {
                bodyChassisType = Tech.GetRandomString(BodyData.bodyChassisType);
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
                bodyType += Tech.GetRandomString(BodyData.bodyType);
            }
            if (Variables.generateBodySuspension)
            {
                suspensionFront += " with " + Tech.GetRandomString(BodyData.bodyFrontSuspensionType) + " in front ";
                suspensionRear += "and " + Tech.GetRandomString(BodyData.bodyRearSuspensionType) + " in the back";
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
        public static string GenerateMiscInfo()
        {
            string output = string.Empty;
            if (!Variables.noMarkets && Variables.noUtility)
            {
                output += Tech.GetRandomString(MiscData.marketTypeNoUtility);
            }
            else if (!Variables.noMarkets && !Variables.noUtility)
            {
                output += Tech.GetRandomString(MiscData.marketType);
            }
            else
            {
                output += " for any market";
            }
            if (!Variables.noCountries && Variables.generateRealCountries)
            {
                output += " in " + Tech.GetRandomString(MiscData.countryTypeReal);
            }
            else if (!Variables.noCountries && !Variables.generateRealCountries)
            {
                output += " in " + Tech.GetRandomString(MiscData.countryType);
            }
            else
            {
                output += " in any country";
            }
            return output;
        }
        public static string[] GenerateAdjectives()
        {
            string[] output = new string[2];
            string[] firstAdjData = new string[CarAdjectives.firstGeneric.Length + CarAdjectives.firstCheap.Length + CarAdjectives.firstUtility.Length + CarAdjectives.firstLuxury.Length];
            string[] secondAdjData = new string[CarAdjectives.secondGeneric.Length + CarAdjectives.secondCheap.Length + CarAdjectives.secondUtility.Length + CarAdjectives.secondLuxury.Length];
            CarAdjectives.firstGeneric.CopyTo(firstAdjData, 0);
            CarAdjectives.firstCheap.CopyTo(firstAdjData, CarAdjectives.firstGeneric.Length);
            CarAdjectives.firstLuxury.CopyTo(firstAdjData, CarAdjectives.firstGeneric.Length + CarAdjectives.firstCheap.Length);
            CarAdjectives.firstUtility.CopyTo(firstAdjData, CarAdjectives.firstGeneric.Length + CarAdjectives.firstCheap.Length + CarAdjectives.firstLuxury.Length);
            CarAdjectives.secondGeneric.CopyTo(secondAdjData, 0);
            CarAdjectives.secondCheap.CopyTo(secondAdjData, CarAdjectives.secondGeneric.Length);
            CarAdjectives.secondLuxury.CopyTo(secondAdjData, CarAdjectives.secondGeneric.Length + CarAdjectives.secondCheap.Length);
            CarAdjectives.secondUtility.CopyTo(secondAdjData, CarAdjectives.secondGeneric.Length + CarAdjectives.secondCheap.Length + CarAdjectives.secondLuxury.Length);
            output[0] = Tech.GetRandomString(firstAdjData);
            output[1] = Tech.GetRandomString(secondAdjData);
            return output;
        }
    }
}
