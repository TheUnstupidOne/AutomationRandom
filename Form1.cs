namespace AutomationRandom
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void folder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Variables.folderpath = folderBrowserDialog1.SelectedPath;
                textBox1.Text = Variables.folderpath + "\\AutomationIdeas.txt";
            }
        }
        private void minYear_Click(object sender, EventArgs e)
        {
            Variables.minYear = Convert.ToInt32(numericYearMinimum.Value);
        }
        private void maxYear_Click(object sender, EventArgs e)
        {
            Variables.maxYear = Convert.ToInt32(numericYearMaximum.Value);
        }
        private void Quantity_Click(object sender, EventArgs e)
        {
            Variables.quantity = Convert.ToInt32(numericQuantity.Value);
        }
        private void Displacement_Click(object sender, EventArgs e)
        {
            Variables.displacementMode = Convert.ToInt32(trackBarDisplacement.Value);
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            Program.GenerateFile(Variables.quantity);
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

        }
    }
    }