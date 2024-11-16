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
        Random random = new Random();
        SolidColorBrush[] colorCode = { Brushes.Red, Brushes.Green, Brushes.White, Brushes.Yellow, Brushes.Blue, Brushes.Orange };
        string[] colorName = {"Red", "Green", "White", "Yellow", "Blue", "Orange"};
        int[] randomColors = new int[4];

        public MainWindow()
        {
            InitializeComponent();     
            RandomColorCode();
            ComboBoxItems();
        }
        private void RandomColorCode ()
        {         
            for (int i = 0; i < randomColors.Length; i++)
            {
                int index = random.Next(colorCode.Length);
                randomColors[i] = random.Next(1, 6);
            }

            this.Title = $"{colorName[randomColors[0]].ToString()}, {colorName[randomColors[1]].ToString()}, {colorName[randomColors[2]].ToString()}, {colorName[randomColors[3]].ToString()}";

        }
       private void ComboBoxItems()
        {
            firstColorCombo.ItemsSource = colorName;
            secondColorCombo.ItemsSource = colorName;
            thirdColorCombo.ItemsSource = colorName;
            fourthColorCombo.ItemsSource = colorName;            
        }
        private void FirstComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var comboBox = sender as System.Windows.Controls.ComboBox;
            
            string selectedColor = comboBox.SelectedItem.ToString();

            switch (selectedColor)
            {
                case "Red":
                    firstCodeLabel.Background = Brushes.Red;
                    break;
                case "Green":
                    firstCodeLabel.Background = Brushes.Green;
                    break;
                case "White":
                    firstCodeLabel.Background = Brushes.White;
                    break;
                case "Yellow":
                    firstCodeLabel.Background = Brushes.Yellow;
                    break;
                case "Blue":
                    firstCodeLabel.Background = Brushes.Blue;
                    break;
                case "Orange":
                    firstCodeLabel.Background = Brushes.Orange;
                    break;
                default:
                    firstCodeLabel.Background = Brushes.Gray; 
                    break;
            }           
        }
        private void SecondComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var comboBox = sender as System.Windows.Controls.ComboBox;
            
            string selectedColor = comboBox.SelectedItem.ToString();

            switch (selectedColor)
            {
                case "Red":
                    secondCodeLabel.Background = Brushes.Red;
                    break;
                case "Green":
                    secondCodeLabel.Background = Brushes.Green;
                    break;
                case "White":
                    secondCodeLabel.Background = Brushes.White;
                    break;
                case "Yellow":
                    secondCodeLabel.Background = Brushes.Yellow;
                    break;
                case "Blue":
                    secondCodeLabel.Background = Brushes.Blue;
                    break;
                case "Orange":
                    secondCodeLabel.Background = Brushes.Orange;
                    break;
                default:
                    secondCodeLabel.Background = Brushes.Gray;
                    break;
            }
        }
        private void ThirdComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var comboBox = sender as System.Windows.Controls.ComboBox;
            string selectedColor = comboBox.SelectedItem.ToString();

            switch (selectedColor)
            {
                case "Red":
                    thirdCodeLabel.Background = Brushes.Red;
                    break;
                case "Green":
                    thirdCodeLabel.Background = Brushes.Green;
                    break;
                case "White":
                    thirdCodeLabel.Background = Brushes.White;
                    break;
                case "Yellow":
                    thirdCodeLabel.Background = Brushes.Yellow;
                    break;
                case "Blue":
                    thirdCodeLabel.Background = Brushes.Blue;
                    break;
                case "Orange":
                    thirdCodeLabel.Background = Brushes.Orange;
                    break;
                default:
                    thirdCodeLabel.Background = Brushes.Gray;
                    break;
            }
        }
        private void FourthComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var comboBox = sender as System.Windows.Controls.ComboBox;
            
            string selectedColor = comboBox.SelectedItem.ToString();

            switch (selectedColor)
            {
                case "Red":
                    fourthCodeLabel.Background = Brushes.Red;
                    break;
                case "Green":
                    fourthCodeLabel.Background = Brushes.Green;
                    break;
                case "White":
                    fourthCodeLabel.Background = Brushes.White;
                    break;
                case "Yellow":
                    fourthCodeLabel.Background = Brushes.Yellow;
                    break;
                case "Blue":
                    fourthCodeLabel.Background = Brushes.Blue;
                    break;
                case "Orange":
                    fourthCodeLabel.Background = Brushes.Orange;
                    break;
                default:
                    fourthCodeLabel.Background = Brushes.Gray;
                    break;
            }
        }
        private void CheckCodeButton_Click(object sender, RoutedEventArgs e)
        {
            CheckCode();            
        }

        

    }
}

