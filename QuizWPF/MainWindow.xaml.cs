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

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (qcl.currentQ < 30)
            {
                QuestionNumber.Text = $"Question: {qcl.currentQ.ToString()}/30";
                QDisplay.Text = qcl.ChangeQuestion();
            }
            else
            {
                QuestionNumber.Text = "Quiz Completed";
            }
        }

        private void AButton_Click(object sender, RoutedEventArgs e)
        {
            AButton.Content = "";
        }

        private void BButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DButton_Click(object sender, RoutedEventArgs e)
        {

        }
        //private void QuizProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    QuizProgress.Value = qcl.currentQ;
        //}
    }
}
