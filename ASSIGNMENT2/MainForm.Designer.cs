namespace ASSIGNMENT2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HighGoalBox = new System.Windows.Forms.ComboBox();
            this.HighGoalLabel = new System.Windows.Forms.Label();
            this.LowGoalBox = new System.Windows.Forms.ComboBox();
            this.LowGoalLabel = new System.Windows.Forms.Label();
            this.MiddleBarBox = new System.Windows.Forms.ComboBox();
            this.MiddleBarLabel = new System.Windows.Forms.Label();
            this.PickUpBallBox = new System.Windows.Forms.ComboBox();
            this.PickUpBallLabel = new System.Windows.Forms.Label();
            this.CatchBallBox = new System.Windows.Forms.ComboBox();
            this.CatchBallLabel = new System.Windows.Forms.Label();
            this.PassBallBox = new System.Windows.Forms.ComboBox();
            this.PassBallLabel = new System.Windows.Forms.Label();
            this.HumanControlGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoHighGoalBox = new System.Windows.Forms.ComboBox();
            this.AutoHighGoalLabel = new System.Windows.Forms.Label();
            this.AutoLowGoalBox = new System.Windows.Forms.ComboBox();
            this.AutoLowGoalLabel = new System.Windows.Forms.Label();
            this.AutoForwardBox = new System.Windows.Forms.ComboBox();
            this.AutonomousDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoForwardLabel = new System.Windows.Forms.Label();
            this.TeamNameBox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.TeamNumberBox = new System.Windows.Forms.TextBox();
            this.TeamNumberLabel = new System.Windows.Forms.Label();
            this.TeamDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.RobotGroupBox = new System.Windows.Forms.GroupBox();
            this.AddPictureButton = new System.Windows.Forms.Button();
            this.RobotPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RobotDescriptionBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.OverallAttackBox = new System.Windows.Forms.ComboBox();
            this.OverallAttackLabel = new System.Windows.Forms.Label();
            this.SpeedBox = new System.Windows.Forms.ComboBox();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.ManeuverabilityBox = new System.Windows.Forms.ComboBox();
            this.ManeuverabilityLabel = new System.Windows.Forms.Label();
            this.OverallDefenseBox = new System.Windows.Forms.ComboBox();
            this.OverallDefenseLabel = new System.Windows.Forms.Label();
            this.RobotPerRadioButton = new System.Windows.Forms.RadioButton();
            this.ScoutsDetailsRadioButton = new System.Windows.Forms.RadioButton();
            this.MatchPerformanceGroupBox = new System.Windows.Forms.GroupBox();
            this.MatchHighGoalBox = new System.Windows.Forms.ComboBox();
            this.MatchLowGoalBox = new System.Windows.Forms.ComboBox();
            this.MatchThrowOverBox = new System.Windows.Forms.ComboBox();
            this.MatchLowGoalLabel = new System.Windows.Forms.Label();
            this.MatchHighGoalLabel = new System.Windows.Forms.Label();
            this.MatchThrowOverLabel = new System.Windows.Forms.Label();
            this.MatchCollectBallBox = new System.Windows.Forms.ComboBox();
            this.MatchCollectBallLabel = new System.Windows.Forms.Label();
            this.MatchCatchBallBox = new System.Windows.Forms.ComboBox();
            this.MatchCatchBallLabel = new System.Windows.Forms.Label();
            this.MatchPassBallBox = new System.Windows.Forms.ComboBox();
            this.MatchPassBallLabel = new System.Windows.Forms.Label();
            this.MatchHighGoalAutoBox = new System.Windows.Forms.ComboBox();
            this.MatchHighGoalAutoLable = new System.Windows.Forms.Label();
            this.MatchLowGoalAutoBox = new System.Windows.Forms.ComboBox();
            this.MatchLowGoalAutoLabel = new System.Windows.Forms.Label();
            this.MatchDriveForwardBox = new System.Windows.Forms.ComboBox();
            this.MatchDriveForwardLabel = new System.Windows.Forms.Label();
            this.MatchPerformanceRadioButton = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportMenuButton = new System.Windows.Forms.Button();
            this.ImportMenuButton = new System.Windows.Forms.Button();
            this.HumanControlGroupBox.SuspendLayout();
            this.AutonomousDetailsGroupBox.SuspendLayout();
            this.TeamDetailsGroupBox.SuspendLayout();
            this.RobotGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RobotPictureBox)).BeginInit();
            this.MatchPerformanceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HighGoalBox
            // 
            this.HighGoalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HighGoalBox.BackColor = System.Drawing.Color.White;
            this.HighGoalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HighGoalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighGoalBox.ForeColor = System.Drawing.Color.Black;
            this.HighGoalBox.FormattingEnabled = true;
            this.HighGoalBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.HighGoalBox.Location = new System.Drawing.Point(214, 290);
            this.HighGoalBox.Margin = new System.Windows.Forms.Padding(4);
            this.HighGoalBox.Name = "HighGoalBox";
            this.HighGoalBox.Size = new System.Drawing.Size(566, 33);
            this.HighGoalBox.TabIndex = 13;
            this.HighGoalBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // HighGoalLabel
            // 
            this.HighGoalLabel.Location = new System.Drawing.Point(28, 290);
            this.HighGoalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HighGoalLabel.Name = "HighGoalLabel";
            this.HighGoalLabel.Size = new System.Drawing.Size(176, 37);
            this.HighGoalLabel.TabIndex = 12;
            this.HighGoalLabel.Text = "High Goal";
            this.HighGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LowGoalBox
            // 
            this.LowGoalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LowGoalBox.BackColor = System.Drawing.Color.White;
            this.LowGoalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LowGoalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LowGoalBox.ForeColor = System.Drawing.Color.Black;
            this.LowGoalBox.FormattingEnabled = true;
            this.LowGoalBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.LowGoalBox.Location = new System.Drawing.Point(214, 244);
            this.LowGoalBox.Margin = new System.Windows.Forms.Padding(4);
            this.LowGoalBox.Name = "LowGoalBox";
            this.LowGoalBox.Size = new System.Drawing.Size(566, 33);
            this.LowGoalBox.TabIndex = 11;
            this.LowGoalBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // LowGoalLabel
            // 
            this.LowGoalLabel.Location = new System.Drawing.Point(28, 244);
            this.LowGoalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowGoalLabel.Name = "LowGoalLabel";
            this.LowGoalLabel.Size = new System.Drawing.Size(176, 37);
            this.LowGoalLabel.TabIndex = 10;
            this.LowGoalLabel.Text = "Low Goal";
            this.LowGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MiddleBarBox
            // 
            this.MiddleBarBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MiddleBarBox.BackColor = System.Drawing.Color.White;
            this.MiddleBarBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MiddleBarBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiddleBarBox.ForeColor = System.Drawing.Color.Black;
            this.MiddleBarBox.FormattingEnabled = true;
            this.MiddleBarBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.MiddleBarBox.Location = new System.Drawing.Point(214, 196);
            this.MiddleBarBox.Margin = new System.Windows.Forms.Padding(4);
            this.MiddleBarBox.Name = "MiddleBarBox";
            this.MiddleBarBox.Size = new System.Drawing.Size(566, 33);
            this.MiddleBarBox.TabIndex = 9;
            this.MiddleBarBox.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // MiddleBarLabel
            // 
            this.MiddleBarLabel.Location = new System.Drawing.Point(28, 196);
            this.MiddleBarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MiddleBarLabel.Name = "MiddleBarLabel";
            this.MiddleBarLabel.Size = new System.Drawing.Size(176, 37);
            this.MiddleBarLabel.TabIndex = 8;
            this.MiddleBarLabel.Text = "Middle Bar";
            this.MiddleBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PickUpBallBox
            // 
            this.PickUpBallBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PickUpBallBox.BackColor = System.Drawing.Color.White;
            this.PickUpBallBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PickUpBallBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PickUpBallBox.ForeColor = System.Drawing.Color.Black;
            this.PickUpBallBox.FormattingEnabled = true;
            this.PickUpBallBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.PickUpBallBox.Location = new System.Drawing.Point(214, 150);
            this.PickUpBallBox.Margin = new System.Windows.Forms.Padding(4);
            this.PickUpBallBox.Name = "PickUpBallBox";
            this.PickUpBallBox.Size = new System.Drawing.Size(566, 33);
            this.PickUpBallBox.TabIndex = 7;
            this.PickUpBallBox.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // PickUpBallLabel
            // 
            this.PickUpBallLabel.Location = new System.Drawing.Point(28, 150);
            this.PickUpBallLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PickUpBallLabel.Name = "PickUpBallLabel";
            this.PickUpBallLabel.Size = new System.Drawing.Size(176, 37);
            this.PickUpBallLabel.TabIndex = 6;
            this.PickUpBallLabel.Text = "Pick Up Ball";
            this.PickUpBallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CatchBallBox
            // 
            this.CatchBallBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CatchBallBox.BackColor = System.Drawing.Color.White;
            this.CatchBallBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatchBallBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatchBallBox.ForeColor = System.Drawing.Color.Black;
            this.CatchBallBox.FormattingEnabled = true;
            this.CatchBallBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.CatchBallBox.Location = new System.Drawing.Point(214, 104);
            this.CatchBallBox.Margin = new System.Windows.Forms.Padding(4);
            this.CatchBallBox.Name = "CatchBallBox";
            this.CatchBallBox.Size = new System.Drawing.Size(566, 33);
            this.CatchBallBox.TabIndex = 5;
            this.CatchBallBox.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // CatchBallLabel
            // 
            this.CatchBallLabel.Location = new System.Drawing.Point(28, 104);
            this.CatchBallLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CatchBallLabel.Name = "CatchBallLabel";
            this.CatchBallLabel.Size = new System.Drawing.Size(176, 37);
            this.CatchBallLabel.TabIndex = 4;
            this.CatchBallLabel.Text = "Catch Ball";
            this.CatchBallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PassBallBox
            // 
            this.PassBallBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassBallBox.BackColor = System.Drawing.Color.White;
            this.PassBallBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PassBallBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassBallBox.ForeColor = System.Drawing.Color.Black;
            this.PassBallBox.FormattingEnabled = true;
            this.PassBallBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.PassBallBox.Location = new System.Drawing.Point(214, 56);
            this.PassBallBox.Margin = new System.Windows.Forms.Padding(4);
            this.PassBallBox.Name = "PassBallBox";
            this.PassBallBox.Size = new System.Drawing.Size(566, 33);
            this.PassBallBox.TabIndex = 3;
            this.PassBallBox.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // PassBallLabel
            // 
            this.PassBallLabel.Location = new System.Drawing.Point(28, 56);
            this.PassBallLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassBallLabel.Name = "PassBallLabel";
            this.PassBallLabel.Size = new System.Drawing.Size(176, 37);
            this.PassBallLabel.TabIndex = 2;
            this.PassBallLabel.Text = "Pass Ball";
            this.PassBallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HumanControlGroupBox
            // 
            this.HumanControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HumanControlGroupBox.Controls.Add(this.HighGoalBox);
            this.HumanControlGroupBox.Controls.Add(this.HighGoalLabel);
            this.HumanControlGroupBox.Controls.Add(this.LowGoalBox);
            this.HumanControlGroupBox.Controls.Add(this.LowGoalLabel);
            this.HumanControlGroupBox.Controls.Add(this.MiddleBarBox);
            this.HumanControlGroupBox.Controls.Add(this.MiddleBarLabel);
            this.HumanControlGroupBox.Controls.Add(this.PickUpBallBox);
            this.HumanControlGroupBox.Controls.Add(this.PickUpBallLabel);
            this.HumanControlGroupBox.Controls.Add(this.CatchBallBox);
            this.HumanControlGroupBox.Controls.Add(this.CatchBallLabel);
            this.HumanControlGroupBox.Controls.Add(this.PassBallBox);
            this.HumanControlGroupBox.Controls.Add(this.PassBallLabel);
            this.HumanControlGroupBox.Location = new System.Drawing.Point(503, 440);
            this.HumanControlGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.HumanControlGroupBox.Name = "HumanControlGroupBox";
            this.HumanControlGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.HumanControlGroupBox.Size = new System.Drawing.Size(812, 348);
            this.HumanControlGroupBox.TabIndex = 5;
            this.HumanControlGroupBox.TabStop = false;
            this.HumanControlGroupBox.Text = "Human Control Details";
            // 
            // AutoHighGoalBox
            // 
            this.AutoHighGoalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoHighGoalBox.BackColor = System.Drawing.Color.White;
            this.AutoHighGoalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AutoHighGoalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoHighGoalBox.ForeColor = System.Drawing.Color.Black;
            this.AutoHighGoalBox.FormattingEnabled = true;
            this.AutoHighGoalBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.AutoHighGoalBox.Location = new System.Drawing.Point(214, 154);
            this.AutoHighGoalBox.Margin = new System.Windows.Forms.Padding(4);
            this.AutoHighGoalBox.Name = "AutoHighGoalBox";
            this.AutoHighGoalBox.Size = new System.Drawing.Size(566, 33);
            this.AutoHighGoalBox.TabIndex = 7;
            this.AutoHighGoalBox.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // AutoHighGoalLabel
            // 
            this.AutoHighGoalLabel.Location = new System.Drawing.Point(28, 154);
            this.AutoHighGoalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AutoHighGoalLabel.Name = "AutoHighGoalLabel";
            this.AutoHighGoalLabel.Size = new System.Drawing.Size(176, 37);
            this.AutoHighGoalLabel.TabIndex = 6;
            this.AutoHighGoalLabel.Text = "High Goal";
            this.AutoHighGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AutoLowGoalBox
            // 
            this.AutoLowGoalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoLowGoalBox.BackColor = System.Drawing.Color.White;
            this.AutoLowGoalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AutoLowGoalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoLowGoalBox.ForeColor = System.Drawing.Color.Black;
            this.AutoLowGoalBox.FormattingEnabled = true;
            this.AutoLowGoalBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.AutoLowGoalBox.Location = new System.Drawing.Point(214, 104);
            this.AutoLowGoalBox.Margin = new System.Windows.Forms.Padding(4);
            this.AutoLowGoalBox.Name = "AutoLowGoalBox";
            this.AutoLowGoalBox.Size = new System.Drawing.Size(566, 33);
            this.AutoLowGoalBox.TabIndex = 4;
            this.AutoLowGoalBox.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // AutoLowGoalLabel
            // 
            this.AutoLowGoalLabel.Location = new System.Drawing.Point(28, 106);
            this.AutoLowGoalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AutoLowGoalLabel.Name = "AutoLowGoalLabel";
            this.AutoLowGoalLabel.Size = new System.Drawing.Size(176, 37);
            this.AutoLowGoalLabel.TabIndex = 0;
            this.AutoLowGoalLabel.Text = "Low Goal";
            this.AutoLowGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AutoForwardBox
            // 
            this.AutoForwardBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoForwardBox.BackColor = System.Drawing.Color.White;
            this.AutoForwardBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AutoForwardBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoForwardBox.ForeColor = System.Drawing.Color.Black;
            this.AutoForwardBox.FormattingEnabled = true;
            this.AutoForwardBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.AutoForwardBox.Location = new System.Drawing.Point(214, 56);
            this.AutoForwardBox.Margin = new System.Windows.Forms.Padding(4);
            this.AutoForwardBox.Name = "AutoForwardBox";
            this.AutoForwardBox.Size = new System.Drawing.Size(566, 33);
            this.AutoForwardBox.TabIndex = 3;
            this.AutoForwardBox.SelectedValueChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // AutonomousDetailsGroupBox
            // 
            this.AutonomousDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoHighGoalBox);
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoHighGoalLabel);
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoLowGoalBox);
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoLowGoalLabel);
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoForwardBox);
            this.AutonomousDetailsGroupBox.Controls.Add(this.AutoForwardLabel);
            this.AutonomousDetailsGroupBox.Location = new System.Drawing.Point(503, 210);
            this.AutonomousDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.AutonomousDetailsGroupBox.Name = "AutonomousDetailsGroupBox";
            this.AutonomousDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.AutonomousDetailsGroupBox.Size = new System.Drawing.Size(812, 223);
            this.AutonomousDetailsGroupBox.TabIndex = 4;
            this.AutonomousDetailsGroupBox.TabStop = false;
            this.AutonomousDetailsGroupBox.Text = "Autonomous Details";
            // 
            // AutoForwardLabel
            // 
            this.AutoForwardLabel.Location = new System.Drawing.Point(28, 56);
            this.AutoForwardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AutoForwardLabel.Name = "AutoForwardLabel";
            this.AutoForwardLabel.Size = new System.Drawing.Size(176, 37);
            this.AutoForwardLabel.TabIndex = 0;
            this.AutoForwardLabel.Text = "Drive Forward";
            this.AutoForwardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TeamNameBox
            // 
            this.TeamNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamNameBox.Location = new System.Drawing.Point(214, 94);
            this.TeamNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeamNameBox.Name = "TeamNameBox";
            this.TeamNameBox.Size = new System.Drawing.Size(300, 31);
            this.TeamNameBox.TabIndex = 2;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.Location = new System.Drawing.Point(28, 94);
            this.TeamNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(176, 37);
            this.TeamNameLabel.TabIndex = 0;
            this.TeamNameLabel.Text = "Name";
            this.TeamNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TeamNumberBox
            // 
            this.TeamNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamNumberBox.Location = new System.Drawing.Point(214, 50);
            this.TeamNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeamNumberBox.Name = "TeamNumberBox";
            this.TeamNumberBox.Size = new System.Drawing.Size(300, 31);
            this.TeamNumberBox.TabIndex = 1;
            this.TeamNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeamNumberBox_KeyPress);
            // 
            // TeamNumberLabel
            // 
            this.TeamNumberLabel.Location = new System.Drawing.Point(28, 50);
            this.TeamNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamNumberLabel.Name = "TeamNumberLabel";
            this.TeamNumberLabel.Size = new System.Drawing.Size(176, 37);
            this.TeamNumberLabel.TabIndex = 0;
            this.TeamNumberLabel.Text = "Number";
            this.TeamNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TeamDetailsGroupBox
            // 
            this.TeamDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamDetailsGroupBox.Controls.Add(this.TeamNameBox);
            this.TeamDetailsGroupBox.Controls.Add(this.TeamNameLabel);
            this.TeamDetailsGroupBox.Controls.Add(this.TeamNumberBox);
            this.TeamDetailsGroupBox.Controls.Add(this.TeamNumberLabel);
            this.TeamDetailsGroupBox.Location = new System.Drawing.Point(503, 40);
            this.TeamDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeamDetailsGroupBox.Name = "TeamDetailsGroupBox";
            this.TeamDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.TeamDetailsGroupBox.Size = new System.Drawing.Size(812, 162);
            this.TeamDetailsGroupBox.TabIndex = 3;
            this.TeamDetailsGroupBox.TabStop = false;
            this.TeamDetailsGroupBox.Text = "Team Detailz";
            // 
            // RobotGroupBox
            // 
            this.RobotGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RobotGroupBox.Controls.Add(this.AddPictureButton);
            this.RobotGroupBox.Controls.Add(this.RobotPictureBox);
            this.RobotGroupBox.Controls.Add(this.label1);
            this.RobotGroupBox.Controls.Add(this.RobotDescriptionBox);
            this.RobotGroupBox.Controls.Add(this.DescriptionLabel);
            this.RobotGroupBox.Controls.Add(this.OverallAttackBox);
            this.RobotGroupBox.Controls.Add(this.OverallAttackLabel);
            this.RobotGroupBox.Controls.Add(this.SpeedBox);
            this.RobotGroupBox.Controls.Add(this.SpeedLabel);
            this.RobotGroupBox.Controls.Add(this.ManeuverabilityBox);
            this.RobotGroupBox.Controls.Add(this.ManeuverabilityLabel);
            this.RobotGroupBox.Controls.Add(this.OverallDefenseBox);
            this.RobotGroupBox.Controls.Add(this.OverallDefenseLabel);
            this.RobotGroupBox.Location = new System.Drawing.Point(503, 210);
            this.RobotGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.RobotGroupBox.Name = "RobotGroupBox";
            this.RobotGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.RobotGroupBox.Size = new System.Drawing.Size(812, 579);
            this.RobotGroupBox.TabIndex = 8;
            this.RobotGroupBox.TabStop = false;
            this.RobotGroupBox.Text = "Robot\'s Performance";
            // 
            // AddPictureButton
            // 
            this.AddPictureButton.Location = new System.Drawing.Point(32, 417);
            this.AddPictureButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddPictureButton.Name = "AddPictureButton";
            this.AddPictureButton.Size = new System.Drawing.Size(168, 46);
            this.AddPictureButton.TabIndex = 13;
            this.AddPictureButton.Text = "Add Picture";
            this.AddPictureButton.UseVisualStyleBackColor = true;
            this.AddPictureButton.Click += new System.EventHandler(this.AddPictureButton_Click);
            // 
            // RobotPictureBox
            // 
            this.RobotPictureBox.Location = new System.Drawing.Point(212, 308);
            this.RobotPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.RobotPictureBox.Name = "RobotPictureBox";
            this.RobotPictureBox.Size = new System.Drawing.Size(378, 250);
            this.RobotPictureBox.TabIndex = 12;
            this.RobotPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Robot\'s  Picture";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RobotDescriptionBox
            // 
            this.RobotDescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RobotDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RobotDescriptionBox.Location = new System.Drawing.Point(212, 254);
            this.RobotDescriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.RobotDescriptionBox.Name = "RobotDescriptionBox";
            this.RobotDescriptionBox.Size = new System.Drawing.Size(570, 31);
            this.RobotDescriptionBox.TabIndex = 3;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(30, 250);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(176, 37);
            this.DescriptionLabel.TabIndex = 10;
            this.DescriptionLabel.Text = "Description";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OverallAttackBox
            // 
            this.OverallAttackBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverallAttackBox.BackColor = System.Drawing.Color.White;
            this.OverallAttackBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OverallAttackBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverallAttackBox.ForeColor = System.Drawing.Color.Black;
            this.OverallAttackBox.FormattingEnabled = true;
            this.OverallAttackBox.Items.AddRange(new object[] {
            "Terrible",
            "Bad",
            "Average",
            "Good",
            "Excellent"});
            this.OverallAttackBox.Location = new System.Drawing.Point(214, 202);
            this.OverallAttackBox.Margin = new System.Windows.Forms.Padding(4);
            this.OverallAttackBox.Name = "OverallAttackBox";
            this.OverallAttackBox.Size = new System.Drawing.Size(566, 33);
            this.OverallAttackBox.TabIndex = 9;
            // 
            // OverallAttackLabel
            // 
            this.OverallAttackLabel.Location = new System.Drawing.Point(30, 202);
            this.OverallAttackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OverallAttackLabel.Name = "OverallAttackLabel";
            this.OverallAttackLabel.Size = new System.Drawing.Size(176, 37);
            this.OverallAttackLabel.TabIndex = 8;
            this.OverallAttackLabel.Text = "Overall Attack";
            this.OverallAttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SpeedBox
            // 
            this.SpeedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedBox.BackColor = System.Drawing.Color.White;
            this.SpeedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeedBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeedBox.ForeColor = System.Drawing.Color.Black;
            this.SpeedBox.FormattingEnabled = true;
            this.SpeedBox.Items.AddRange(new object[] {
            "Terrible",
            "Bad",
            "Average",
            "Good",
            "Excellent"});
            this.SpeedBox.Location = new System.Drawing.Point(214, 154);
            this.SpeedBox.Margin = new System.Windows.Forms.Padding(4);
            this.SpeedBox.Name = "SpeedBox";
            this.SpeedBox.Size = new System.Drawing.Size(566, 33);
            this.SpeedBox.TabIndex = 7;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.Location = new System.Drawing.Point(28, 154);
            this.SpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(176, 37);
            this.SpeedLabel.TabIndex = 6;
            this.SpeedLabel.Text = "Speed";
            this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManeuverabilityBox
            // 
            this.ManeuverabilityBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManeuverabilityBox.BackColor = System.Drawing.Color.White;
            this.ManeuverabilityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManeuverabilityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManeuverabilityBox.ForeColor = System.Drawing.Color.Black;
            this.ManeuverabilityBox.FormattingEnabled = true;
            this.ManeuverabilityBox.Items.AddRange(new object[] {
            "Terrible",
            "Bad",
            "Average",
            "Good",
            "Excellent"});
            this.ManeuverabilityBox.Location = new System.Drawing.Point(214, 104);
            this.ManeuverabilityBox.Margin = new System.Windows.Forms.Padding(4);
            this.ManeuverabilityBox.Name = "ManeuverabilityBox";
            this.ManeuverabilityBox.Size = new System.Drawing.Size(566, 33);
            this.ManeuverabilityBox.TabIndex = 4;
            // 
            // ManeuverabilityLabel
            // 
            this.ManeuverabilityLabel.Location = new System.Drawing.Point(28, 106);
            this.ManeuverabilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManeuverabilityLabel.Name = "ManeuverabilityLabel";
            this.ManeuverabilityLabel.Size = new System.Drawing.Size(176, 37);
            this.ManeuverabilityLabel.TabIndex = 0;
            this.ManeuverabilityLabel.Text = "Maneuverability";
            this.ManeuverabilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OverallDefenseBox
            // 
            this.OverallDefenseBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverallDefenseBox.BackColor = System.Drawing.Color.White;
            this.OverallDefenseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OverallDefenseBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverallDefenseBox.ForeColor = System.Drawing.Color.Black;
            this.OverallDefenseBox.FormattingEnabled = true;
            this.OverallDefenseBox.Items.AddRange(new object[] {
            "Terrible",
            "Bad",
            "Average",
            "Good",
            "Excellent"});
            this.OverallDefenseBox.Location = new System.Drawing.Point(214, 56);
            this.OverallDefenseBox.Margin = new System.Windows.Forms.Padding(4);
            this.OverallDefenseBox.Name = "OverallDefenseBox";
            this.OverallDefenseBox.Size = new System.Drawing.Size(566, 33);
            this.OverallDefenseBox.TabIndex = 3;
            // 
            // OverallDefenseLabel
            // 
            this.OverallDefenseLabel.Location = new System.Drawing.Point(28, 56);
            this.OverallDefenseLabel.Margin = new System.Windows.Forms.Padding(4);
            this.OverallDefenseLabel.Name = "OverallDefenseLabel";
            this.OverallDefenseLabel.Size = new System.Drawing.Size(176, 37);
            this.OverallDefenseLabel.TabIndex = 0;
            this.OverallDefenseLabel.Text = "Overall Defense";
            this.OverallDefenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RobotPerRadioButton
            // 
            this.RobotPerRadioButton.AutoSize = true;
            this.RobotPerRadioButton.Checked = true;
            this.RobotPerRadioButton.Location = new System.Drawing.Point(4, 12);
            this.RobotPerRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.RobotPerRadioButton.Name = "RobotPerRadioButton";
            this.RobotPerRadioButton.Size = new System.Drawing.Size(228, 29);
            this.RobotPerRadioButton.TabIndex = 6;
            this.RobotPerRadioButton.TabStop = true;
            this.RobotPerRadioButton.Text = "Robot Performance";
            this.RobotPerRadioButton.UseVisualStyleBackColor = true;
            this.RobotPerRadioButton.CheckedChanged += new System.EventHandler(this.RobotPerRadioButton_CheckedChanged);
            // 
            // ScoutsDetailsRadioButton
            // 
            this.ScoutsDetailsRadioButton.AutoSize = true;
            this.ScoutsDetailsRadioButton.Location = new System.Drawing.Point(13, 251);
            this.ScoutsDetailsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ScoutsDetailsRadioButton.Name = "ScoutsDetailsRadioButton";
            this.ScoutsDetailsRadioButton.Size = new System.Drawing.Size(181, 29);
            this.ScoutsDetailsRadioButton.TabIndex = 7;
            this.ScoutsDetailsRadioButton.Text = "Scouts Details";
            this.ScoutsDetailsRadioButton.UseVisualStyleBackColor = true;
            this.ScoutsDetailsRadioButton.CheckedChanged += new System.EventHandler(this.ScoutsDetailsRadioButton_CheckedChanged);
            // 
            // MatchPerformanceGroupBox
            // 
            this.MatchPerformanceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchHighGoalBox);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchLowGoalBox);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchThrowOverBox);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchLowGoalLabel);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchHighGoalLabel);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchThrowOverLabel);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchCollectBallBox);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchCollectBallLabel);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchCatchBallBox);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchCatchBallLabel);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchPassBallBox);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchPassBallLabel);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchHighGoalAutoBox);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchHighGoalAutoLable);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchLowGoalAutoBox);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchLowGoalAutoLabel);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchDriveForwardBox);
            this.MatchPerformanceGroupBox.Controls.Add(this.MatchDriveForwardLabel);
            this.MatchPerformanceGroupBox.Location = new System.Drawing.Point(503, 210);
            this.MatchPerformanceGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatchPerformanceGroupBox.Name = "MatchPerformanceGroupBox";
            this.MatchPerformanceGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.MatchPerformanceGroupBox.Size = new System.Drawing.Size(812, 513);
            this.MatchPerformanceGroupBox.TabIndex = 8;
            this.MatchPerformanceGroupBox.TabStop = false;
            this.MatchPerformanceGroupBox.Text = "Match Performance";
            // 
            // MatchHighGoalBox
            // 
            this.MatchHighGoalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchHighGoalBox.BackColor = System.Drawing.Color.White;
            this.MatchHighGoalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchHighGoalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchHighGoalBox.ForeColor = System.Drawing.Color.Black;
            this.MatchHighGoalBox.FormattingEnabled = true;
            this.MatchHighGoalBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.MatchHighGoalBox.Location = new System.Drawing.Point(214, 442);
            this.MatchHighGoalBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatchHighGoalBox.Name = "MatchHighGoalBox";
            this.MatchHighGoalBox.Size = new System.Drawing.Size(566, 33);
            this.MatchHighGoalBox.TabIndex = 18;
            this.MatchHighGoalBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // MatchLowGoalBox
            // 
            this.MatchLowGoalBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchLowGoalBox.BackColor = System.Drawing.Color.White;
            this.MatchLowGoalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchLowGoalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchLowGoalBox.ForeColor = System.Drawing.Color.Black;
            this.MatchLowGoalBox.FormattingEnabled = true;
            this.MatchLowGoalBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.MatchLowGoalBox.Location = new System.Drawing.Point(214, 392);
            this.MatchLowGoalBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatchLowGoalBox.Name = "MatchLowGoalBox";
            this.MatchLowGoalBox.Size = new System.Drawing.Size(566, 33);
            this.MatchLowGoalBox.TabIndex = 17;
            this.MatchLowGoalBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // MatchThrowOverBox
            // 
            this.MatchThrowOverBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchThrowOverBox.BackColor = System.Drawing.Color.White;
            this.MatchThrowOverBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchThrowOverBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchThrowOverBox.ForeColor = System.Drawing.Color.Black;
            this.MatchThrowOverBox.FormattingEnabled = true;
            this.MatchThrowOverBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.MatchThrowOverBox.Location = new System.Drawing.Point(214, 344);
            this.MatchThrowOverBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatchThrowOverBox.Name = "MatchThrowOverBox";
            this.MatchThrowOverBox.Size = new System.Drawing.Size(566, 33);
            this.MatchThrowOverBox.TabIndex = 16;
            this.MatchThrowOverBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // MatchLowGoalLabel
            // 
            this.MatchLowGoalLabel.Location = new System.Drawing.Point(26, 396);
            this.MatchLowGoalLabel.Margin = new System.Windows.Forms.Padding(4);
            this.MatchLowGoalLabel.Name = "MatchLowGoalLabel";
            this.MatchLowGoalLabel.Size = new System.Drawing.Size(176, 37);
            this.MatchLowGoalLabel.TabIndex = 12;
            this.MatchLowGoalLabel.Text = "Low Goal";
            this.MatchLowGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatchHighGoalLabel
            // 
            this.MatchHighGoalLabel.Location = new System.Drawing.Point(26, 446);
            this.MatchHighGoalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatchHighGoalLabel.Name = "MatchHighGoalLabel";
            this.MatchHighGoalLabel.Size = new System.Drawing.Size(176, 37);
            this.MatchHighGoalLabel.TabIndex = 15;
            this.MatchHighGoalLabel.Text = "High Goal";
            this.MatchHighGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatchThrowOverLabel
            // 
            this.MatchThrowOverLabel.Location = new System.Drawing.Point(26, 348);
            this.MatchThrowOverLabel.Margin = new System.Windows.Forms.Padding(4);
            this.MatchThrowOverLabel.Name = "MatchThrowOverLabel";
            this.MatchThrowOverLabel.Size = new System.Drawing.Size(176, 37);
            this.MatchThrowOverLabel.TabIndex = 12;
            this.MatchThrowOverLabel.Text = "Throw Over";
            this.MatchThrowOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatchCollectBallBox
            // 
            this.MatchCollectBallBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchCollectBallBox.BackColor = System.Drawing.Color.White;
            this.MatchCollectBallBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchCollectBallBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchCollectBallBox.ForeColor = System.Drawing.Color.Black;
            this.MatchCollectBallBox.FormattingEnabled = true;
            this.MatchCollectBallBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.MatchCollectBallBox.Location = new System.Drawing.Point(214, 296);
            this.MatchCollectBallBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatchCollectBallBox.Name = "MatchCollectBallBox";
            this.MatchCollectBallBox.Size = new System.Drawing.Size(566, 33);
            this.MatchCollectBallBox.TabIndex = 13;
            this.MatchCollectBallBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // MatchCollectBallLabel
            // 
            this.MatchCollectBallLabel.Location = new System.Drawing.Point(26, 300);
            this.MatchCollectBallLabel.Margin = new System.Windows.Forms.Padding(4);
            this.MatchCollectBallLabel.Name = "MatchCollectBallLabel";
            this.MatchCollectBallLabel.Size = new System.Drawing.Size(176, 37);
            this.MatchCollectBallLabel.TabIndex = 12;
            this.MatchCollectBallLabel.Text = "Collect Ball";
            this.MatchCollectBallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatchCatchBallBox
            // 
            this.MatchCatchBallBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchCatchBallBox.BackColor = System.Drawing.Color.White;
            this.MatchCatchBallBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchCatchBallBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchCatchBallBox.ForeColor = System.Drawing.Color.Black;
            this.MatchCatchBallBox.FormattingEnabled = true;
            this.MatchCatchBallBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.MatchCatchBallBox.Location = new System.Drawing.Point(214, 248);
            this.MatchCatchBallBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatchCatchBallBox.Name = "MatchCatchBallBox";
            this.MatchCatchBallBox.Size = new System.Drawing.Size(566, 33);
            this.MatchCatchBallBox.TabIndex = 11;
            this.MatchCatchBallBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // MatchCatchBallLabel
            // 
            this.MatchCatchBallLabel.Location = new System.Drawing.Point(26, 252);
            this.MatchCatchBallLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatchCatchBallLabel.Name = "MatchCatchBallLabel";
            this.MatchCatchBallLabel.Size = new System.Drawing.Size(176, 37);
            this.MatchCatchBallLabel.TabIndex = 8;
            this.MatchCatchBallLabel.Text = "Catch Ball";
            this.MatchCatchBallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatchPassBallBox
            // 
            this.MatchPassBallBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchPassBallBox.BackColor = System.Drawing.Color.White;
            this.MatchPassBallBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchPassBallBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchPassBallBox.ForeColor = System.Drawing.Color.Black;
            this.MatchPassBallBox.FormattingEnabled = true;
            this.MatchPassBallBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.MatchPassBallBox.Location = new System.Drawing.Point(214, 200);
            this.MatchPassBallBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatchPassBallBox.Name = "MatchPassBallBox";
            this.MatchPassBallBox.Size = new System.Drawing.Size(566, 33);
            this.MatchPassBallBox.TabIndex = 10;
            this.MatchPassBallBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // MatchPassBallLabel
            // 
            this.MatchPassBallLabel.Location = new System.Drawing.Point(26, 202);
            this.MatchPassBallLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatchPassBallLabel.Name = "MatchPassBallLabel";
            this.MatchPassBallLabel.Size = new System.Drawing.Size(176, 37);
            this.MatchPassBallLabel.TabIndex = 9;
            this.MatchPassBallLabel.Text = "Pass Ball";
            this.MatchPassBallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatchHighGoalAutoBox
            // 
            this.MatchHighGoalAutoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchHighGoalAutoBox.BackColor = System.Drawing.Color.White;
            this.MatchHighGoalAutoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchHighGoalAutoBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchHighGoalAutoBox.ForeColor = System.Drawing.Color.Black;
            this.MatchHighGoalAutoBox.FormattingEnabled = true;
            this.MatchHighGoalAutoBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.MatchHighGoalAutoBox.Location = new System.Drawing.Point(214, 152);
            this.MatchHighGoalAutoBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatchHighGoalAutoBox.Name = "MatchHighGoalAutoBox";
            this.MatchHighGoalAutoBox.Size = new System.Drawing.Size(566, 33);
            this.MatchHighGoalAutoBox.TabIndex = 7;
            this.MatchHighGoalAutoBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // MatchHighGoalAutoLable
            // 
            this.MatchHighGoalAutoLable.Location = new System.Drawing.Point(8, 154);
            this.MatchHighGoalAutoLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatchHighGoalAutoLable.Name = "MatchHighGoalAutoLable";
            this.MatchHighGoalAutoLable.Size = new System.Drawing.Size(196, 37);
            this.MatchHighGoalAutoLable.TabIndex = 6;
            this.MatchHighGoalAutoLable.Text = "High Goal in Auto";
            this.MatchHighGoalAutoLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatchLowGoalAutoBox
            // 
            this.MatchLowGoalAutoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchLowGoalAutoBox.BackColor = System.Drawing.Color.White;
            this.MatchLowGoalAutoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchLowGoalAutoBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchLowGoalAutoBox.ForeColor = System.Drawing.Color.Black;
            this.MatchLowGoalAutoBox.FormattingEnabled = true;
            this.MatchLowGoalAutoBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.MatchLowGoalAutoBox.Location = new System.Drawing.Point(214, 104);
            this.MatchLowGoalAutoBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatchLowGoalAutoBox.Name = "MatchLowGoalAutoBox";
            this.MatchLowGoalAutoBox.Size = new System.Drawing.Size(566, 33);
            this.MatchLowGoalAutoBox.TabIndex = 4;
            this.MatchLowGoalAutoBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // MatchLowGoalAutoLabel
            // 
            this.MatchLowGoalAutoLabel.Location = new System.Drawing.Point(28, 106);
            this.MatchLowGoalAutoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatchLowGoalAutoLabel.Name = "MatchLowGoalAutoLabel";
            this.MatchLowGoalAutoLabel.Size = new System.Drawing.Size(176, 37);
            this.MatchLowGoalAutoLabel.TabIndex = 0;
            this.MatchLowGoalAutoLabel.Text = "Low Goal in Auto";
            this.MatchLowGoalAutoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatchDriveForwardBox
            // 
            this.MatchDriveForwardBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchDriveForwardBox.BackColor = System.Drawing.Color.White;
            this.MatchDriveForwardBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchDriveForwardBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchDriveForwardBox.ForeColor = System.Drawing.Color.Black;
            this.MatchDriveForwardBox.FormattingEnabled = true;
            this.MatchDriveForwardBox.Items.AddRange(new object[] {
            "Unknown",
            "Yes",
            "No"});
            this.MatchDriveForwardBox.Location = new System.Drawing.Point(214, 56);
            this.MatchDriveForwardBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatchDriveForwardBox.Name = "MatchDriveForwardBox";
            this.MatchDriveForwardBox.Size = new System.Drawing.Size(566, 33);
            this.MatchDriveForwardBox.TabIndex = 3;
            this.MatchDriveForwardBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedValueChanged);
            // 
            // MatchDriveForwardLabel
            // 
            this.MatchDriveForwardLabel.Location = new System.Drawing.Point(28, 56);
            this.MatchDriveForwardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MatchDriveForwardLabel.Name = "MatchDriveForwardLabel";
            this.MatchDriveForwardLabel.Size = new System.Drawing.Size(176, 37);
            this.MatchDriveForwardLabel.TabIndex = 0;
            this.MatchDriveForwardLabel.Text = "Drive Forward";
            this.MatchDriveForwardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatchPerformanceRadioButton
            // 
            this.MatchPerformanceRadioButton.AutoSize = true;
            this.MatchPerformanceRadioButton.Location = new System.Drawing.Point(2, 420);
            this.MatchPerformanceRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.MatchPerformanceRadioButton.Name = "MatchPerformanceRadioButton";
            this.MatchPerformanceRadioButton.Size = new System.Drawing.Size(230, 29);
            this.MatchPerformanceRadioButton.TabIndex = 9;
            this.MatchPerformanceRadioButton.Text = "Match Performance";
            this.MatchPerformanceRadioButton.UseVisualStyleBackColor = true;
            this.MatchPerformanceRadioButton.CheckedChanged += new System.EventHandler(this.MatchPerformanceRadioButton_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(248, 819);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(146, 67);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(411, 819);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(137, 71);
            this.ImportButton.TabIndex = 9;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ExportMenuButton
            // 
            this.ExportMenuButton.Location = new System.Drawing.Point(13, 627);
            this.ExportMenuButton.Name = "ExportMenuButton";
            this.ExportMenuButton.Size = new System.Drawing.Size(305, 73);
            this.ExportMenuButton.TabIndex = 10;
            this.ExportMenuButton.Text = "Export";
            this.ExportMenuButton.UseVisualStyleBackColor = true;
            this.ExportMenuButton.Click += new System.EventHandler(this.ExportMenuButton_Click);
            // 
            // ImportMenuButton
            // 
            this.ImportMenuButton.Location = new System.Drawing.Point(13, 744);
            this.ImportMenuButton.Name = "ImportMenuButton";
            this.ImportMenuButton.Size = new System.Drawing.Size(305, 73);
            this.ImportMenuButton.TabIndex = 11;
            this.ImportMenuButton.Text = "Import";
            this.ImportMenuButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 912);
            this.Controls.Add(this.ImportMenuButton);
            this.Controls.Add(this.ExportMenuButton);
            this.Controls.Add(this.RobotGroupBox);
            this.Controls.Add(this.MatchPerformanceRadioButton);
            this.Controls.Add(this.MatchPerformanceGroupBox);
            this.Controls.Add(this.ScoutsDetailsRadioButton);
            this.Controls.Add(this.RobotPerRadioButton);
            this.Controls.Add(this.HumanControlGroupBox);
            this.Controls.Add(this.AutonomousDetailsGroupBox);
            this.Controls.Add(this.TeamDetailsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(610, 696);
            this.Name = "MainForm";
            this.Text = "Aerial Assist Scouting";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HumanControlGroupBox.ResumeLayout(false);
            this.AutonomousDetailsGroupBox.ResumeLayout(false);
            this.TeamDetailsGroupBox.ResumeLayout(false);
            this.TeamDetailsGroupBox.PerformLayout();
            this.RobotGroupBox.ResumeLayout(false);
            this.RobotGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RobotPictureBox)).EndInit();
            this.MatchPerformanceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox HighGoalBox;
        internal System.Windows.Forms.Label HighGoalLabel;
        internal System.Windows.Forms.ComboBox LowGoalBox;
        internal System.Windows.Forms.Label LowGoalLabel;
        internal System.Windows.Forms.ComboBox MiddleBarBox;
        internal System.Windows.Forms.Label MiddleBarLabel;
        internal System.Windows.Forms.ComboBox PickUpBallBox;
        internal System.Windows.Forms.Label PickUpBallLabel;
        internal System.Windows.Forms.ComboBox CatchBallBox;
        internal System.Windows.Forms.Label CatchBallLabel;
        internal System.Windows.Forms.ComboBox PassBallBox;
        internal System.Windows.Forms.Label PassBallLabel;
        internal System.Windows.Forms.GroupBox HumanControlGroupBox;
        internal System.Windows.Forms.ComboBox AutoHighGoalBox;
        internal System.Windows.Forms.Label AutoHighGoalLabel;
        internal System.Windows.Forms.ComboBox AutoLowGoalBox;
        internal System.Windows.Forms.Label AutoLowGoalLabel;
        internal System.Windows.Forms.ComboBox AutoForwardBox;
        internal System.Windows.Forms.GroupBox AutonomousDetailsGroupBox;
        internal System.Windows.Forms.Label AutoForwardLabel;
        internal System.Windows.Forms.TextBox TeamNameBox;
        internal System.Windows.Forms.Label TeamNameLabel;
        internal System.Windows.Forms.TextBox TeamNumberBox;
        internal System.Windows.Forms.Label TeamNumberLabel;
        internal System.Windows.Forms.GroupBox TeamDetailsGroupBox;
        private System.Windows.Forms.RadioButton RobotPerRadioButton;
        private System.Windows.Forms.RadioButton ScoutsDetailsRadioButton;
        internal System.Windows.Forms.GroupBox RobotGroupBox;
        internal System.Windows.Forms.ComboBox OverallAttackBox;
        internal System.Windows.Forms.Label OverallAttackLabel;
        internal System.Windows.Forms.ComboBox SpeedBox;
        internal System.Windows.Forms.Label SpeedLabel;
        internal System.Windows.Forms.ComboBox ManeuverabilityBox;
        internal System.Windows.Forms.Label ManeuverabilityLabel;
        internal System.Windows.Forms.ComboBox OverallDefenseBox;
        internal System.Windows.Forms.Label OverallDefenseLabel;
        internal System.Windows.Forms.GroupBox MatchPerformanceGroupBox;
        internal System.Windows.Forms.ComboBox MatchHighGoalAutoBox;
        internal System.Windows.Forms.Label MatchHighGoalAutoLable;
        internal System.Windows.Forms.ComboBox MatchLowGoalAutoBox;
        internal System.Windows.Forms.Label MatchLowGoalAutoLabel;
        internal System.Windows.Forms.ComboBox MatchDriveForwardBox;
        internal System.Windows.Forms.Label MatchDriveForwardLabel;
        internal System.Windows.Forms.ComboBox MatchCollectBallBox;
        internal System.Windows.Forms.Label MatchCollectBallLabel;
        internal System.Windows.Forms.ComboBox MatchCatchBallBox;
        internal System.Windows.Forms.Label MatchCatchBallLabel;
        internal System.Windows.Forms.ComboBox MatchPassBallBox;
        internal System.Windows.Forms.Label MatchPassBallLabel;
        private System.Windows.Forms.RadioButton MatchPerformanceRadioButton;
        internal System.Windows.Forms.ComboBox MatchHighGoalBox;
        internal System.Windows.Forms.ComboBox MatchLowGoalBox;
        internal System.Windows.Forms.ComboBox MatchThrowOverBox;
        internal System.Windows.Forms.Label MatchLowGoalLabel;
        internal System.Windows.Forms.Label MatchHighGoalLabel;
        internal System.Windows.Forms.Label MatchThrowOverLabel;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox RobotDescriptionBox;
        internal System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button AddPictureButton;
        private System.Windows.Forms.PictureBox RobotPictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportMenuButton;
        private System.Windows.Forms.Button ImportMenuButton;
    }
}