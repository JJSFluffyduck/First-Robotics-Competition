using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT2
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        //All ComboBox use this funtion
        private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var cb = ((ComboBox)sender);
            cb.BackColor = Color.White;
            switch (cb.SelectedIndex)
            {
                //Unknow
                case 0:
                    cb.BackColor = Color.Orange;
                    break;
                // ' Yes

                case 1:
                    cb.BackColor = Color.Green;
                    break;
                // ' No

                case 2:
                    cb.BackColor = Color.Red;
                    break;
            }
        }

        private void TeamNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.HighGoalBox.SelectedIndex = 0;
            this.LowGoalBox.SelectedIndex = 0;
            this.MiddleBarBox.SelectedIndex = 0;
            this.PickUpBallBox.SelectedIndex = 0;
            this.CatchBallBox.SelectedIndex = 0;
            this.AutoHighGoalBox.SelectedIndex = 0;
            this.AutoLowGoalBox.SelectedIndex = 0;
            this.PassBallBox.SelectedIndex = 0;
            this.AutoForwardBox.SelectedIndex = 0;
            this.MatchDriveForwardBox.SelectedIndex = 0;
            this.MatchHighGoalAutoBox.SelectedIndex = 0;
            this.MatchLowGoalAutoBox.SelectedIndex = 0;
            this.MatchPassBallBox.SelectedIndex = 0;
            this.MatchCatchBallBox.SelectedIndex = 0;
            this.MatchCollectBallBox.SelectedIndex = 0;
            this.MatchThrowOverBox.SelectedIndex = 0;
            this.MatchLowGoalBox.SelectedIndex = 0;
            this.MatchHighGoalBox.SelectedIndex = 0;

            RobotGroupBox.Visible = true;

        }

        private void RobotPerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void ScoutsDetailsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void MatchPerformanceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay() {
            System.Diagnostics.Debug.WriteLine("test");
            System.Diagnostics.Debug.WriteLine(RobotPerRadioButton.Checked);

            AutonomousDetailsGroupBox.Visible = false;
            HumanControlGroupBox.Visible = false;
            RobotGroupBox.Visible = false;
            MatchPerformanceGroupBox.Visible = false;

            if (RobotPerRadioButton.Checked)
            {
                RobotGroupBox.Visible = true;
            }
            else if (ScoutsDetailsRadioButton.Checked)
            {
                AutonomousDetailsGroupBox.Visible = true;
                HumanControlGroupBox.Visible = true;
            }
            else if (MatchPerformanceRadioButton.Checked)
            {
                MatchPerformanceGroupBox.Visible = true;
            }
        }

        private void AddPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string image = openFileDialog.FileName;
                RobotPictureBox.Image = Image.FromFile(@image);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

        }

        private void ExportMenuButton_Click(object sender, EventArgs e)
        {
            //before your loop
            var csv = new StringBuilder();

            //in your loop
            var TeamNumber = TeamNumberBox.Text;
            var TeamName = TeamNameBox.Text;

            var AutoForward = AutoForwardBox.Text;
            var AutoLow = AutoLowGoalBox.Text;
            var AutoHigh = AutoHighGoalBox.Text;

            var HumanPass = PassBallBox.Text;
            var HumanCatch = CatchBallBox.Text;
            var HumanPickUp = PickUpBallBox.Text;
            var HumanMiddle = MiddleBarBox.Text;
            var HumanLow = LowGoalBox.Text;
            var HumanHigh = HighGoalBox.Text;

            var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", TeamNumber, TeamName, AutoForward, AutoLow, AutoHigh, HumanPass, HumanCatch, HumanPickUp, HumanMiddle, HumanLow, HumanHigh);
            csv.AppendLine(newLine);

            //after your loop
            if (RobotPerRadioButton.Checked)
            {
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "PreGame" + ".csv", csv.ToString());
            }
            else
            {
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "DuringGame" + ".csv", csv.ToString());
            }
        }

        private void ImportMenuButton_Click(object sender, EventArgs e)
        {
    }

        private void ImportMenuButton_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Roborts File Explorer";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(fdlg.FileName);
                using (var reader = new StreamReader(fdlg.FileName))
                {
                    List<string> TeamNumber = new List<string>();
                    List<string> TeamName = new List<string>();

                    List<string> AutoForward = new List<string>();
                    List<string> AutoLow = new List<string>();
                    List<string> AutoHigh = new List<string>();

                    List<string> HumanPass = new List<string>();
                    List<string> HumanCatch = new List<string>();
                    List<string> HumanPickUp = new List<string>();
                    List<string> HumanMiddle = new List<string>();
                    List<string> HumanLow = new List<string>();
                    List<string> HumanHigh = new List<string>();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        TeamNumber.Add(values[0]);
                        TeamName.Add(values[1]);

                        AutoForward.Add(values[2]);
                        AutoLow.Add(values[3]);
                        AutoHigh.Add(values[4]);

                        HumanPass.Add(values[5]);
                        HumanCatch.Add(values[6]);
                        HumanPickUp.Add(values[7]);
                        HumanMiddle.Add(values[8]);
                        HumanLow.Add(values[9]);
                        HumanHigh.Add(values[10]);
                    }
                    TeamNumberBox.Text = TeamNumber[0];
                    TeamNameBox.Text = TeamName[0];

                    AutoForwardBox.Text = AutoForward[0];
                    AutoLowGoalBox.Text = AutoLow[0];
                    AutoHighGoalBox.Text = AutoHigh[0];

                    PassBallBox.Text = HumanPass[0];
                    CatchBallBox.Text = HumanCatch[0];
                    PickUpBallBox.Text = HumanPickUp[0];
                    MiddleBarBox.Text = HumanMiddle[0];
                    LowGoalBox.Text = HumanLow[0];
                    HighGoalBox.Text = HumanHigh[0];


                }

            }
        }
    }
}
