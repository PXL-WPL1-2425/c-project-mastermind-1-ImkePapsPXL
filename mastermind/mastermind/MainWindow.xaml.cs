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
            firstCodeBox.Background = Brushes.Blue;
        }

        private void firstCodeRedButton_Checked(object sender, RoutedEventArgs e)
        {
            firstCodeBox.Background = Brushes.Red;
        }

        private void firstCodeYellowButton_Checked(object sender, RoutedEventArgs e)
        {
            firstCodeBox.Background = Brushes.Yellow;
        }

        private void firstCodeWhiteButton_Checked(object sender, RoutedEventArgs e)
        {
            firstCodeBox.Background = Brushes.White;
        }

        private void firstCodeOrangeButton_Checked(object sender, RoutedEventArgs e)
        {
            firstCodeBox.Background = Brushes.Orange;
        }

        private void firstCodeGreenButton_Checked(object sender, RoutedEventArgs e)
        {
            firstCodeBox.Background = Brushes.Green;
        }

        private void checkCodeButton_Click(object sender, RoutedEventArgs e)
        {

        }




        private void secondCodeBlueButton_Checked(object sender, RoutedEventArgs e)
        {
            secondCodeBox.Background = Brushes.Blue;
        }

        private void secondCodeRedButton_Checked(object sender, RoutedEventArgs e)
        {
            secondCodeBox.Background = Brushes.Red;
        }

        private void secondCodeYellowButton_Checked(object sender, RoutedEventArgs e)
        {
            secondCodeBox.Background = Brushes.Yellow;
        }

        private void secondCodeWhiteButton_Checked(object sender, RoutedEventArgs e)
        {
            secondCodeBox.Background = Brushes.White;
        }

        private void secondCodeOrangeButton_Checked(object sender, RoutedEventArgs e)
        {
            secondCodeBox.Background = Brushes.Orange;
        }

        private void secondCodeGreenButton_Checked(object sender, RoutedEventArgs e)
        {
            secondCodeBox.Background = Brushes.Green;
        }

        private void thirdCodeBlueButton_Checked(object sender, RoutedEventArgs e)
        {
            thirdCodeBox.Background = Brushes.Blue;
        }

        private void thirdCodeRedButton_Checked(object sender, RoutedEventArgs e)
        {
            thirdCodeBox.Background = Brushes.Red;
        }

        private void thirdCodeYellowButton_Checked(object sender, RoutedEventArgs e)
        {
            thirdCodeBox.Background = Brushes.Yellow;
        }

        private void thirdCodeWhiteButton_Checked(object sender, RoutedEventArgs e)
        {
            thirdCodeBox.Background = Brushes.White;
        }

        private void thirdCodeOrangeButton_Checked(object sender, RoutedEventArgs e)
        {
            thirdCodeBox.Background = Brushes.Orange;
        }

        private void thirdCodeGreenButton_Checked(object sender, RoutedEventArgs e)
        {
            thirdCodeBox.Background = Brushes.Green;
        }

        private void fourthCodeBlueButton_Checked(object sender, RoutedEventArgs e)
        {
            fourthCodeBox.Background = Brushes.Blue;
        }

        private void fourthCodeRedButton_Checked(object sender, RoutedEventArgs e)
        {
            fourthCodeBox.Background = Brushes.Red;
        }

        private void fourthCodeYellowButton_Checked(object sender, RoutedEventArgs e)
        {
            fourthCodeBox.Background = Brushes.Yellow;
        }

        private void fourthCodeWhiteButton_Checked(object sender, RoutedEventArgs e)
        {
            fourthCodeBox.Background = Brushes.White;
        }

        private void fourthtCodeOrangeButton_Checked(object sender, RoutedEventArgs e)
        {
            fourthCodeBox.Background = Brushes.Orange;
        }

        private void fourthCodeGreenButton_Checked(object sender, RoutedEventArgs e)
        {
            fourthCodeBox.Background = Brushes.Green;
        }

    }
}