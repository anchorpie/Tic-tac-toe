using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsButtonsGame
{
    public partial class Form1 : Form
    {
        bool isXturn = true;
        string playerNumber;

        Button[] allButtons;

        public Form1()
        {
            InitializeComponent();

            allButtons = new Button[] { 
                button1, button2, button3, 
                button4, button5, button6, 
                button7, button8, button9};

            button10.Visible = false;
            button10.TabStop = false;
        }

        public void OnButtonClick(Button sender)
        {
            sender.Text = TurnSwitch();
            sender.Enabled = false;
            WinnerCheck();
        }

        public void WinnerCheck()
        {
            if (button5.Text.Length > 0)
            {
                if ((button5.Text == button4.Text) && (button5.Text == button6.Text))
                {
                    ShowMatchResult();
                }
                if ((button5.Text == button2.Text) && (button5.Text == button8.Text))
                {
                    ShowMatchResult();
                }
                if ((button5.Text == button3.Text) && (button5.Text == button7.Text))
                {
                    ShowMatchResult();
                }
                if ((button5.Text == button1.Text) && (button5.Text == button9.Text))
                {
                    ShowMatchResult();
                }
            }
            if (button3.Text.Length > 0)
            {
                if ((button3.Text == button1.Text) && (button3.Text == button2.Text))
                {
                    ShowMatchResult();
                }
                if ((button3.Text == button6.Text) && (button3.Text == button9.Text))
                {
                    ShowMatchResult();
                }
            }
            if (button7.Text.Length > 0)
            {
                if ((button7.Text == button1.Text) && (button7.Text == button4.Text))
                {
                    ShowMatchResult();
                }
                if ((button7.Text == button8.Text) && (button7.Text == button9.Text))
                {
                    ShowMatchResult();
                }
            }

        }

        public void ShowMatchResult()
        {
            textBox1.Text = playerNumber + " WON";
            foreach (Button button in allButtons)
            {
                button.Enabled = false;
            }
            button10.Visible = true;
            button10.TabIndex = 1;
            button10.TabStop = true;
            
        }

        public string TurnSwitch()
        {
            string buttonSimbol = isXturn ? "X" : "O";
            playerNumber = isXturn ? "First player" : "Second player";
            isXturn = !isXturn;
            textBox1.Text = isXturn ? "First player turn" : "Second player turn";
            return buttonSimbol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnButtonClick(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnButtonClick(button2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OnButtonClick(button9);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OnButtonClick(button3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OnButtonClick(button6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OnButtonClick(button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OnButtonClick(button4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OnButtonClick(button8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OnButtonClick(button7);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "First player turn";

            foreach (Button button in allButtons)
            {
                button.Text = "";
                button.Enabled = true;
                isXturn = true;
            }
            button10.Visible = false;
            button10.TabStop = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
