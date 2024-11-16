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

    }
}

