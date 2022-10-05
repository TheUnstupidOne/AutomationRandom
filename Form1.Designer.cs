namespace AutomationRandom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkEngineTurbo = new System.Windows.Forms.CheckBox();
            this.checkEnginePosition = new System.Windows.Forms.CheckBox();
            this.checkEngineFuel = new System.Windows.Forms.CheckBox();
            this.checkStupid = new System.Windows.Forms.CheckBox();
            this.checkUtility = new System.Windows.Forms.CheckBox();
            this.checkDrivetrainGearbox = new System.Windows.Forms.CheckBox();
            this.checkDrivetrainDiff = new System.Windows.Forms.CheckBox();
            this.checkBody = new System.Windows.Forms.CheckBox();
            this.checkMarkets = new System.Windows.Forms.CheckBox();
            this.checkCountries = new System.Windows.Forms.CheckBox();
            this.checkEngineDisplacement = new System.Windows.Forms.CheckBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.numericYearMinimum = new System.Windows.Forms.NumericUpDown();
            this.numericYearMaximum = new System.Windows.Forms.NumericUpDown();
            this.trackBarDisplacement = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkCountriesReal = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkEngineMaterials = new System.Windows.Forms.CheckBox();
            this.checkEngineIntake = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkEngineLayout = new System.Windows.Forms.CheckBox();
            this.checkEngineType = new System.Windows.Forms.CheckBox();
            this.checkEngineGenerate = new System.Windows.Forms.CheckBox();
            this.checkDrivetrainData = new System.Windows.Forms.CheckBox();
            this.checkDrivetrainWheels = new System.Windows.Forms.CheckBox();
            this.checkDrivetrainTyreCompound = new System.Windows.Forms.CheckBox();
            this.checkBodyType = new System.Windows.Forms.CheckBox();
            this.checkBodyChassisType = new System.Windows.Forms.CheckBox();
            this.checkBodyMaterials = new System.Windows.Forms.CheckBox();
            this.checkBodyChassisMaterials = new System.Windows.Forms.CheckBox();
            this.checkBodySuspension = new System.Windows.Forms.CheckBox();
            this.checkInspirationMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDisplacement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEngineTurbo
            // 
            this.checkEngineTurbo.AutoSize = true;
            this.checkEngineTurbo.Checked = true;
            this.checkEngineTurbo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEngineTurbo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEngineTurbo.Location = new System.Drawing.Point(739, 233);
            this.checkEngineTurbo.Name = "checkEngineTurbo";
            this.checkEngineTurbo.Size = new System.Drawing.Size(148, 24);
            this.checkEngineTurbo.TabIndex = 0;
            this.checkEngineTurbo.Text = "Include Aspiration";
            this.checkEngineTurbo.UseVisualStyleBackColor = true;
            this.checkEngineTurbo.CheckedChanged += new System.EventHandler(this.EngineTurbo_Check);
            // 
            // checkEnginePosition
            // 
            this.checkEnginePosition.AutoSize = true;
            this.checkEnginePosition.Checked = true;
            this.checkEnginePosition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEnginePosition.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEnginePosition.Location = new System.Drawing.Point(737, 140);
            this.checkEnginePosition.Name = "checkEnginePosition";
            this.checkEnginePosition.Size = new System.Drawing.Size(183, 24);
            this.checkEnginePosition.TabIndex = 1;
            this.checkEnginePosition.Text = "Include Engine position";
            this.checkEnginePosition.UseVisualStyleBackColor = true;
            this.checkEnginePosition.CheckedChanged += new System.EventHandler(this.EnginePosition_Check);
            // 
            // checkEngineFuel
            // 
            this.checkEngineFuel.AutoSize = true;
            this.checkEngineFuel.Checked = true;
            this.checkEngineFuel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEngineFuel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEngineFuel.Location = new System.Drawing.Point(739, 203);
            this.checkEngineFuel.Name = "checkEngineFuel";
            this.checkEngineFuel.Size = new System.Drawing.Size(107, 24);
            this.checkEngineFuel.TabIndex = 2;
            this.checkEngineFuel.Text = "Include Fuel";
            this.checkEngineFuel.UseVisualStyleBackColor = true;
            this.checkEngineFuel.CheckedChanged += new System.EventHandler(this.EngineFuel_Check);
            // 
            // checkStupid
            // 
            this.checkStupid.AutoSize = true;
            this.checkStupid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkStupid.Location = new System.Drawing.Point(9, 323);
            this.checkStupid.Name = "checkStupid";
            this.checkStupid.Size = new System.Drawing.Size(177, 24);
            this.checkStupid.TabIndex = 3;
            this.checkStupid.Text = "Disable Stupid configs";
            this.checkStupid.UseVisualStyleBackColor = true;
            this.checkStupid.CheckedChanged += new System.EventHandler(this.Stupid_Check);
            // 
            // checkUtility
            // 
            this.checkUtility.AutoSize = true;
            this.checkUtility.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkUtility.Location = new System.Drawing.Point(12, 145);
            this.checkUtility.Name = "checkUtility";
            this.checkUtility.Size = new System.Drawing.Size(122, 24);
            this.checkUtility.TabIndex = 4;
            this.checkUtility.Text = "Exclude Utility";
            this.checkUtility.UseVisualStyleBackColor = true;
            this.checkUtility.CheckedChanged += new System.EventHandler(this.Utility_Check);
            // 
            // checkDrivetrainGearbox
            // 
            this.checkDrivetrainGearbox.AutoSize = true;
            this.checkDrivetrainGearbox.Checked = true;
            this.checkDrivetrainGearbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDrivetrainGearbox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDrivetrainGearbox.Location = new System.Drawing.Point(497, 200);
            this.checkDrivetrainGearbox.Name = "checkDrivetrainGearbox";
            this.checkDrivetrainGearbox.Size = new System.Drawing.Size(136, 24);
            this.checkDrivetrainGearbox.TabIndex = 5;
            this.checkDrivetrainGearbox.Text = "Include Gearbox";
            this.checkDrivetrainGearbox.UseVisualStyleBackColor = true;
            this.checkDrivetrainGearbox.CheckedChanged += new System.EventHandler(this.DrivetrainGearbox_Check);
            // 
            // checkDrivetrainDiff
            // 
            this.checkDrivetrainDiff.AutoSize = true;
            this.checkDrivetrainDiff.Checked = true;
            this.checkDrivetrainDiff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDrivetrainDiff.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDrivetrainDiff.Location = new System.Drawing.Point(497, 170);
            this.checkDrivetrainDiff.Name = "checkDrivetrainDiff";
            this.checkDrivetrainDiff.Size = new System.Drawing.Size(155, 24);
            this.checkDrivetrainDiff.TabIndex = 6;
            this.checkDrivetrainDiff.Text = "Include Differential";
            this.checkDrivetrainDiff.UseVisualStyleBackColor = true;
            this.checkDrivetrainDiff.CheckedChanged += new System.EventHandler(this.DrivetrainDiff_Check);
            // 
            // checkBody
            // 
            this.checkBody.AutoSize = true;
            this.checkBody.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBody.Location = new System.Drawing.Point(255, 113);
            this.checkBody.Name = "checkBody";
            this.checkBody.Size = new System.Drawing.Size(162, 24);
            this.checkBody.TabIndex = 7;
            this.checkBody.Text = "Generate Body Data";
            this.checkBody.UseVisualStyleBackColor = true;
            this.checkBody.CheckedChanged += new System.EventHandler(this.BodyGeneration_Check);
            this.checkBody.CheckStateChanged += new System.EventHandler(this.BodyGeneration_Check);
            // 
            // checkMarkets
            // 
            this.checkMarkets.AutoSize = true;
            this.checkMarkets.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkMarkets.Location = new System.Drawing.Point(9, 208);
            this.checkMarkets.Name = "checkMarkets";
            this.checkMarkets.Size = new System.Drawing.Size(135, 24);
            this.checkMarkets.TabIndex = 8;
            this.checkMarkets.Text = "Exclude Markets";
            this.checkMarkets.UseVisualStyleBackColor = true;
            this.checkMarkets.CheckedChanged += new System.EventHandler(this.Markets_Check);
            // 
            // checkCountries
            // 
            this.checkCountries.AutoSize = true;
            this.checkCountries.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkCountries.Location = new System.Drawing.Point(9, 178);
            this.checkCountries.Name = "checkCountries";
            this.checkCountries.Size = new System.Drawing.Size(145, 24);
            this.checkCountries.TabIndex = 9;
            this.checkCountries.Text = "Exclude Countries";
            this.checkCountries.UseVisualStyleBackColor = true;
            this.checkCountries.CheckedChanged += new System.EventHandler(this.Countries_Check);
            // 
            // checkEngineDisplacement
            // 
            this.checkEngineDisplacement.AutoSize = true;
            this.checkEngineDisplacement.Checked = true;
            this.checkEngineDisplacement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEngineDisplacement.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEngineDisplacement.Location = new System.Drawing.Point(739, 173);
            this.checkEngineDisplacement.Name = "checkEngineDisplacement";
            this.checkEngineDisplacement.Size = new System.Drawing.Size(171, 24);
            this.checkEngineDisplacement.TabIndex = 10;
            this.checkEngineDisplacement.Text = "Include Displacement";
            this.checkEngineDisplacement.UseVisualStyleBackColor = true;
            this.checkEngineDisplacement.CheckedChanged += new System.EventHandler(this.EngineDisplacement_Click);
            this.checkEngineDisplacement.Click += new System.EventHandler(this.EngineDisplacement_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.Location = new System.Drawing.Point(892, 383);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(117, 35);
            this.buttonGenerate.TabIndex = 11;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.folder_Click);
            // 
            // numericYearMinimum
            // 
            this.numericYearMinimum.AccessibleName = "Minimum Year";
            this.numericYearMinimum.Location = new System.Drawing.Point(12, 32);
            this.numericYearMinimum.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericYearMinimum.Minimum = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            this.numericYearMinimum.Name = "numericYearMinimum";
            this.numericYearMinimum.Size = new System.Drawing.Size(120, 23);
            this.numericYearMinimum.TabIndex = 12;
            this.numericYearMinimum.Tag = "";
            this.numericYearMinimum.Value = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            this.numericYearMinimum.ValueChanged += new System.EventHandler(this.minYear_Click);
            // 
            // numericYearMaximum
            // 
            this.numericYearMaximum.Location = new System.Drawing.Point(9, 81);
            this.numericYearMaximum.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericYearMaximum.Minimum = new decimal(new int[] {
            1941,
            0,
            0,
            0});
            this.numericYearMaximum.Name = "numericYearMaximum";
            this.numericYearMaximum.Size = new System.Drawing.Size(120, 23);
            this.numericYearMaximum.TabIndex = 13;
            this.numericYearMaximum.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericYearMaximum.ValueChanged += new System.EventHandler(this.maxYear_Click);
            this.numericYearMaximum.Click += new System.EventHandler(this.maxYear_Click);
            // 
            // trackBarDisplacement
            // 
            this.trackBarDisplacement.LargeChange = 1;
            this.trackBarDisplacement.Location = new System.Drawing.Point(255, 33);
            this.trackBarDisplacement.Maximum = 3;
            this.trackBarDisplacement.Name = "trackBarDisplacement";
            this.trackBarDisplacement.Size = new System.Drawing.Size(179, 45);
            this.trackBarDisplacement.TabIndex = 14;
            this.trackBarDisplacement.ValueChanged += new System.EventHandler(this.EngineDisplacement_Click);
            this.trackBarDisplacement.MouseCaptureChanged += new System.EventHandler(this.EngineDisplacement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Small";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Medium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Large";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "All";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Minimum Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Maximum Year";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(497, 33);
            this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(120, 23);
            this.numericQuantity.TabIndex = 21;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.ValueChanged += new System.EventHandler(this.Quantity_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(255, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Engine Displacement Mode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(497, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Idea quantity";
            // 
            // checkCountriesReal
            // 
            this.checkCountriesReal.AutoSize = true;
            this.checkCountriesReal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkCountriesReal.Location = new System.Drawing.Point(9, 353);
            this.checkCountriesReal.Name = "checkCountriesReal";
            this.checkCountriesReal.Size = new System.Drawing.Size(151, 24);
            this.checkCountriesReal.TabIndex = 26;
            this.checkCountriesReal.Text = "Use Real Countries";
            this.checkCountriesReal.UseVisualStyleBackColor = true;
            this.checkCountriesReal.CheckedChanged += new System.EventHandler(this.RealCountries_Check);
            this.checkCountriesReal.CheckStateChanged += new System.EventHandler(this.RealCountries_Check);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Temporarily unavailable feature";
            // 
            // checkEngineMaterials
            // 
            this.checkEngineMaterials.AutoSize = true;
            this.checkEngineMaterials.Checked = true;
            this.checkEngineMaterials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEngineMaterials.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEngineMaterials.Location = new System.Drawing.Point(739, 263);
            this.checkEngineMaterials.Name = "checkEngineMaterials";
            this.checkEngineMaterials.Size = new System.Drawing.Size(190, 24);
            this.checkEngineMaterials.TabIndex = 28;
            this.checkEngineMaterials.Text = "Include Engine Materials";
            this.checkEngineMaterials.UseVisualStyleBackColor = true;
            this.checkEngineMaterials.CheckedChanged += new System.EventHandler(this.EgineMaterial_Check);
            this.checkEngineMaterials.CheckStateChanged += new System.EventHandler(this.EgineMaterial_Check);
            // 
            // checkEngineIntake
            // 
            this.checkEngineIntake.AutoSize = true;
            this.checkEngineIntake.Checked = true;
            this.checkEngineIntake.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEngineIntake.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEngineIntake.Location = new System.Drawing.Point(739, 293);
            this.checkEngineIntake.Name = "checkEngineIntake";
            this.checkEngineIntake.Size = new System.Drawing.Size(270, 24);
            this.checkEngineIntake.TabIndex = 29;
            this.checkEngineIntake.Text = "Include Engine Head Randomization";
            this.checkEngineIntake.UseVisualStyleBackColor = true;
            this.checkEngineIntake.CheckedChanged += new System.EventHandler(this.EngineIntake_Check);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "AutomationIdeas";
            // 
            // checkEngineLayout
            // 
            this.checkEngineLayout.AutoSize = true;
            this.checkEngineLayout.Checked = true;
            this.checkEngineLayout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEngineLayout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEngineLayout.Location = new System.Drawing.Point(737, 323);
            this.checkEngineLayout.Name = "checkEngineLayout";
            this.checkEngineLayout.Size = new System.Drawing.Size(173, 24);
            this.checkEngineLayout.TabIndex = 31;
            this.checkEngineLayout.Text = "Include Engine Layout";
            this.checkEngineLayout.UseVisualStyleBackColor = true;
            this.checkEngineLayout.CheckedChanged += new System.EventHandler(this.EngineLayout_Check);
            // 
            // checkEngineType
            // 
            this.checkEngineType.AutoSize = true;
            this.checkEngineType.Checked = true;
            this.checkEngineType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEngineType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEngineType.Location = new System.Drawing.Point(737, 353);
            this.checkEngineType.Name = "checkEngineType";
            this.checkEngineType.Size = new System.Drawing.Size(160, 24);
            this.checkEngineType.TabIndex = 32;
            this.checkEngineType.Text = "Include Engine Type";
            this.checkEngineType.UseVisualStyleBackColor = true;
            this.checkEngineType.CheckedChanged += new System.EventHandler(this.EngineType_Check);
            // 
            // checkEngineGenerate
            // 
            this.checkEngineGenerate.AutoSize = true;
            this.checkEngineGenerate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEngineGenerate.Location = new System.Drawing.Point(737, 113);
            this.checkEngineGenerate.Name = "checkEngineGenerate";
            this.checkEngineGenerate.Size = new System.Drawing.Size(173, 24);
            this.checkEngineGenerate.TabIndex = 33;
            this.checkEngineGenerate.Text = "Generate Engine Data";
            this.checkEngineGenerate.UseVisualStyleBackColor = true;
            this.checkEngineGenerate.CheckedChanged += new System.EventHandler(this.EngineGeneration_Check);
            this.checkEngineGenerate.CheckStateChanged += new System.EventHandler(this.EngineGeneration_Check);
            // 
            // checkDrivetrainData
            // 
            this.checkDrivetrainData.AutoSize = true;
            this.checkDrivetrainData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDrivetrainData.Location = new System.Drawing.Point(497, 113);
            this.checkDrivetrainData.Name = "checkDrivetrainData";
            this.checkDrivetrainData.Size = new System.Drawing.Size(193, 24);
            this.checkDrivetrainData.TabIndex = 34;
            this.checkDrivetrainData.Text = "Generate Drivetrain Data";
            this.checkDrivetrainData.UseVisualStyleBackColor = true;
            this.checkDrivetrainData.CheckedChanged += new System.EventHandler(this.DrivetrainGeneration_Check);
            this.checkDrivetrainData.CheckStateChanged += new System.EventHandler(this.DrivetrainGeneration_Check);
            // 
            // checkDrivetrainWheels
            // 
            this.checkDrivetrainWheels.AutoSize = true;
            this.checkDrivetrainWheels.Checked = true;
            this.checkDrivetrainWheels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDrivetrainWheels.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDrivetrainWheels.Location = new System.Drawing.Point(497, 140);
            this.checkDrivetrainWheels.Name = "checkDrivetrainWheels";
            this.checkDrivetrainWheels.Size = new System.Drawing.Size(192, 24);
            this.checkDrivetrainWheels.TabIndex = 35;
            this.checkDrivetrainWheels.Text = "Generate Driving Wheels";
            this.checkDrivetrainWheels.UseVisualStyleBackColor = true;
            // 
            // checkDrivetrainTyreCompound
            // 
            this.checkDrivetrainTyreCompound.AutoSize = true;
            this.checkDrivetrainTyreCompound.Checked = true;
            this.checkDrivetrainTyreCompound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDrivetrainTyreCompound.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDrivetrainTyreCompound.Location = new System.Drawing.Point(497, 230);
            this.checkDrivetrainTyreCompound.Name = "checkDrivetrainTyreCompound";
            this.checkDrivetrainTyreCompound.Size = new System.Drawing.Size(197, 24);
            this.checkDrivetrainTyreCompound.TabIndex = 36;
            this.checkDrivetrainTyreCompound.Text = "Generate Tyre Compound";
            this.checkDrivetrainTyreCompound.UseVisualStyleBackColor = true;
            // 
            // checkBodyType
            // 
            this.checkBodyType.AutoSize = true;
            this.checkBodyType.Checked = true;
            this.checkBodyType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBodyType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBodyType.Location = new System.Drawing.Point(255, 145);
            this.checkBodyType.Name = "checkBodyType";
            this.checkBodyType.Size = new System.Drawing.Size(149, 24);
            this.checkBodyType.TabIndex = 37;
            this.checkBodyType.Text = "Include Body Type";
            this.checkBodyType.UseVisualStyleBackColor = true;
            this.checkBodyType.CheckedChanged += new System.EventHandler(this.BodyType_Check);
            // 
            // checkBodyChassisType
            // 
            this.checkBodyChassisType.AutoSize = true;
            this.checkBodyChassisType.Checked = true;
            this.checkBodyChassisType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBodyChassisType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBodyChassisType.Location = new System.Drawing.Point(255, 178);
            this.checkBodyChassisType.Name = "checkBodyChassisType";
            this.checkBodyChassisType.Size = new System.Drawing.Size(162, 24);
            this.checkBodyChassisType.TabIndex = 38;
            this.checkBodyChassisType.Text = "Include Chassis Type";
            this.checkBodyChassisType.UseVisualStyleBackColor = true;
            this.checkBodyChassisType.CheckedChanged += new System.EventHandler(this.BodyChassisType_Check);
            // 
            // checkBodyMaterials
            // 
            this.checkBodyMaterials.AutoSize = true;
            this.checkBodyMaterials.Checked = true;
            this.checkBodyMaterials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBodyMaterials.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBodyMaterials.Location = new System.Drawing.Point(255, 208);
            this.checkBodyMaterials.Name = "checkBodyMaterials";
            this.checkBodyMaterials.Size = new System.Drawing.Size(179, 24);
            this.checkBodyMaterials.TabIndex = 39;
            this.checkBodyMaterials.Text = "Include Body Materials";
            this.checkBodyMaterials.UseVisualStyleBackColor = true;
            this.checkBodyMaterials.CheckedChanged += new System.EventHandler(this.BodyMaterials_Check);
            // 
            // checkBodyChassisMaterials
            // 
            this.checkBodyChassisMaterials.AutoSize = true;
            this.checkBodyChassisMaterials.Checked = true;
            this.checkBodyChassisMaterials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBodyChassisMaterials.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBodyChassisMaterials.Location = new System.Drawing.Point(255, 238);
            this.checkBodyChassisMaterials.Name = "checkBodyChassisMaterials";
            this.checkBodyChassisMaterials.Size = new System.Drawing.Size(192, 24);
            this.checkBodyChassisMaterials.TabIndex = 40;
            this.checkBodyChassisMaterials.Text = "Include Chassis Materials";
            this.checkBodyChassisMaterials.UseVisualStyleBackColor = true;
            this.checkBodyChassisMaterials.CheckedChanged += new System.EventHandler(this.BodyChassisMaterials_Check);
            this.checkBodyChassisMaterials.CheckStateChanged += new System.EventHandler(this.BodyChassisMaterials_Check);
            // 
            // checkBodySuspension
            // 
            this.checkBodySuspension.AutoSize = true;
            this.checkBodySuspension.Checked = true;
            this.checkBodySuspension.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBodySuspension.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBodySuspension.Location = new System.Drawing.Point(255, 268);
            this.checkBodySuspension.Name = "checkBodySuspension";
            this.checkBodySuspension.Size = new System.Drawing.Size(154, 24);
            this.checkBodySuspension.TabIndex = 41;
            this.checkBodySuspension.Text = "Include Suspension";
            this.checkBodySuspension.UseVisualStyleBackColor = true;
            this.checkBodySuspension.CheckedChanged += new System.EventHandler(this.BodySuspension_Check);
            // 
            // checkInspirationMode
            // 
            this.checkInspirationMode.AutoSize = true;
            this.checkInspirationMode.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkInspirationMode.Location = new System.Drawing.Point(12, 108);
            this.checkInspirationMode.Name = "checkInspirationMode";
            this.checkInspirationMode.Size = new System.Drawing.Size(174, 29);
            this.checkInspirationMode.TabIndex = 42;
            this.checkInspirationMode.Text = "Inspiration mode";
            this.checkInspirationMode.UseVisualStyleBackColor = true;
            this.checkInspirationMode.CheckedChanged += new System.EventHandler(this.InspirationMode_Check);
            this.checkInspirationMode.CheckStateChanged += new System.EventHandler(this.InspirationMode_Check);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 430);
            this.Controls.Add(this.checkInspirationMode);
            this.Controls.Add(this.checkBodySuspension);
            this.Controls.Add(this.checkBodyChassisMaterials);
            this.Controls.Add(this.checkBodyMaterials);
            this.Controls.Add(this.checkBodyChassisType);
            this.Controls.Add(this.checkBodyType);
            this.Controls.Add(this.checkDrivetrainTyreCompound);
            this.Controls.Add(this.checkDrivetrainWheels);
            this.Controls.Add(this.checkDrivetrainData);
            this.Controls.Add(this.checkEngineGenerate);
            this.Controls.Add(this.checkEngineType);
            this.Controls.Add(this.checkEngineLayout);
            this.Controls.Add(this.checkEngineIntake);
            this.Controls.Add(this.checkEngineMaterials);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkCountriesReal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarDisplacement);
            this.Controls.Add(this.numericYearMaximum);
            this.Controls.Add(this.numericYearMinimum);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.checkEngineDisplacement);
            this.Controls.Add(this.checkCountries);
            this.Controls.Add(this.checkMarkets);
            this.Controls.Add(this.checkBody);
            this.Controls.Add(this.checkDrivetrainDiff);
            this.Controls.Add(this.checkDrivetrainGearbox);
            this.Controls.Add(this.checkUtility);
            this.Controls.Add(this.checkStupid);
            this.Controls.Add(this.checkEngineFuel);
            this.Controls.Add(this.checkEnginePosition);
            this.Controls.Add(this.checkEngineTurbo);
            this.Name = "Form1";
            this.Text = "Automation Car Idea Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericYearMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDisplacement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkEngineTurbo;
        private CheckBox checkEnginePosition;
        private CheckBox checkEngineFuel;
        private CheckBox checkStupid;
        private CheckBox checkUtility;
        private CheckBox checkDrivetrainGearbox;
        private CheckBox checkDrivetrainDiff;
        private CheckBox checkBody;
        private CheckBox checkMarkets;
        private CheckBox checkCountries;
        private CheckBox checkEngineDisplacement;
        private Button buttonGenerate;
        private NumericUpDown numericYearMinimum;
        private NumericUpDown numericYearMaximum;
        private TrackBar trackBarDisplacement;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numericQuantity;
        private Label label7;
        private Label label8;
        private CheckBox checkCountriesReal;
        private Label label9;
        private CheckBox checkEngineMaterials;
        private CheckBox checkEngineIntake;
        private SaveFileDialog saveFileDialog1;
        private CheckBox checkEngineLayout;
        private CheckBox checkEngineType;
        private CheckBox checkEngineGenerate;
        private CheckBox checkDrivetrainData;
        private CheckBox checkDrivetrainWheels;
        private CheckBox checkDrivetrainTyreCompound;
        private CheckBox checkBodyType;
        private CheckBox checkBodyChassisType;
        private CheckBox checkBodyMaterials;
        private CheckBox checkBodyChassisMaterials;
        private CheckBox checkBodySuspension;
        private CheckBox checkInspirationMode;
    }
}