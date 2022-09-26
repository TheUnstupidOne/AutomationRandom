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
            this.checkTurbo = new System.Windows.Forms.CheckBox();
            this.checkEngine = new System.Windows.Forms.CheckBox();
            this.checkFuel = new System.Windows.Forms.CheckBox();
            this.checkStupid = new System.Windows.Forms.CheckBox();
            this.checkUtility = new System.Windows.Forms.CheckBox();
            this.checkGearbox = new System.Windows.Forms.CheckBox();
            this.checkDiff = new System.Windows.Forms.CheckBox();
            this.checkBody = new System.Windows.Forms.CheckBox();
            this.checkMarkets = new System.Windows.Forms.CheckBox();
            this.checkCountries = new System.Windows.Forms.CheckBox();
            this.checkDisplacement = new System.Windows.Forms.CheckBox();
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
            this.buttonLocation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkEngineMaterials = new System.Windows.Forms.CheckBox();
            this.checkIntake = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDisplacement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // checkTurbo
            // 
            this.checkTurbo.AutoSize = true;
            this.checkTurbo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkTurbo.Location = new System.Drawing.Point(258, 323);
            this.checkTurbo.Name = "checkTurbo";
            this.checkTurbo.Size = new System.Drawing.Size(148, 24);
            this.checkTurbo.TabIndex = 0;
            this.checkTurbo.Text = "Include Aspiration";
            this.checkTurbo.UseVisualStyleBackColor = true;
            // 
            // checkEngine
            // 
            this.checkEngine.AutoSize = true;
            this.checkEngine.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEngine.Location = new System.Drawing.Point(255, 293);
            this.checkEngine.Name = "checkEngine";
            this.checkEngine.Size = new System.Drawing.Size(158, 24);
            this.checkEngine.TabIndex = 1;
            this.checkEngine.Text = "Include Engine type";
            this.checkEngine.UseVisualStyleBackColor = true;
            // 
            // checkFuel
            // 
            this.checkFuel.AutoSize = true;
            this.checkFuel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkFuel.Location = new System.Drawing.Point(255, 233);
            this.checkFuel.Name = "checkFuel";
            this.checkFuel.Size = new System.Drawing.Size(107, 24);
            this.checkFuel.TabIndex = 2;
            this.checkFuel.Text = "Include Fuel";
            this.checkFuel.UseVisualStyleBackColor = true;
            // 
            // checkStupid
            // 
            this.checkStupid.AutoSize = true;
            this.checkStupid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkStupid.Location = new System.Drawing.Point(9, 215);
            this.checkStupid.Name = "checkStupid";
            this.checkStupid.Size = new System.Drawing.Size(165, 24);
            this.checkStupid.TabIndex = 3;
            this.checkStupid.Text = "Allow Stupid configs";
            this.checkStupid.UseVisualStyleBackColor = true;
            // 
            // checkUtility
            // 
            this.checkUtility.AutoSize = true;
            this.checkUtility.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkUtility.Location = new System.Drawing.Point(9, 185);
            this.checkUtility.Name = "checkUtility";
            this.checkUtility.Size = new System.Drawing.Size(122, 24);
            this.checkUtility.TabIndex = 4;
            this.checkUtility.Text = "Exclude Utility";
            this.checkUtility.UseVisualStyleBackColor = true;
            // 
            // checkGearbox
            // 
            this.checkGearbox.AutoSize = true;
            this.checkGearbox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkGearbox.Location = new System.Drawing.Point(255, 203);
            this.checkGearbox.Name = "checkGearbox";
            this.checkGearbox.Size = new System.Drawing.Size(136, 24);
            this.checkGearbox.TabIndex = 5;
            this.checkGearbox.Text = "Include Gearbox";
            this.checkGearbox.UseVisualStyleBackColor = true;
            // 
            // checkDiff
            // 
            this.checkDiff.AutoSize = true;
            this.checkDiff.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDiff.Location = new System.Drawing.Point(255, 173);
            this.checkDiff.Name = "checkDiff";
            this.checkDiff.Size = new System.Drawing.Size(155, 24);
            this.checkDiff.TabIndex = 6;
            this.checkDiff.Text = "Include Differential";
            this.checkDiff.UseVisualStyleBackColor = true;
            // 
            // checkBody
            // 
            this.checkBody.AutoSize = true;
            this.checkBody.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBody.Location = new System.Drawing.Point(9, 302);
            this.checkBody.Name = "checkBody";
            this.checkBody.Size = new System.Drawing.Size(179, 24);
            this.checkBody.TabIndex = 7;
            this.checkBody.Text = "Include Body materials";
            this.checkBody.UseVisualStyleBackColor = true;
            // 
            // checkMarkets
            // 
            this.checkMarkets.AutoSize = true;
            this.checkMarkets.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkMarkets.Location = new System.Drawing.Point(9, 272);
            this.checkMarkets.Name = "checkMarkets";
            this.checkMarkets.Size = new System.Drawing.Size(135, 24);
            this.checkMarkets.TabIndex = 8;
            this.checkMarkets.Text = "Exclude Markets";
            this.checkMarkets.UseVisualStyleBackColor = true;
            // 
            // checkCountries
            // 
            this.checkCountries.AutoSize = true;
            this.checkCountries.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkCountries.Location = new System.Drawing.Point(9, 245);
            this.checkCountries.Name = "checkCountries";
            this.checkCountries.Size = new System.Drawing.Size(145, 24);
            this.checkCountries.TabIndex = 9;
            this.checkCountries.Text = "Exclude Countries";
            this.checkCountries.UseVisualStyleBackColor = true;
            // 
            // checkDisplacement
            // 
            this.checkDisplacement.AutoSize = true;
            this.checkDisplacement.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkDisplacement.Location = new System.Drawing.Point(255, 263);
            this.checkDisplacement.Name = "checkDisplacement";
            this.checkDisplacement.Size = new System.Drawing.Size(171, 24);
            this.checkDisplacement.TabIndex = 10;
            this.checkDisplacement.Text = "Include Displacement";
            this.checkDisplacement.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.Location = new System.Drawing.Point(497, 339);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(117, 35);
            this.buttonGenerate.TabIndex = 11;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // numericYearMinimum
            // 
            this.numericYearMinimum.AccessibleName = "Minimum Year";
            this.numericYearMinimum.Location = new System.Drawing.Point(9, 109);
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
            // 
            // numericYearMaximum
            // 
            this.numericYearMaximum.Location = new System.Drawing.Point(9, 156);
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
            1941,
            0,
            0,
            0});
            // 
            // trackBarDisplacement
            // 
            this.trackBarDisplacement.Location = new System.Drawing.Point(258, 109);
            this.trackBarDisplacement.Maximum = 3;
            this.trackBarDisplacement.Name = "trackBarDisplacement";
            this.trackBarDisplacement.Size = new System.Drawing.Size(179, 45);
            this.trackBarDisplacement.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Small";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Medium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Large";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "All";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Minimum Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Maximum Year";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(497, 109);
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
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(255, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Engine Displacement Mode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(494, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Idea quantity";
            // 
            // buttonLocation
            // 
            this.buttonLocation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLocation.Location = new System.Drawing.Point(9, 24);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(132, 33);
            this.buttonLocation.TabIndex = 24;
            this.buttonLocation.Text = "Location Select";
            this.buttonLocation.UseCompatibleTextRendering = true;
            this.buttonLocation.UseVisualStyleBackColor = true;
            this.buttonLocation.Click += new System.EventHandler(this.folder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 23);
            this.textBox1.TabIndex = 25;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(9, 350);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 24);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Use Real Countries";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Temporarily unavailable feature";
            // 
            // checkEngineMaterials
            // 
            this.checkEngineMaterials.AutoSize = true;
            this.checkEngineMaterials.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEngineMaterials.Location = new System.Drawing.Point(258, 350);
            this.checkEngineMaterials.Name = "checkEngineMaterials";
            this.checkEngineMaterials.Size = new System.Drawing.Size(190, 24);
            this.checkEngineMaterials.TabIndex = 28;
            this.checkEngineMaterials.Text = "Include Engine Materials";
            this.checkEngineMaterials.UseVisualStyleBackColor = true;
            // 
            // checkIntake
            // 
            this.checkIntake.AutoSize = true;
            this.checkIntake.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkIntake.Location = new System.Drawing.Point(258, 380);
            this.checkIntake.Name = "checkIntake";
            this.checkIntake.Size = new System.Drawing.Size(270, 24);
            this.checkIntake.TabIndex = 29;
            this.checkIntake.Text = "Include Engine Head Randomization";
            this.checkIntake.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 410);
            this.Controls.Add(this.checkIntake);
            this.Controls.Add(this.checkEngineMaterials);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonLocation);
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
            this.Controls.Add(this.checkDisplacement);
            this.Controls.Add(this.checkCountries);
            this.Controls.Add(this.checkMarkets);
            this.Controls.Add(this.checkBody);
            this.Controls.Add(this.checkDiff);
            this.Controls.Add(this.checkGearbox);
            this.Controls.Add(this.checkUtility);
            this.Controls.Add(this.checkStupid);
            this.Controls.Add(this.checkFuel);
            this.Controls.Add(this.checkEngine);
            this.Controls.Add(this.checkTurbo);
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

        private CheckBox checkTurbo;
        private CheckBox checkEngine;
        private CheckBox checkFuel;
        private CheckBox checkStupid;
        private CheckBox checkUtility;
        private CheckBox checkGearbox;
        private CheckBox checkDiff;
        private CheckBox checkBody;
        private CheckBox checkMarkets;
        private CheckBox checkCountries;
        private CheckBox checkDisplacement;
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
        private Button buttonLocation;
        private TextBox textBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox checkBox1;
        private Label label9;
        private CheckBox checkEngineMaterials;
        private CheckBox checkIntake;
    }
}