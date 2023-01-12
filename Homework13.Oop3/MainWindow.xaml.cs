using Homework13.Oop3.Data;
using System.Collections.Generic;
using System.Windows;

namespace Homework13.Oop3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public Storage Storage { get; set; } = new Storage();
    public MainWindow()
    {
        InitializeComponent();

        Storage.Clients.Add(new Client("Петя", new List<Card>() 
            {
                new Card ("1236 4598 5896 4587", 1000), 
                new Card ("1236 4785 5896 4758")
            }));
        Storage.Clients.Add(new Client("Вася", new List<Card>()
            {
                new Card ("1245 8965 1265 4589", 5_000_000)
            }));

        Clients_Grid.ItemsSource = Storage.Clients;
    }
}
