using ConsoleApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Threading;

namespace QuizWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuestionCL qcl = new QuestionCL();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Next_Click(object sender, RoutedEventArgs e)
        {
            if (qcl.currentQ < 29)
            {
                UpdateQuestion();
                //Category.Text = qcl.ChangeCategory();
            }
            //Change window for end of quiz
            else
            {
                AButton.Visibility = Visibility.Hidden;
                BButton.Visibility = Visibility.Hidden;
                CButton.Visibility = Visibility.Hidden;
                DButton.Visibility = Visibility.Hidden;
                Next.Visibility = Visibility.Hidden;
                QDisplay.Visibility = Visibility.Hidden;
                QuestionNumber.Text = "Quiz Completed";
                if (qcl.Score > 25)
                {
                    QDisplay.Text = $"Congratulations!! You Scored: {qcl.Score.ToString()}";

                }
            }
        }
        //Display whether the selected question is correct or not and deactivate the buttons
        private void AButton_Click(object sender, RoutedEventArgs e)
        {
            QDisplay.Text = "Wrong Answer";
            AButton.IsEnabled = false;
            BButton.IsEnabled = false;
            CButton.IsEnabled = false;
            DButton.IsEnabled = false;
        }

        private void BButton_Click(object sender, RoutedEventArgs e)
        {
            QDisplay.Text = "Wrong Answer";
            AButton.IsEnabled = false;
            BButton.IsEnabled = false;
            CButton.IsEnabled = false;
            DButton.IsEnabled = false;
        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            QDisplay.Text = "Wrong Answer";
            AButton.IsEnabled = false;
            BButton.IsEnabled = false;
            CButton.IsEnabled = false;
            DButton.IsEnabled = false;
        }
        private void DButton_Click(object sender, RoutedEventArgs e)
        {
            QDisplay.Text = "Correct";
            qcl.Score++;
            Score.Text = $"Score: {qcl.Score.ToString()}";
            AButton.IsEnabled = false;
            BButton.IsEnabled = false;
            CButton.IsEnabled = false;
            DButton.IsEnabled = false;
        }

        //UpdateQuestion method logic
        private void UpdateQuestion()
        {
            AButton.IsEnabled = true;
            BButton.IsEnabled = true;
            CButton.IsEnabled = true;
            DButton.IsEnabled = true;
            //Update question number
            QuestionNumber.Text = $"Question: {(qcl.currentQ += 1).ToString()}/29";
            //Change to next question
            QDisplay.Text = qcl.ChangeQuestion();
            //Change the answers on each button and return them to grey
            AButton.Content = $"{ qcl.ChangeNonAnswer1()}";
            BButton.Content = $"{ qcl.ChangeNonAnswer2()}";
            CButton.Content = $"{ qcl.ChangeNonAnswer3()}";
            DButton.Content = $"{ qcl.ChangeAnswer()}";
            //Switch the positions of the buttons
            if (qcl.ButtonMover() == 1)
            {
                AButton.Margin = new Thickness(10, 213, 0, 0);
                BButton.Margin = new Thickness(205, 213, 0, 0);
                CButton.Margin = new Thickness(10, 349, 0, 0);
                DButton.Margin = new Thickness(205, 349, 0, 0);
            }
            else if (qcl.ButtonMover() == 2)
            {
                DButton.Margin = new Thickness(10, 213, 0, 0);
                AButton.Margin = new Thickness(205, 213, 0, 0);
                BButton.Margin = new Thickness(10, 349, 0, 0);
                CButton.Margin = new Thickness(205, 349, 0, 0);
            }
            else if (qcl.ButtonMover() == 3)
            {
                CButton.Margin = new Thickness(10, 213, 0, 0);
                DButton.Margin = new Thickness(205, 213, 0, 0);
                AButton.Margin = new Thickness(10, 349, 0, 0);
                BButton.Margin = new Thickness(205, 349, 0, 0);
            }
            else
            {
                BButton.Margin = new Thickness(10, 213, 0, 0);
                CButton.Margin = new Thickness(205, 213, 0, 0);
                DButton.Margin = new Thickness(10, 349, 0, 0);
                AButton.Margin = new Thickness(205, 349, 0, 0);
            }
        }
    }
}
