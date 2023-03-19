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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        int level = 1;
        Random random = new Random();

        private int answer;


        public MainWindow()
        {
            InitializeComponent();
            LevelLabel.Content = "Level " + level;

            if (level <= 3)
            {
                List<int> numbers = new List<int>() { 0, 2, 3, 4, 5 };

                int randomNumber1 = numbers[random.Next(numbers.Count)];
                int randomNumber2 = numbers[random.Next(numbers.Count)];

                DisplayMultiplicationProblem(randomNumber1, randomNumber2);

            } else if (level <= 6)
            {
                List<int> numbers = new List<int>() { 6, 7, 8, 9, 10 };

                int randomNumber1 = numbers[random.Next(numbers.Count)];
                int randomNumber2 = numbers[random.Next(numbers.Count)];

                DisplayMultiplicationProblem(randomNumber1, randomNumber2);
            } else
            {
                List<int> numbers = new List<int>() { 12, 15, 16, 18, 19 };

                int randomNumber1 = numbers[random.Next(numbers.Count)];
                int randomNumber2 = numbers[random.Next(numbers.Count)];
                

                DisplayMultiplicationProblem(randomNumber1, randomNumber2);
            }
            


            
            

        }

        private void Odeslat_ClickTrue(object sender, RoutedEventArgs e)
        {

            CheckAnswer(true);


            if (level <= 3)
            {
                List<int> numbers = new List<int>() { 2, 3, 4, 5, 6 };

                int randomNumber1 = numbers[random.Next(numbers.Count)];
                int randomNumber2 = numbers[random.Next(numbers.Count)];

                DisplayMultiplicationProblem(randomNumber1, randomNumber2);

            }
            else if (level <= 6)
            {
                List<int> numbers = new List<int>() { 7, 8, 9, 10, 11 };

                int randomNumber1 = numbers[random.Next(numbers.Count)];
                int randomNumber2 = numbers[random.Next(numbers.Count)];

                DisplayMultiplicationProblem(randomNumber1, randomNumber2);
            }
            else
            {
                List<int> numbers = new List<int>() { 12, 15, 16, 18, 19 };

                int randomNumber1 = numbers[random.Next(numbers.Count)];
                int randomNumber2 = numbers[random.Next(numbers.Count)];


                DisplayMultiplicationProblem(randomNumber1, randomNumber2);
            }
        }
        private void Odeslat_ClickFalse(object sender, RoutedEventArgs e)
        {
            CheckAnswer(false);
            List<int> numbers = new List<int>() { 2, 3, 4, 5, 6 };

            int randomNumber1 = numbers[random.Next(numbers.Count)];
            int randomNumber2 = numbers[random.Next(numbers.Count)];

            DisplayMultiplicationProblem(randomNumber1, randomNumber2);
        }





        private void DisplayMultiplicationProblem(int x, int y)
        {

            int answer = x * y;
            PrikladLabel.Content = $"kolik je {x} krát {y}?";
            /*
            int correctAnswerButton = random.Next(2);
            if (correctAnswerButton == 0)
            {
                Odpoved1.Content = answer;
                Odpoved2.Content = answer + x;
            }
            else
            {
                Odpoved2.Content = answer;
                Odpoved1.Content = answer + x;
            }
            */
            Odpoved1.Content = answer;
            Odpoved2.Content = answer + x;
        }
        

        private void CheckAnswer(bool answer)
        {
            if (answer)
            {
                level++;
                LevelLabel.Content = "Level " + level;
            }
            else
            {
                level = 1;
                LevelLabel.Content = "Level " + level;

            }
        }
        
    }
}
