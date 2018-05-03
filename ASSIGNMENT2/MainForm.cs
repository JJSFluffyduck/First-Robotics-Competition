﻿using System;
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
          
        }

        private void TeamDetailsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AutonomousDetailsGroupBox.Visible = true;
            HumanControlGroupBox.Visible = true;

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            AutonomousDetailsGroupBox.Visible = false;
            HumanControlGroupBox.Visible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //before your loop
            var csv = new StringBuilder();

            //in your loop
            var first = TeamNumberBox.Text;
            var second = TeamNameBox.Text;
            var newLine = string.Format("{0},{1}", first, second);
            csv.AppendLine(newLine);

            //after your loop
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "test" +".csv", csv.ToString());
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
