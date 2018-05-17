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

                var newLine = string.Join(",", TeamNumberBox.Text, TeamNameBox.Text, MatchNumberTextBox.Text, AutoForwardBox.Text, AutoLowGoalBox.Text, AutoHighGoalBox.Text, PassBallBox.Text, CatchBallBox.Text, PickUpBallBox.Text, MiddleBarBox.Text, LowGoalBox.Text, HighGoalBox.Text);
                csv.AppendLine(newLine);
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "ScoutData" + ".csv", csv.ToString());
            }
            Console.WriteLine("Match write:" + MatchDataFilled());
            Boolean MatchDataChange = MatchDataFilled();
            if (MatchDataFilled()) {
                var csv = new StringBuilder();

                var newLine = string.Join(",", TeamNumberBox.Text, TeamNameBox.Text, MatchNumberTextBox.Text, OverallDefenseBox.Text, ManeuverabilityBox.Text, SpeedBox.Text, OverallAttackBox.Text, RobotDescriptionBox.Text, MatchDriveForwardBox.Text, MatchLowGoalAutoBox.Text, MatchHighGoalAutoBox.Text, MatchPassBallBox.Text, MatchCatchBallBox.Text, MatchCollectBallBox.Text, MatchThrowOverBox.Text, MatchLowGoalBox.Text, MatchHighGoalBox.Text, Score.Text);
                csv.AppendLine(newLine);
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "MatchData" + ".csv", csv.ToString());
            }

            if (TeamNumberBox.Text == "")
            {                //Check if number is present
                MessageBox.Show("Failed: No team number. Please update the data and re-export.");
            }
            else if (TeamNameBox.Text == "")
            {                //Check if name is present
                MessageBox.Show("Failed: No team name. Please update the data and re-export.");
            }
            else if (MatchNumberTextBox.Text == "")
            {                //Check if name is present
                MessageBox.Show("Failed: No match number. Please update the data and re-export.");
            }
            else if (ScoutDataChange == false && MatchDataChange == false)
            {
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
            if (OverallDefenseBox.Text!="Unknown"|| ManeuverabilityBox.Text != "Unknown" || SpeedBox.Text != "Unknown" || OverallAttackBox.Text != "Unknown" || RobotDescriptionBox.Text != "")
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

        private void HumanControlGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ImportMenuButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Roborts File Explorer";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(fdlg.FileName.Split('\\')[fdlg.FileName.Split('\\').Length-1].Split('.')[0]);
                
                using (var reader = new StreamReader(fdlg.FileName))
                {
                    String fileName = fdlg.FileName.Split('\\')[fdlg.FileName.Split('\\').Length - 1].Split('.')[0];

                    List<string> TeamNumber = new List<string>();
                    List<string> TeamName = new List<string>();
                    List<string> MatchNumber = new List<string>();

                    if (fileName == "ScoutData")
                    {
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
                            MatchNumber.Add(values[2]);

                            AutoForward.Add(values[3]);
                            AutoLow.Add(values[4]);
                            AutoHigh.Add(values[5]);

                            HumanPass.Add(values[6]);
                            HumanCatch.Add(values[7]);
                            HumanPickUp.Add(values[8]);
                            HumanMiddle.Add(values[9]);
                            HumanLow.Add(values[10]);
                            HumanHigh.Add(values[11]);
                        }
                        TeamNumberBox.Text = TeamNumber[0];
                        TeamNameBox.Text = TeamName[0];
                        MatchNumberTextBox.Text = MatchNumber[0];

                        AutoForwardBox.Text = AutoForward[0];
                        AutoLowGoalBox.Text = AutoLow[0];
                        AutoHighGoalBox.Text = AutoHigh[0];

                        PassBallBox.Text = HumanPass[0];
                        CatchBallBox.Text = HumanCatch[0];
                        PickUpBallBox.Text = HumanPickUp[0];
                        MiddleBarBox.Text = HumanMiddle[0];
                        LowGoalBox.Text = HumanLow[0];
                        HighGoalBox.Text = HumanHigh[0];

                    }else if (fileName == "MatchData")
                    {
                        List<string> OverallDefense = new List<string>();
                        List<string> Maneuverability = new List<string>();
                        List<string> Speed = new List<string>();
                        List<string> OverallAttack = new List<string>();
                        List<string> RobotDescription = new List<string>();

                        List<string> MatchDriveForward = new List<string>();
                        List<string> MatchLowGoalAuto = new List<string>();
                        List<string> MatchHighGoalAuto = new List<string>();
                        List<string> MatchPassBall = new List<string>();
                        List<string> MatchCatchBall = new List<string>();
                        List<string> MatchCollectBall = new List<string>();
                        List<string> MatchThrowOver = new List<string>();
                        List<string> MatchLowGoal = new List<string>();
                        List<string> MatchHighGoal = new List<string>();
                        List<string> ScoreArray = new List<string>();

                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');

                            TeamNumber.Add(values[0]);
                            TeamName.Add(values[1]);
                            MatchNumber.Add(values[2]);

                            OverallDefense.Add(values[3]);
                            Maneuverability.Add(values[4]);
                            Speed.Add(values[5]);
                            OverallAttack.Add(values[6]);
                            RobotDescription.Add(values[7]);

                            MatchDriveForward.Add(values[8]);
                            MatchLowGoalAuto.Add(values[9]);
                            MatchHighGoalAuto.Add(values[10]);
                            MatchPassBall.Add(values[11]);
                            MatchCatchBall.Add(values[12]);
                            MatchCollectBall.Add(values[13]);
                            MatchThrowOver.Add(values[14]);
                            MatchLowGoal.Add(values[15]);
                            MatchHighGoal.Add(values[16]);
                            ScoreArray.Add(values[17]);
                        }
                        TeamNumberBox.Text = TeamNumber[0];
                        TeamNameBox.Text = TeamName[0];
                        MatchNumberTextBox.Text = MatchNumber[0];

                        OverallDefenseBox.Text = OverallDefense[0];
                        ManeuverabilityBox.Text = Maneuverability[0];
                        SpeedBox.Text = Speed[0];
                        OverallAttackBox.Text = OverallAttack[0];
                        RobotDescriptionBox.Text = RobotDescription[0];

                        MatchDriveForwardBox.Text = MatchDriveForward[0];
                        MatchLowGoalAutoBox.Text = MatchLowGoalAuto[0];
                        MatchHighGoalAutoBox.Text = MatchHighGoalAuto[0];
                        MatchPassBallBox.Text = MatchPassBall[0];
                        MatchCatchBallBox.Text = MatchCatchBall[0];
                        MatchCollectBallBox.Text = MatchCollectBall[0];
                        MatchThrowOverBox.Text = MatchThrowOver[0];
                        MatchLowGoalBox.Text = MatchLowGoal[0];
                        MatchHighGoalBox.Text = MatchHighGoal[0];
                        Score.Text = ScoreArray[0];
                    }
                    else
                    {
                        MessageBox.Show("File import failed. File was invalid, please try again.");
                    }
                }

            }
        }
    }
}
