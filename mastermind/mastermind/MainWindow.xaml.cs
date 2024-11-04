using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Random random = new Random();
            SolidColorBrush[] colorCode = { Brushes.Red, Brushes.Green, Brushes.White, Brushes.Yellow, Brushes.Blue, Brushes.Orange };
            int[] randomColors = new int[4];
            string[] colorName = {"red", "Green", "White", "Yellow", "Blue", "Orange"};

            for (int i = 0; i < randomColors.Length; i++)
            {
                int index = random.Next(colorCode.Length);
                randomColors[i] = random.Next(1, 6);
            }

            this.Title = $"{colorName[randomColors[0]].ToString()}, {colorName[randomColors[1]].ToString()}, {colorName[randomColors[2]].ToString()}, {colorName[randomColors[3]].ToString()}";
         
        }

        
    private void firstCodeBlueButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void firstCodeRedButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void firstCodeYellowButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void firstCodeWhiteButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void firstCodeOrangeButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void firstCodeGreenButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkCodeButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        


        private void secondCodeBlueButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void secondCodeRedButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void secondCodeYellowButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void secondCodeWhiteButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void secondCodeOrangeButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void secondCodeGreenButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void thirdCodeBlueButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void thirdCodeRedButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void thirdCodeYellowButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void thirdCodeWhiteButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void thirdCodeOrangeButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void thirdCodeGreenButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void fourthCodeBlueButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void fourthCodeRedButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void fourthCodeYellowButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void fourthCodeWhiteButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void fourthtCodeOrangeButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void fourthCodeGreenButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}