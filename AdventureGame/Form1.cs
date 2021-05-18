using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        Random randGen = new Random();
        int randomValue;

        public Form1()
        {
            InitializeComponent();
           
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            randomValue = randGen.Next(1, 11);
            if (page == 1)
            {
                page = 2;
            }
           else if (page == 2) { page = 1; }
           else if (page == 3) { page = 4; }
           else if (page == 4) { page = 5; }
           else if (page == 5)
            {
                if (randomValue > 7 && page == 5)
                {
                    page = 26;
                }
                else
                {
                    page = 7;
                }
            }
            else if (page == 7) { page = 9; }
            else if (page == 9) { page = 10; }
            else if (page == 10) { page = 1; }
            else if (page == 11) { page = 13; }
            else if (page == 12) { page = 1; }
            else if (page == 13) { page = 1; }
            else if (page == 8) { page = 16; }
            else if (page == 16) { page = 1; }
            else if (page == 17) { page = 19; }
            else if (page == 19) { page = 15; }
            else if (page == 15) { page = 1; }
            else if (page == 6) { page = 22; }
            else if (page == 22) { page = 1; }
            else if (page == 23) { page = 24; }
            else if (page == 25) { page = 1; }
            else if (page == 28) { page = 1; }
            else if (page == 21) { page = 1; }
            else if (page == 24) { page = 1; }
            else if (page == 18) { page = 1; }
            else if (page == 27) { page = 1; }
            else if (page == 26) { page = 1; }
            else if (page == 14) { page = 15; }
            


            DisplayPage();
        }
        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2) { page = 99; }
            else if (page == 3) { page = 28; }
            else if (page == 4) { page = 6; }
            else if (page == 7) { page = 14; }
            else if (page == 5) { page = 8; }
            else if (page == 9) { page = 11; }
            else if (page == 10) { page = 99; }
            else if (page == 11) { page = 12; }
            else if (page == 12) { page = 99; }
            else if (page == 13) { page = 99; }
            else if (page == 8) { page = 17; }
            else if (page == 16) { page = 99; }
            else if (page == 17) { page = 18; }
            else if (page == 19) { page = 20; }
            else if (page == 15) { page = 99; }
            else if (page == 6) { page = 23; }
            else if (page == 22) { page = 99; }
            else if (page == 23) { page = 25; }
            else if (page == 25) { page = 99; }
            else if (page == 28) { page = 99; }
            else if (page == 21) { page = 99; }
            else if (page == 24) { page = 99; }
            else if (page == 18) { page = 99; }
            else if (page == 27) { page = 99; }
            else if (page == 26) { page = 99; }
            else if (page == 14) { page = 27; }

            DisplayPage();
        }
        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 4)
            {
                page = 21;
            }
            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are walking through a forest when you realize it is getting dark.";
                    option1Label.Text = "Spend the night";
                    option2Label.Text = "Try to go back";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.deepBrush;
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources._517859__antonio_lai__forest);
                    player1.Play();
                    

                    break;
                case 2:
                    outputLabel.Text = "When you wake up the next day, you can see the path and make it out safely. Do you want to play again";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.Forest_path;
                   
                    break;
                case 3:
                    outputLabel.Text = "You try to go back the way you came but you can not see the path";

                    option1Label.Text = "Set up camp";
                    option2Label.Text = "Keep going";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.night_forest;
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources._465697__breviceps__owl_hoot);
                    player2.Play();

                    break;
                case 4:
                    outputLabel.Text = "When you wake up you realize you are lost";

                    option1Label.Text = "Look for food";
                    option2Label.Text = "Build fire";
                    option3Button.Enabled = true;
                    option3Label.Text = "Try to find path";
                    option3Label.Visible = true;
                    imageBox.Image = Properties.Resources.deepBrush;
                    break;
                case 5:
                    outputLabel.Text = "You come accross some berries, they look familiar and you don't think they are poisonous";

                    option1Label.Text = "Eat them";
                    option2Label.Text = "Do not";
                    option3Button.Enabled = false;
                    option3Label.Visible = false;
                    imageBox.Image = Properties.Resources.Berries;
                    break;
                case 6:
                    outputLabel.Text = "You rummage around collecting sticks and manage to start a fire";

                    option1Label.Text = "Sit around the fire";
                    option2Label.Text = "Try to find the path";
                    option3Button.Enabled = false;
                    option3Label.Visible = false;
                    imageBox.Image = Properties.Resources.Bonfire;
                    SoundPlayer player3 = new SoundPlayer(Properties.Resources._234288__leosalom__fireplace);
                    player3.Play();
                    break;
                case 7:
                    outputLabel.Text = "You feel replenished";

                    option1Label.Text = "Find path";
                    option2Label.Text = "Go back to camp";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.Berries;
                    break;
                case 8:
                    outputLabel.Text = "You decide it is too dangerous to eat them";

                    option1Label.Text = "Try to find more food";
                    option2Label.Text = "Go back to camp";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.Berries;
                    break;
                case 9:
                    outputLabel.Text = "You decide you should try to find the path";

                    option1Label.Text = "Go north";
                    option2Label.Text = "Go south";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.deepBrush;
                    break;
                case 10:
                    outputLabel.Text = "You find the path and make it out safely. Do you want to play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.Forest_path;
                    break;
                case 11:
                    outputLabel.Text = "You look for hours but do not find the path";

                    option1Label.Text = "Keep looking";
                    option2Label.Text = "Head back";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.deepBrush;
                    break;
                case 12:
                    outputLabel.Text = "As you start heading back, you step in a hole and break your leg. As you lay there, you here what appears to be a car in the direction you were heading. Unable to move, you lay there and die just short of saftey. Do you want to play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.deepBrush;
                    SoundPlayer player4 = new SoundPlayer(Properties.Resources._377003__audio_stock__car_passing_by);
                    player4.Play();
                    break;
                case 13:
                    outputLabel.Text = "You come accross a road and flag down an approaching vehicle and you make it to saftey. Do you want to play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.road;
                    SoundPlayer player5 = new SoundPlayer(Properties.Resources._377003__audio_stock__car_passing_by);
                    player5.Play();
                    break;
                case 14:
                    outputLabel.Text = "By the time you get back to camp it is getting dark.";

                    option1Label.Text = "Build fire";
                    option2Label.Text = "Got to sleep";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.night_forest;
                    break;
                case 15:
                    outputLabel.Text = "You build a fire and sit around for a while before going to bed. You are woken by footsteps. Someone saw the smoke of your fire and found you, they lead you out of the woods safely. Do you want to play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.Bonfire;
                    SoundPlayer player6 = new SoundPlayer(Properties.Resources._234288__leosalom__fireplace);
                    player6.Play();
                    break;
                case 16:
                    outputLabel.Text = "You head back to camp on an empty stomach. As you walk, you are attacked by a couger and cannot escape because you are too tired. You die. Do you want to play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.night_forest;
                    SoundPlayer player7 = new SoundPlayer(Properties.Resources._536331__xhwzq6gv__panther);
                    player7.Play();
                    break;
                case 17:
                    outputLabel.Text = "As you search you come accross some bluberries which you eat. It is getting dark by the time you finnish, an you don't know if you can find camp.";

                    option1Label.Text = "Try to find camp";
                    option2Label.Text = "Stay put";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.wildblueberries;
                    break;
                case 18:
                    outputLabel.Text = "It is a particularly cold night, and you freeze to death without shelter. Do you want to play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.night_forest;
                    break;
                case 19:
                    outputLabel.Text = "You find camp.";

                    option1Label.Text = "Build a fire";
                    option2Label.Text = "Go to sleep";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.night_forest;
                    break;
                case 20:
                    outputLabel.Text = "It is a particularly cold night and you freeze to death without a fire to keep you warm. Do you want to play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.night_forest;
                    break;
                case 21:
                    outputLabel.Text = "As you look around you camp trying to decide witch way to go, you see a small clearing not far from you. You investigate and it is a path. You make it out safely. Do you want to play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    option3Label.Visible = false;
                    imageBox.Image = Properties.Resources.Forest_path;
                    break;
                case 22:
                    outputLabel.Text = "As you sit around the fire contemplating what to do next, you hear footsteps, someone saw the smoke from your fire and came to rescue you. You make it out safely. Do you want to play again.";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.Bonfire;
                    SoundPlayer player8 = new SoundPlayer(Properties.Resources._234288__leosalom__fireplace);
                    player8.Play();
                    break;
                case 23:
                    outputLabel.Text = "As you look for the path, you come accross what appears to be some kind of den.";

                    option1Label.Text = "Investigate";
                    option2Label.Text = "Go back to camp";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.den;
                    break;
                case 24:
                    outputLabel.Text = "The den belongs to a mother cougar who promtply charges and kills you. Do you want to play again?.";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.den;
                    SoundPlayer player9 = new SoundPlayer(Properties.Resources._536331__xhwzq6gv__panther);
                    player9.Play();
                    break;
                case 25:
                    outputLabel.Text = "After searching for hours with no luck, you go back to camp. When you arrive someone is there. They tell you they saw the smoke from your fire and came to help. They guide you to safety. Do you want to play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.Bonfire;
                    SoundPlayer player10 = new SoundPlayer(Properties.Resources._234288__leosalom__fireplace);
                    player10.Play();
                    break;
                case 26:
                    outputLabel.Text = "The berries were poisonous and you die. Do you want to play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.Berries;
                    break;
                case 27:
                    outputLabel.Text = "It is a particularly cold night and you freeze to death without a fire to keep you warm. Do you want to play gain?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.night_forest;
                    break;
                case 28:
                    outputLabel.Text = "A you stumble through the darkness, you trip and break your leg. A bear senses your distress and attacks you. You die. Do you want to play again?";

                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Enabled = false;
                    imageBox.Image = Properties.Resources.night_forest;
                    SoundPlayer player11 = new SoundPlayer(Properties.Resources._416859__tbsounddesigns__beargrowl_03);
                    player11.Play();
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing.";                               
                    Refresh();
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
                default:
                    break;
            }           
        }

     
    }
}
