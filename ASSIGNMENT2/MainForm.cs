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
            this.OverallAttackBox.SelectedIndex = 0;
            this.SpeedBox.SelectedIndex = 0;
            this.ManeuverabilityBox.SelectedIndex = 0;
            this.OverallDefenseBox.SelectedIndex = 0;
            RobotGroupBox.Visible = false;
            MatchPerformanceGroupBox.Visible = false;
            AutonomousDetailsGroupBox.Visible = false;
            HumanControlGroupBox.Visible = false;
            TeamDetailsGroupBox.Visible = false;
            ScorePointsGroupBox.Visible = false;
            MatchNumberGroupBox.Visible = false;
            MenuGroupBox.Visible = true;
        }

        private void AddPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string image = openFileDialog.FileName;
                RobotPictureBox.Image = Image.FromFile(@image);
                RobotCopyPictureBox.Image = Image.FromFile(@image);
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
            Console.WriteLine("Scout write:"+ ScoutDataFilled());
            Boolean ScoutDataChange = ScoutDataFilled();
            if (ScoutDataChange) {
                var csv = new StringBuilder();

                var newLine = string.Join(",", TeamNumberBox.Text, TeamNameBox.Text ,AutoForwardBox.Text, AutoLowGoalBox.Text, AutoHighGoalBox.Text, PassBallBox.Text, CatchBallBox.Text, PickUpBallBox.Text, MiddleBarBox.Text, LowGoalBox.Text, HighGoalBox.Text);
                csv.AppendLine(newLine);
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "ScoutData" + ".csv", csv.ToString());
            }
            Console.WriteLine("Match write:" + MatchDataFilled());
            Boolean MatchDataChange = MatchDataFilled();
            if (MatchDataFilled()) {
                var csv = new StringBuilder();

                var newLine = string.Join(",", TeamNumberBox.Text, TeamNameBox.Text, OverallDefenseBox.Text, ManeuverabilityBox.Text, SpeedBox.Text, OverallAttackBox.Text, RobotDescriptionBox.Text, MatchDriveForwardBox.Text, MatchLowGoalAutoBox.Text, MatchHighGoalAutoBox.Text, MatchPassBallBox.Text, MatchCatchBallBox.Text, MatchCollectBallBox.Text, MatchThrowOverBox.Text, MatchLowGoalBox.Text, MatchHighGoalBox.Text, Score.Text);
                csv.AppendLine(newLine);
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "MatchData" + ".csv", csv.ToString());
            }
            if (ScoutDataChange == false && MatchDataChange == false) {
                MessageBox.Show("Failed: No data to export. Please update the data and re-export.");
            }
            else
            {
                if (ScoutDataChange && MatchDataChange) {
                    MessageBox.Show("Successfully exported:\n 2 data files exported \n Scout Data exported \n Match Data exported");
                }else if (ScoutDataChange)
                {
                    MessageBox.Show("Successfully exported:\n 1 data files exported \n Scout Data exported \n No match data to export");
                }
                else
                {
                    MessageBox.Show("Successfully exported:\n 1 data files exported \n Match Data exported \n No scout data to export");
                }
            }

        }

        public Boolean ScoutDataFilled()
        {
            //Scouts details
            if (AutoForwardBox.Text != "Unknown" || AutoLowGoalBox.Text != "Unknown" || AutoForwardBox.Text != "Unknown" || PassBallBox.Text != "Unknown" || CatchBallBox.Text != "Unknown" || PickUpBallBox.Text != "Unknown" || MiddleBarBox.Text != "Unknown" || LowGoalBox.Text != "Unknown" || HighGoalBox.Text != "Unknown")
            {
                return true;
            }

            return false;
        }
        public Boolean MatchDataFilled()
        {
            //Robot Performance any data entered
            if (OverallDefenseBox.Text + ManeuverabilityBox.Text + SpeedBox.Text + OverallAttackBox.Text + RobotDescriptionBox.Text != "")
            {
                return true;
            }
            //Match Performace
            if (MatchDriveForwardBox.Text!="Unknown"||MatchLowGoalAutoBox.Text != "Unknown" || MatchHighGoalAutoBox.Text != "Unknown" || MatchPassBallBox.Text != "Unknown" || MatchCatchBallBox.Text != "Unknown" || MatchCollectBallBox.Text != "Unknown" || MatchThrowOverBox.Text != "Unknown" || MatchLowGoalBox.Text != "Unknown" || MatchHighGoalBox.Text != "Unknown")
            {
                return true;
            }
            //Score board
            if (Score.Text != "0")
            {
                return true;
            }
            return false;
        }

        private void RobotPerformanceButton_Click(object sender, EventArgs e)
        {
            MenuGroupBox.Visible = false;
            TeamDetailsGroupBox.Visible = true;
            MatchNumberGroupBox.Visible = true;
            AutonomousDetailsGroupBox.Visible = false;
            HumanControlGroupBox.Visible = false;
            RobotGroupBox.Visible = true;
            MatchPerformanceGroupBox.Visible = false;
            ScorePointsGroupBox.Visible = false;
        }

        private void ScoutsDetailsButton_Click(object sender, EventArgs e)
        {
            MenuGroupBox.Visible = false;
            TeamDetailsGroupBox.Visible = true;
            MatchNumberGroupBox.Visible = true;
            AutonomousDetailsGroupBox.Visible = true;
            HumanControlGroupBox.Visible = true;
            RobotGroupBox.Visible = false;
            MatchPerformanceGroupBox.Visible = false;
            ScorePointsGroupBox.Visible = false;
        }

        private void MatchPerformanceButton_Click(object sender, EventArgs e)
        {
            MenuGroupBox.Visible = false;
            TeamDetailsGroupBox.Visible = true;
            MatchNumberGroupBox.Visible = true;
            AutonomousDetailsGroupBox.Visible = false;
            HumanControlGroupBox.Visible = false;
            RobotGroupBox.Visible = false;
            MatchPerformanceGroupBox.Visible = true;
            ScorePointsGroupBox.Visible = false;
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            MenuGroupBox.Visible = false;
            TeamDetailsGroupBox.Visible = true;
            MatchNumberGroupBox.Visible = true;
            AutonomousDetailsGroupBox.Visible = false;
            HumanControlGroupBox.Visible = false;
            RobotGroupBox.Visible = false;
            MatchPerformanceGroupBox.Visible = false;
            ScorePointsGroupBox.Visible = true;
        }

        private void CatchingButton_Click(object sender, EventArgs e)
        {
            Score.Text = (10 + Double.Parse(Score.Text)).ToString();
        }

        private void AutoDrivingForwardButton_Click(object sender, EventArgs e)
        {
            Score.Text = (5 + Double.Parse(Score.Text)).ToString();
        }

        private void AutoLowGoalButton_Click(object sender, EventArgs e)
        {
            Score.Text = (6 + Double.Parse(Score.Text)).ToString();
        }

        private void AutoHighGoalButton_Click(object sender, EventArgs e)
        {
            Score.Text = (15 + Double.Parse(Score.Text)).ToString();
        }

        private void LowGoalButton_Click(object sender, EventArgs e)
        {
            Score.Text = (1 + Double.Parse(Score.Text)).ToString();
        }

        private void HighGoalButton_Click(object sender, EventArgs e)
        {
            Score.Text = (10 + Double.Parse(Score.Text)).ToString();
        }

        private void OverMiddleBarButton_Click(object sender, EventArgs e)
        {
            Score.Text = (10 + Double.Parse(Score.Text)).ToString();
        }

        private void FirstPassButton_Click(object sender, EventArgs e)
        {
            Score.Text = (10 + Double.Parse(Score.Text)).ToString();
        }

        private void SecondPassButton_Click(object sender, EventArgs e)
        {
            Score.Text = (20 + Double.Parse(Score.Text)).ToString();
        }

        private void MatchNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
