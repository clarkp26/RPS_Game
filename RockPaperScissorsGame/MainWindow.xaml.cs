using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RockPaperScissorsGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static String[] Options = { "Rock", "Paper", "Scissors" };
        private String ComputerDecision;
        private String UserDecision;
        private int UserScore, ComScore;

        public MainWindow()
        {
            UserScore = 0;
            ComScore = 0;
            InitializeComponent();
        }

        private void RockButton_Checked(object sender, RoutedEventArgs e)
        {
            UserDecision = Options[0];
        }
        private void PaperButton_Checked(object sender, RoutedEventArgs e)
        {
            UserDecision = Options[1];
        }
        private void ScissorsButton_Checked(object sender, RoutedEventArgs e)
        {
            UserDecision = Options[2];
        }

        public String GameResult()
        {
            Random r = new Random();
            int c = r.Next(3);
            ComputerDecision = Options[c];

            String result = Winner(ComputerDecision, UserDecision);
            return result;

        }

        private String Winner(String com, String User)
        {

            if (com == "Rock" && User == "Scissors")
            {
                return "Com wins";
            }
            else if (com == "Scissors" && User == "Paper")
            {
                return "Com wins";
            }
            else if (com == "Paper" && User == "Rock")
            {
                return "Com wins";
            }

            else if (User == "Rock" && com == "Scissors")
            {
                return "User wins";
            }
            else if (User == "Scissors" && com == "Paper")
            {
                return "User wins";
            }
            else if (User == "Paper" && com == "Rock")
            {
                return "User wins";
            }
            else if (User == "Rock" && com == "Rock")
            {
                return "Draw";
            }
            else if (User == "Paper" && com == "Paper")
            {
                return "Draw";
            }
            else if (User == "Scissors" && com == "Scissors")
            {
                return "Draw";
            }

            return "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserScore = 0;
            ComScore = 0;
            ScoreBox.Text = "User Score: " + UserScore + "/Computer Score: " + ComScore;
            MessageBox.Show("Scores Reset");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String winner = GameResult();
            
            if (winner == "Com wins")
            {
                MessageBox.Show("Computer has chosen " + ComputerDecision + ".\nComputer is the winner!");
                ComScore++;
            }
            else if (winner == "User wins")
            {
                //MessageBox.Show()
                MessageBox.Show("Computer has chosen " + ComputerDecision + ".\nYou are the winner!");
                UserScore++;
            }
            else if (winner == "Draw")
            {
                //MessageBox.Show()
                MessageBox.Show("Computer has chosen " + ComputerDecision + ".\nIts a Draw!");
            }
            ScoreBox.Text = "User Score: "+ UserScore + "/Computer Score: " + ComScore;
        }

        
    }
}
