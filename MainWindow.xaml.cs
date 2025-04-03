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

namespace Текущий_контроль
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double[] scores = {
                    double.Parse(Task1TextBox.Text),
                    double.Parse(Task2TextBox.Text),
                    double.Parse(Task3TextBox.Text),
                    double.Parse(Task4TextBox.Text),
                    double.Parse(Task5TextBox.Text)
                };

                double totalScore = GradeCalculator.CalculateTotalScore(scores);
                string grade = GradeCalculator.GetGrade(totalScore);

                ResultTextBlock.Text = $"Сумма баллов: {totalScore}\nОценка: {grade}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые баллы.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
