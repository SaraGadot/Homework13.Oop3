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

        Storage.Clients.Add(new Client("Петя", new List<Card>() {new Card ()}));
        Storage.Clients.Add(new Client("Вася", new List<Card>()));

        Clients_Grid.ItemsSource = Storage.Clients;
    }
}
