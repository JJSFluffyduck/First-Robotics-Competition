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
            this.PreMatchCheck = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.HumanControlGroupBox.SuspendLayout();
            this.AutonomousDetailsGroupBox.SuspendLayout();
            this.TeamDetailsGroupBox.SuspendLayout();
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
            this.HighGoalBox.Size = new System.Drawing.Size(300, 33);
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
            this.LowGoalBox.Size = new System.Drawing.Size(300, 33);
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
            this.MiddleBarBox.Size = new System.Drawing.Size(300, 33);
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
            this.PickUpBallBox.Size = new System.Drawing.Size(300, 33);
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
            this.CatchBallBox.Size = new System.Drawing.Size(300, 33);
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
            this.PassBallBox.Size = new System.Drawing.Size(300, 33);
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
            this.HumanControlGroupBox.Location = new System.Drawing.Point(34, 440);
            this.HumanControlGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.HumanControlGroupBox.Name = "HumanControlGroupBox";
            this.HumanControlGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.HumanControlGroupBox.Size = new System.Drawing.Size(546, 348);
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
            this.AutoHighGoalBox.Size = new System.Drawing.Size(300, 33);
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
            this.AutoLowGoalBox.Size = new System.Drawing.Size(300, 33);
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
            this.AutoForwardBox.Size = new System.Drawing.Size(300, 33);
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
            this.AutonomousDetailsGroupBox.Location = new System.Drawing.Point(34, 210);
            this.AutonomousDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.AutonomousDetailsGroupBox.Name = "AutonomousDetailsGroupBox";
            this.AutonomousDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.AutonomousDetailsGroupBox.Size = new System.Drawing.Size(546, 223);
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
            this.TeamNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.TeamNumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.TeamDetailsGroupBox.Location = new System.Drawing.Point(34, 40);
            this.TeamDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.TeamDetailsGroupBox.Name = "TeamDetailsGroupBox";
            this.TeamDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.TeamDetailsGroupBox.Size = new System.Drawing.Size(546, 162);
            this.TeamDetailsGroupBox.TabIndex = 3;
            this.TeamDetailsGroupBox.TabStop = false;
            this.TeamDetailsGroupBox.Text = "Team Detailz";
            this.TeamDetailsGroupBox.Enter += new System.EventHandler(this.TeamDetailsGroupBox_Enter);
            // 
            // PreMatchCheck
            // 
            this.PreMatchCheck.AutoSize = true;
            this.PreMatchCheck.Checked = true;
            this.PreMatchCheck.Location = new System.Drawing.Point(302, 12);
            this.PreMatchCheck.Name = "PreMatchCheck";
            this.PreMatchCheck.Size = new System.Drawing.Size(141, 29);
            this.PreMatchCheck.TabIndex = 6;
            this.PreMatchCheck.TabStop = true;
            this.PreMatchCheck.Text = "Pre-match";
            this.PreMatchCheck.UseVisualStyleBackColor = true;
            this.PreMatchCheck.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(449, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(170, 29);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "During match";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 926);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.PreMatchCheck);
            this.Controls.Add(this.HumanControlGroupBox);
            this.Controls.Add(this.AutonomousDetailsGroupBox);
            this.Controls.Add(this.TeamDetailsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(620, 838);
            this.Name = "MainForm";
            this.Text = "Aerial Assist Scouting";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HumanControlGroupBox.ResumeLayout(false);
            this.AutonomousDetailsGroupBox.ResumeLayout(false);
            this.TeamDetailsGroupBox.ResumeLayout(false);
            this.TeamDetailsGroupBox.PerformLayout();
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
        private System.Windows.Forms.RadioButton PreMatchCheck;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ImportButton;
    }
}