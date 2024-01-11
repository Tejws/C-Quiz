using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Quiz_Game_in_Windows_Form_VS
{
    public partial class Form1 : Form
    {
        // quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if(buttonTag == correctAnswer)
            {
                score++;
            }
            if(questionNumber == totalQuestions)
            {
                // work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine + 
                    "You have answered " + score + " questions correctly." + Environment.NewLine + 
                    "Your total percentage is " + percentage + "%" + Environment.NewLine + 
                    "Click OK to play again"                 
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "What is the colour of the sky?";
                    button1.Text = "Blue";
                    button2.Text = "Yellow";
                    button3.Text = "Orange";
                    button4.Text = "Red";
                    correctAnswer = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "What is the name of the main character from Iron Man?";
                    button1.Text = "Tony Stank";
                    button2.Text = "Tony Stark";
                    button3.Text = "Rody";
                    button4.Text = "Peter Quill";
                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.csgo;
                    lblQuestion.Text = "What is the name of this game?";
                    button1.Text = "Call of Duty";
                    button2.Text = "Battlefield";
                    button3.Text = "Fortnite";
                    button4.Text = "CS - GO";
                    correctAnswer = 4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.fortnite;
                    lblQuestion.Text = "Which Publisher made this game?";
                    button1.Text = "EA";
                    button2.Text = "Activision";
                    button3.Text = "Epic Games";
                    button4.Text = "Equare Enix";
                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.gears_of_war;
                    lblQuestion.Text = "Whats the name of this game?";
                    button1.Text = "Gears of War";
                    button2.Text = "Assassins Creed";
                    button3.Text = "Uncharted";
                    button4.Text = "Call of Duty";
                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.halo;
                    lblQuestion.Text = "What is the main characters name in the game above?";
                    button1.Text = "Drake";
                    button2.Text = "Lara Croft";
                    button3.Text = "Master Cheif";
                    button4.Text = "Markus";
                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.witcher3;
                    lblQuestion.Text = "Who was Geralt looking for in Witcher 3?";
                    button1.Text = "Victoria";
                    button2.Text = "Mr Donut";
                    button3.Text = "Ciri";
                    button4.Text = "Yennifer";
                    correctAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Which city is the captial city of England?";
                    button1.Text = "Birmingham";
                    button2.Text = "Brighton";
                    button3.Text = "Liverpool";
                    button4.Text = "London";
                    correctAnswer = 4;
                    break;
            }
        }
    }
}
 