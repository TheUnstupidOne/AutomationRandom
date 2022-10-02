namespace AutomationRandom
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Variables.minYear = Convert.ToInt32(Convert.ToDouble(numericYearMinimum.Value));
            Variables.maxYear = Convert.ToInt32(Convert.ToDouble(numericYearMaximum.Value));
            Variables.quantity = Convert.ToInt32(numericQuantity.Value);
            Variables.displacementMode = Convert.ToInt32(trackBarDisplacement.Value);
            Variables.generateEngineType = checkEngineType.Checked;
            Variables.generateEngineDisplacement = checkEngineDisplacement.Checked;
            Variables.generateEngineLayout = checkEngineLayout.Checked;
            Variables.generateEngineMaterials = checkEngineMaterials.Checked;
            Variables.generateEngineIntake = checkEngineIntake.Checked;
            Variables.generateEngineFuel = checkEngineFuel.Checked;
            Variables.generateEnginePosition = checkEnginePosition.Checked;
            Variables.generateEngineTurbo = checkEngineTurbo.Checked;
            Variables.generateBodyMaterials = checkBodyMaterials.Checked;
            checkEngineGenerate.CheckState = CheckState.Checked;
            checkEngineGenerate.CheckState = CheckState.Unchecked;
            checkDrivetrainData.CheckState = CheckState.Checked;
            checkDrivetrainData.CheckState = CheckState.Unchecked;
            checkBody.CheckState = CheckState.Checked;
            checkBody.CheckState = CheckState.Unchecked;
            Variables.noUtility = checkUtility.Checked;
            Variables.noMarkets = checkMarkets.Checked;
            Variables.noCountries = checkCountries.Checked;
            


        }
        private void folder_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Variables.folderpath = saveFileDialog1.FileName;
                Program.GenerateFile(Variables.quantity, Variables.folderpath);
            }
        }
        private void minYear_Click(object sender, EventArgs e)
        {
            Variables.minYear = Convert.ToInt32(Convert.ToDouble(numericYearMinimum.Value));
            while (numericYearMinimum.Value > numericYearMaximum.Value)
            {
                numericYearMaximum.Value++;
            }

        }
        private void maxYear_Click(object sender, EventArgs e)
        {
            Variables.maxYear = Convert.ToInt32(Convert.ToDouble(numericYearMaximum.Value));
            while (numericYearMaximum.Value < numericYearMinimum.Value)
            {
                numericYearMinimum.Value--;
            }
        }
        private void Quantity_Click(object sender, EventArgs e)
        {
            Variables.quantity = Convert.ToInt32(numericQuantity.Value);
        }
        private void EngineDisplacement_Click(object sender, EventArgs e)
        {
            Variables.displacementMode = Convert.ToInt32(trackBarDisplacement.Value);
            Variables.generateEngineDisplacement = checkEngineDisplacement.Checked;
        }
        private void Utility_Check(object sender, EventArgs e)
        {
            Variables.noUtility = checkUtility.Checked;
        }
        private void EnginePosition_Check(object sender, EventArgs e)
        {
            Variables.generateEnginePosition = checkEnginePosition.Checked;
        }
        private void EngineTurbo_Check(object sender, EventArgs e)
        {
            Variables.generateEngineTurbo = checkEngineTurbo.Checked;
        }
        private void EgineMaterial_Check(object sender, EventArgs e)
        {
            Variables.generateEngineMaterials = checkEngineMaterials.Checked;
        }
        private void EngineIntake_Check(object sender, EventArgs e)
        {
            Variables.generateEngineIntake = checkEngineIntake.Checked;
        }
        private void EngineFuel_Check(object sender, EventArgs e)
        {
            Variables.generateEngineFuel = checkEngineFuel.Checked;
        }
        private void DrivetrainGearbox_Check(object sender, EventArgs e)
        {
            Variables.generateDrivetrainGearbox = checkDrivetrainGearbox.Checked;
        }
        private void DrivetrainDiff_Check(object sender, EventArgs e)
        {
            Variables.generateDrivetrainDiff = checkDrivetrainDiff.Checked;
        }
        private void EngineLayout_Check(object sender, EventArgs e)
        {
            Variables.generateEngineLayout = checkEngineLayout.Checked;
        }
        private void Markets_Check(object sender, EventArgs e)
        {
            Variables.noMarkets = checkMarkets.Checked;
        }
        private void Countries_Check(object sender, EventArgs e)
        {
            Variables.noCountries = checkCountries.Checked;
        }
        private void EngineType_Check(object sender, EventArgs e)
        {
            Variables.generateEngineType = checkEngineType.Checked;
        }
        private void Stupid_Check(object sender, EventArgs e)
        {
            Variables.noStupid = checkStupid.Checked;
        }
        private void EngineGeneration_Check(object sender, EventArgs e)
        {
            Variables.generateEngine = checkEngineGenerate.Checked;
            //getting secondary variables
            Variables.generateEngineType = checkEngineType.Checked;
            Variables.generateEngineDisplacement = checkEngineDisplacement.Checked;
            Variables.generateEngineLayout = checkEngineLayout.Checked;
            Variables.generateEngineMaterials = checkEngineMaterials.Checked;
            Variables.generateEngineIntake = checkEngineIntake.Checked;
            Variables.generateEngineFuel = checkEngineFuel.Checked;
            Variables.generateEnginePosition = checkEnginePosition.Checked;
            Variables.generateEngineTurbo = checkEngineTurbo.Checked;
            if (Variables.generateEngine)
            {
                checkEngineMaterials.Enabled = true;
                checkEnginePosition.Enabled = true;
                checkEngineType.Enabled = true;
                checkEngineIntake.Enabled = true;
                checkEngineLayout.Enabled = true;
                checkEngineTurbo.Enabled = true;
                checkEngineFuel.Enabled = true;
                checkEngineDisplacement.Enabled = true;
            }
            if (!Variables.generateEngine)
            {
                checkEngineMaterials.Enabled = false;
                checkEnginePosition.Enabled = false;
                checkEngineType.Enabled = false;
                checkEngineIntake.Enabled = false;
                checkEngineLayout.Enabled = false;
                checkEngineTurbo.Enabled = false;
                checkEngineFuel.Enabled = false;
                checkEngineDisplacement.Enabled = false;
            }
        }
        private void DrivetrainGeneration_Check(object sender, EventArgs e)
        {
            Variables.generateDrivetrainData = checkDrivetrainData.Checked;
            //getting secondary variables
            Variables.generateDrivetrainGearbox = checkDrivetrainGearbox.Checked;
            Variables.generateDrivetrainWheels = checkDrivetrainWheels.Checked;
            Variables.generateDrivetrainDiff = checkDrivetrainDiff.Checked;
            Variables.generateDrivetrainTyreCompound = checkDrivetrainTyreCompound.Checked;
            if (Variables.generateDrivetrainData)
            {
                checkDrivetrainDiff.Enabled = true;
                checkDrivetrainGearbox.Enabled = true;
                checkDrivetrainTyreCompound.Enabled = true;
                checkDrivetrainWheels.Enabled = true;
            }
            if (!Variables.generateDrivetrainData)
            {
                checkDrivetrainDiff.Enabled = false;
                checkDrivetrainGearbox.Enabled = false;
                checkDrivetrainTyreCompound.Enabled = false;
                checkDrivetrainWheels.Enabled = false;
            }
        }
        private void BodyGeneration_Check(object sender, EventArgs e)
        {
            Variables.generateBody = checkBody.Checked;
            //getting secondary variables
            Variables.generateBodyMaterials = checkBodyMaterials.Checked;
            Variables.generateBodyChassisMaterials = checkBodyMaterials.Checked;
            Variables.generateBodyChassisMaterials = checkBodyChassisMaterials.Checked;
            Variables.generateBodyChassisType = checkBodyChassisType.Checked;
            Variables.generateBodyType = checkBodyType.Checked;
            Variables.generateBodySuspension = checkBodySuspension.Checked;
            if (Variables.generateBody)
            {
                checkBodyMaterials.Enabled = true;
                checkBodyChassisMaterials.Enabled = true;
                checkBodyChassisType.Enabled = true;
                checkBodySuspension.Enabled = true;
                checkBodyType.Enabled = true;
            }
            if (!Variables.generateBody)
            {
                checkBodyMaterials.Enabled = false;
                checkBodyChassisMaterials.Enabled = false;
                checkBodyChassisType.Enabled = false;
                checkBodySuspension.Enabled = false;
                checkBodyType.Enabled = false;
            }
        }
        private void BodyType_Check(object sender, EventArgs e)
        {
            Variables.generateBodyType = checkBodyType.Checked;
        }
        private void BodyChassisType_Check(object sender, EventArgs e)
        {
            Variables.generateBodyChassisType = checkBodyChassisType.Checked;
        }
        private void BodyMaterials_Check(object sender, EventArgs e)
        {
            Variables.generateBodyMaterials = checkBodyMaterials.Checked;
        }
        private void BodyChassisMaterials_Check(object sender, EventArgs e)
        {
            Variables.generateBodyChassisMaterials = checkBodyChassisMaterials.Checked;
        }
        private void BodySuspension_Check(object sender, EventArgs e)
        {
            Variables.generateBodySuspension = checkBodySuspension.Checked;
        }
        private void RealCountries_Check(object sender, EventArgs e)
        {
            Variables.generateRealCountries = checkCountriesReal.Checked;
        }

    }
    public class Variables
    {
        static public string folderpath;
        static public int minYear;
        static public int maxYear;
        static public int quantity;

        static public bool noUtility;

        

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
    