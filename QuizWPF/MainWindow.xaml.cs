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
            if (qcl.currentQ < 28)
            {
                QuestionNumber.Text = $"Question: {qcl.currentQ.ToString()}/30";
                QDisplay.Text = qcl.ChangeQuestion();
                AButton.Content = $"{ qcl.ChangeNonAnswer1()}";
                BButton.Content = $"{ qcl.ChangeNonAnswer2()}";
                CButton.Content = $"{ qcl.ChangeNonAnswer3()}";
                DButton.Content = $"{ qcl.ChangeAnswer()}";
                AButton.Background = Brushes.LightGray;
                BButton.Background = Brushes.LightGray;
                CButton.Background = Brushes.LightGray;
                DButton.Background = Brushes.LightGray;
                if (qcl.ButtonMover()==1)
                {
                    AButton.Margin = new Thickness(10, 213, 0, 0);
                    BButton.Margin = new Thickness(205, 213, 0, 0);
                    CButton.Margin = new Thickness(10, 349, 0, 0);
                    DButton.Margin = new Thickness(205, 349, 0, 0);
                }
                else if (qcl.ButtonMover()==2)
                {
                    DButton.Margin = new Thickness(10, 213, 0, 0);
                    AButton.Margin = new Thickness(205, 213, 0, 0);
                    BButton.Margin = new Thickness(10, 349, 0, 0);
                    CButton.Margin = new Thickness(205, 349, 0, 0);
                }
                else if (qcl.ButtonMover()==3)
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
            else
            {
                AButton.Visibility = Visibility.Hidden;
                BButton.Visibility = Visibility.Hidden;
                CButton.Visibility = Visibility.Hidden;
                DButton.Visibility = Visibility.Hidden;
                QuestionNumber.Text = "Quiz Completed";
            }
        }

        private void AButton_Click(object sender, RoutedEventArgs e)
        {
            QDisplay.Text = "Wrong Answer";
            AButton.Background = Brushes.Red;
        }

        private void BButton_Click(object sender, RoutedEventArgs e)
        {
            QDisplay.Text = "Wrong Answer";
            BButton.Background = Brushes.Red;
        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            QDisplay.Text = "Wrong Answer";
            CButton.Background = Brushes.Red;
        }
        private void DButton_Click(object sender, RoutedEventArgs e)
        {
            QDisplay.Text = "Correct";
            qcl._score++;
            DButton.Background = Brushes.Green;
            Score.Text = $"Score: {qcl._score.ToString()}";
        }
    }
}
