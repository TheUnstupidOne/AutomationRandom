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
            Variables.noCountries = checkCountries.Checked;
            Variables.noUtility = checkUtility.Checked;
            Variables.noEngine = checkEngine.Checked;
            Variables.noTurbo = checkTurbo.Checked;
            Variables.noBody = checkBody.Checked;
            Variables.noEngineMaterials = checkEngineMaterials.Checked;
            Variables.noIntake = checkIntake.Checked;
            Variables.noFuel = checkFuel.Checked;
            Variables.noGearbox = checkGearbox.Checked;
            Variables.noLSD = checkDiff.Checked;
            Variables.noEngineLayout = checkLayout.Checked;
            Variables.noMarkets = checkMarkets.Checked;
            Variables.noCountries = checkCountries.Checked;
            Variables.noEngineType = checkEngineType.Checked;

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
        private void Displacement_Click(object sender, EventArgs e)
        {
            Variables.displacementMode = Convert.ToInt32(trackBarDisplacement.Value);
            Variables.noDisplacement = checkDisplacement.Checked;
        }
        private void Utility_Check(object sender, EventArgs e)
        {
            Variables.noUtility = checkUtility.Checked;
        }
        private void Engine_Check(object sender, EventArgs e)
        {
            Variables.noEngine = checkEngine.Checked;
        }
        private void Turbo_Check(object sender, EventArgs e)
        {
            Variables.noTurbo = checkTurbo.Checked;
        }
        private void Body_Check(object sender, EventArgs e)
        {
            Variables.noBody = checkBody.Checked;
        }
        private void EgineMaterial_Check(object sender, EventArgs e)
        {
            Variables.noEngineMaterials = checkEngineMaterials.Checked;
        }
        private void Intake_Check(object sender, EventArgs e)
        {
            Variables.noIntake = checkIntake.Checked;
        }
        private void Fuel_Check(object sender, EventArgs e)
        {
            Variables.noFuel = checkFuel.Checked;
        }
        private void Gearbox_Check(object sender, EventArgs e)
        {
            Variables.noGearbox = checkGearbox.Checked;
        }
        private void LSD_Check(object sender, EventArgs e)
        {
            Variables.noLSD = checkDiff.Checked;
        }
        private void Layout_Check(object sender, EventArgs e)
        {
            Variables.noEngineLayout = checkLayout.Checked;
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
            Variables.noEngineType = checkEngineType.Checked;
        }

        public class Variables
        {
            static public string folderpath;
            static public int minYear;
            static public int maxYear;
            static public int quantity;
            static public int displacementMode;
            static public bool noUtility;
            static public bool noEngine;
            static public bool noTurbo;
            static public bool noBody;
            static public bool noEngineMaterials;
            static public bool noIntake;
            static public int year;
            static public bool noDisplacement;
            static public bool noFuel;
            static public bool noGearbox;
            static public bool noLSD;
            static public bool noEngineLayout;
            static public bool noMarkets;
            static public bool noCountries;
            static public bool noEngineType;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }