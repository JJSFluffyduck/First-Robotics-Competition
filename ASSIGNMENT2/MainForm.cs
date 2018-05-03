using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private  void ComboBox_SelectedValueChanged(object sender, EventArgs e)
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
            RobotGroupBox.Visible = false;
            MatchPerformanceGroupBox.Visible = false;

        }

        private void RobotPerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AutonomousDetailsGroupBox.Visible = false;
            HumanControlGroupBox.Visible = false;
            RobotGroupBox.Visible = true;
            MatchPerformanceGroupBox.Visible = false;
        }

        private void ScoutsDetailsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AutonomousDetailsGroupBox.Visible = true;
            HumanControlGroupBox.Visible = true;
            RobotGroupBox.Visible = false;
            MatchPerformanceGroupBox.Visible = false;
        }

        private void MatchPerformanceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AutonomousDetailsGroupBox.Visible = false;
            HumanControlGroupBox.Visible = false;
            RobotGroupBox.Visible = false;
            MatchPerformanceGroupBox.Visible = true;
        }
    }
}
