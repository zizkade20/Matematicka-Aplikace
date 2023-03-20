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
    // Definování proměnných, které budu používat skrze celý kód
    class Globals
    {
        
        public static string answer { get; set; } // správná odpověď, kterou budu porovnávat s contentem buttonu
        public static int level { get; set; } // proměnná level, která určuje obtížnost příkladů
    }

    public partial class MainWindow : Window
    {
        
        Random random = new Random();


        public MainWindow()
        {
            InitializeComponent();
            // Starting level nastavím na 1
            Globals.level = 1;

            // Zobrazím příklad
            DisplayMultiplicationProblem(Globals.level);


        }
        // On-click metoda tlačítka
        private void Odeslat_Click(object sender, RoutedEventArgs e)
        {

            string ButtonVal;
            // Načtu si hodnotu z bottonu, pokud se rovná výsledku, hráč uhádl správně
            ButtonVal = (sender as System.Windows.Controls.Button).Content.ToString();
            if (Globals.answer == ButtonVal)
            {
                // Zvýšim level o 1 a vypíšu nový příklad
                Globals.level += 1;
                // Metoda na zobrazení nového přkladu
                DisplayMultiplicationProblem(Globals.level);
            }
            else
            {
                // Resetuji level na 1 a vypíšu příklad
                Globals.level = 1;
                // Metoda na zobrazení nového přkladu
                DisplayMultiplicationProblem(Globals.level);

            }


        }
        // Metoda na vypsání příkladu
        private void DisplayMultiplicationProblem(int level)
        {
            
            LevelLabel.Content = "Level " + Globals.level;

            // hráčovi se zobrazují příklady s čísly podle toho, v jakém je levelu
            if (level <= 3)
            {
                List<int> numbers = new List<int>() { 2, 3, 4, 5, 6 };

                int randomNumber1 = numbers[random.Next(numbers.Count)];
                int randomNumber2 = numbers[random.Next(numbers.Count)];


                // Metoda na vytvoření výsledku
                CreateMultiplicationProblem(randomNumber1, randomNumber2);

            }
            else if (level <= 6)
            {
                List<int> numbers = new List<int>() { 7, 8, 9, 10, 11 };

                int randomNumber1 = numbers[random.Next(numbers.Count)];
                int randomNumber2 = numbers[random.Next(numbers.Count)];


                // Metoda na vytvoření výsledku
                CreateMultiplicationProblem(randomNumber1, randomNumber2);
            }

            else if (level <= 10)
            {

                List<int> numbers = new List<int>() { 12, 15, 16, 18, 19 };

                int randomNumber1 = numbers[random.Next(numbers.Count)];
                int randomNumber2 = numbers[random.Next(numbers.Count)];


                // Metoda na vytvoření výsledku
                CreateMultiplicationProblem(randomNumber1, randomNumber2);
            }
            else if (level > 10 && level < 20)
            {

                List<int> numbers = new List<int>() { 20, 66, 5, 17, 8 };

                int randomNumber1 = numbers[random.Next(numbers.Count)];
                int randomNumber2 = numbers[random.Next(numbers.Count)];


                // Metoda na vytvoření výsledku
                CreateMultiplicationProblem(randomNumber1, randomNumber2);
            }
            else if (level > 20)
            {
                List<int> numbers = new List<int>() { 20, 35, 44, 113 , 1};


                int randomNumber1 = numbers[random.Next(numbers.Count)];
                int randomNumber2 = numbers[random.Next(numbers.Count)];


                // Metoda na vytvoření výsledku
                CreateMultiplicationProblem(randomNumber1, randomNumber2);
            }
        }
        // Metoda na vytvoření výsledku a dosazení do buttonu
        private void CreateMultiplicationProblem(int x, int y)
        {
            // Vynulování předchozí odpovědi, pokud nějaká už byla
            Globals.answer = "";
            int SpravnyVysledek = x * y;

            PrikladLabel.Content = $"kolik je {x} x {y}?";
            
            
            int randomiseButton = random.Next(2);
            int randomiseButton2 = random.Next(4);
            // Přiřazení odpovědí náhodně do buttonů

            if (randomiseButton == 0)
            {
                Odpoved1.Content = SpravnyVysledek;
                if (randomiseButton2 == 0)
                {
                    Odpoved2.Content = SpravnyVysledek + x;

                }
                else if (randomiseButton2 == 1)
                {
                    Odpoved2.Content = SpravnyVysledek - x;

                } else if (randomiseButton2 == 2)
                {
                    Odpoved2.Content = SpravnyVysledek + y;

                }
                else
                {
                    Odpoved2.Content = SpravnyVysledek - y;

                }
            }
            else
            {
                Odpoved2.Content = SpravnyVysledek;
                if (randomiseButton2 == 0)
                {
                    Odpoved1.Content = SpravnyVysledek + x;

                }
                else if (randomiseButton2 == 1)
                {
                    Odpoved1.Content = SpravnyVysledek - x;

                }
                else if (randomiseButton2 == 2)
                {
                    Odpoved1.Content = SpravnyVysledek + y;

                }
                else
                {
                    Odpoved1.Content = SpravnyVysledek - y;

                }
            }
            // Správný výsledek dosadím do proměnné answer, kterou pak budu porovnávat s odpovědí hráče
            Globals.answer += SpravnyVysledek;
        }

    }
}
