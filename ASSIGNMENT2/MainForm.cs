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
using Microsoft.VisualBasic;


namespace ASSIGNMENT2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //
        //All ComboBox that in Match Performance and Scouts Detalis use this funtion have correct color for different status
        //"Unknow" type is orange, "Yes" type is green, and "No" type is red.
        //
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

        //
        //Team Number should only except numbers
        //
        private void TeamNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        //
        // Design layout when running this app
        // All combobox should show as "Unknow" before user choose.
        // Only Menu Buttons and a welcome page show up at the beginning.
        //
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

        //
        //If user cilck add picture button in robot performance,
        //app should show a pop-up box show up tp upload robot photo
        //
        private void AddPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string image = openFileDialog.FileName;
                // show in robot details which right to add picture button
                RobotPictureBox.Image = Image.FromFile(@image);
                // show in team details which is able to see when user choose other button on the menu
                RobotCopyPictureBox.Image = Image.FromFile(@image);
            }
        }


        private void ExportMenuButton_Click(object sender, EventArgs e)
        {
            //Create save files if not already present
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ScoutData" + ".csv") == false)
            {
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "ScoutData" + ".csv", "");
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "MatchData" + ".csv") == false)
            {
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "MatchData" + ".csv", "");
            }

            Boolean ScoutDataChange = ScoutDataFilled();
            if (ScoutDataChange)
            {
                int ScoutPosition =  UpdateFile("ScoutData", string.Join(",", TeamNumberBox.Text, TeamNameBox.Text, MatchNumberTextBox.Text, AutoForwardBox.Text, AutoLowGoalBox.Text, AutoHighGoalBox.Text, PassBallBox.Text, CatchBallBox.Text, PickUpBallBox.Text, MiddleBarBox.Text, LowGoalBox.Text, HighGoalBox.Text));
            }
            
            Boolean MatchDataChange = MatchDataFilled();
            if (MatchDataFilled()) {
                int MatchPosition = UpdateFile("MatchData", string.Join(",", TeamNumberBox.Text, TeamNameBox.Text, MatchNumberTextBox.Text, OverallDefenseBox.Text, ManeuverabilityBox.Text, SpeedBox.Text, OverallAttackBox.Text, RobotDescriptionBox.Text, MatchDriveForwardBox.Text, MatchLowGoalAutoBox.Text, MatchHighGoalAutoBox.Text, MatchPassBallBox.Text, MatchCatchBallBox.Text, MatchCollectBallBox.Text, MatchThrowOverBox.Text, MatchLowGoalBox.Text, MatchHighGoalBox.Text, Score.Text));
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

        public int UpdateFile(String FileName, String InputLine)
        {
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + FileName + ".csv", Encoding.UTF8);
            for (int i = 0; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');

                //team is already within file OverWrite
                if (values[0] == TeamNumberBox.Text && values[2]==MatchNumberTextBox.Text)
                {
                    lines[i] = InputLine;

                    File.WriteAllLines(
                        AppDomain.CurrentDomain.BaseDirectory + FileName + ".csv",
                        lines);

                    return i;
                }
            }

            File.AppendAllText(
                AppDomain.CurrentDomain.BaseDirectory + FileName + ".csv",
                InputLine + Environment.NewLine);

            return -1;
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

        //
        //If user click Robot Performance button, the app should show with team details, match number, and robot performance details
        //
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

        //
        //If user click Scouts Details button, the app should show with team details, 
        //match number,  autonomous details, and human control details
        //
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

        //
        //If user click Match Performance button, the app should show with team details, match number, and match performance
        //
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

        //
        //If user click Score Points button, the app should show with team details, match number, and score points
        //
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

        //
        //Catch ball should add 10 points
        //
        private void CatchingButton_Click(object sender, EventArgs e)
        {
            Score.Text = (10 + Double.Parse(Score.Text)).ToString();
        }

        //
        //Auto driving forward should add 5 points
        //
        private void AutoDrivingForwardButton_Click(object sender, EventArgs e)
        {
            Score.Text = (5 + Double.Parse(Score.Text)).ToString();
        }

        //
        //Auto low goal should add 6 points
        //
        private void AutoLowGoalButton_Click(object sender, EventArgs e)
        {
            Score.Text = (6 + Double.Parse(Score.Text)).ToString();
        }

        //
        //Auto high goal should add 15 points
        //
        private void AutoHighGoalButton_Click(object sender, EventArgs e)
        {
            Score.Text = (15 + Double.Parse(Score.Text)).ToString();
        }

        //
        //Low Goal by human control should add 1 point
        //
        private void LowGoalButton_Click(object sender, EventArgs e)
        {
            Score.Text = (1 + Double.Parse(Score.Text)).ToString();
        }

        //
        //High Goal by human control should add 10 points
        //
        private void HighGoalButton_Click(object sender, EventArgs e)
        {
            Score.Text = (10 + Double.Parse(Score.Text)).ToString();
        }

        //
        //Over Middle Bar should add 10 points
        //
        private void OverMiddleBarButton_Click(object sender, EventArgs e)
        {
            Score.Text = (10 + Double.Parse(Score.Text)).ToString();
        }

        //
        //First Pass should add 10 points
        //
        private void FirstPassButton_Click(object sender, EventArgs e)
        {
            Score.Text = (10 + Double.Parse(Score.Text)).ToString();
        }

        //
        //Second Pass should add 20 points
        //
        private void SecondPassButton_Click(object sender, EventArgs e)
        {
            Score.Text = (20 + Double.Parse(Score.Text)).ToString();
        }

        //
        //Match Number should only except numbers
        //
        private void MatchNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)(Keys.Back)))
            {
                e.Handled = true;
            }
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
                String fileName = fdlg.FileName.Split('\\')[fdlg.FileName.Split('\\').Length - 1].Split('.')[0];

                string UserInputTeam = Interaction.InputBox("What team number do you wish to import?", "Select Team", "");
                string UserInputMatch = Interaction.InputBox("What match from that team do you wish to import?", "Select Match", "");

                int TeamPosition = -1;
                string[] lines = File.ReadAllLines(fdlg.FileName, Encoding.UTF8);
                for (int i = 0; i < lines.Length; i++)
                {
                    var values = lines[i].Split(',');

                    //team is already within file OverWrite
                    if (values[0] == UserInputTeam && values[2] == UserInputMatch)
                    {
                        TeamPosition = i;

                        TeamNumberBox.Text = values[0];
                        TeamNameBox.Text = values[1];
                        MatchNumberTextBox.Text = values[2];

                        if (fileName == "ScoutData")
                        {
                            AutoForwardBox.Text = values[3];
                            AutoLowGoalBox.Text = values[4];
                            AutoHighGoalBox.Text = values[5];

                            PassBallBox.Text = values[6];
                            CatchBallBox.Text = values[7];
                            PickUpBallBox.Text = values[8];
                            MiddleBarBox.Text = values[9];
                            LowGoalBox.Text = values[10];
                            HighGoalBox.Text = values[11];

                            UpdateFile(fileName, lines[i]);

                            MessageBox.Show("Data successfully imported");
                        }
                        else if (fileName == "MatchData")
                        {
                            OverallDefenseBox.Text = values[3];
                            ManeuverabilityBox.Text = values[4];
                            SpeedBox.Text = values[5];
                            OverallAttackBox.Text = values[6];
                            RobotDescriptionBox.Text = values[7];

                            MatchDriveForwardBox.Text = values[8];
                            MatchLowGoalAutoBox.Text = values[9];
                            MatchHighGoalAutoBox.Text = values[10];
                            MatchPassBallBox.Text = values[11];
                            MatchCatchBallBox.Text = values[12];
                            MatchCollectBallBox.Text = values[13];
                            MatchThrowOverBox.Text = values[14];
                            MatchLowGoalBox.Text = values[15];
                            MatchHighGoalBox.Text = values[16];
                            Score.Text = values[17];

                            UpdateFile(fileName, lines[i]);

                            MessageBox.Show("Data successfully imported");
                        }
                        else
                        {
                            MessageBox.Show("File import failed. File was invalid, please try again.");
                        }
                    }
                }

                if (TeamPosition == -1) {
                    MessageBox.Show("Unable to find that match for that team, please check the data source.");
                }
            }
        }
    }
}
