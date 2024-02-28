using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Palindromo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        AvaloniaXamlLoader.Load(this);
        entry = this.FindControl<TextBox>("entry");
        result = this.FindControl<Label>("result"); // Assuming "result" is the Label's name
    }

    private void CalBtn(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (int.TryParse(entry.Text, out int num))
        {
            int reverseNum = 0;
            int temp = num;

            while (temp != 0)
            {
                int digit = temp % 10;
                reverseNum = reverseNum * 10 + digit;
                temp = temp / 10;
            }

            if (num == reverseNum)
            {
                result.Content = $"{num} es un número capícuo";
            }
            else
            {
                result.Content = $"{num} no es un número capícuo";
            }
        }
    }
}