using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Dictionary.Class
{
    class WordBox
    {
        public Border createText(string firstWord,string secondWord) 
        {
            Border border = new Border
            {
                Height = 80,
                Background = new SolidColorBrush(Colors.Aqua),
                Margin = new Thickness(0,5,0,0),
                BorderBrush = new SolidColorBrush(Colors.Black),
                BorderThickness = new Thickness(5)

            };

            StackPanel stackPanel = new StackPanel { Orientation = Orientation.Horizontal};

            TextBox textBlock = new TextBox {Text = firstWord , FontSize = 20 , MaxLength = 40 , Height = 40, HorizontalAlignment = HorizontalAlignment.Center, Margin = new Thickness(10, 0, 6, 0) };
            TextBlock textBlock1 = new TextBlock { Text = "-----------", FontSize = 20 , HorizontalAlignment = HorizontalAlignment.Center };
            TextBox textBlock2 = new TextBox { Text = secondWord, FontSize = 20, MaxLength = 40 , Height = 40, HorizontalAlignment = HorizontalAlignment.Center , Margin = new Thickness(6, 0, 0, 10) };

            stackPanel.Children.Add(textBlock);
            stackPanel.Children.Add(textBlock1);
            stackPanel.Children.Add(textBlock2);

            border.Child = stackPanel;

            return border;

        }

    }
}
