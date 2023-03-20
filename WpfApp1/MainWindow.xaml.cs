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
    class Variables
    {
        public static string spravnyVysledek { get; set; }
        public static int level { get; set; }
    }

    public partial class MainWindow : Window
    {
        
        Random random = new Random();


        public MainWindow()
        {
            InitializeComponent();

            Variables.level = 1;
            Variables.spravnyVysledek = "";

            LevelLabel.Content = "Level " + Variables.level;

            ShowNumbers(Variables.level);


        }

        private void Odeslat_Click(object sender, RoutedEventArgs e)
        {

            string ButtonVal;
            ButtonVal = (sender as System.Windows.Controls.Button).Content.ToString();

            if (Variables.spravnyVysledek == ButtonVal)
            {
                Variables.level += 1;
                ShowNumbers(Variables.level);
            }
            else
            {
                Variables.level = 1;
                ShowNumbers(Variables.level);

            }


        }

        private void ShowNumbers(int level)
        {
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

        private void DisplayMultiplicationProblem(int x, int y)
        {

            int SpravnyVysledek = x * y;
            PrikladLabel.Content = $"kolik je {x} krát {y}?";

            int randomiseButton = random.Next(2);
            if (randomiseButton == 0)
            {
                Odpoved1.Content = SpravnyVysledek;
                Odpoved2.Content = SpravnyVysledek + x;
            }
            else
            {
                Odpoved2.Content = SpravnyVysledek;
                Odpoved1.Content = SpravnyVysledek + x;
            }
            Variables.spravnyVysledek += SpravnyVysledek;
        }

    }
}
