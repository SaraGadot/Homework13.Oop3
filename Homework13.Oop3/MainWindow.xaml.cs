using Homework13.Oop3.Data;
using System;
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

        Storage.Clients.Add(new Client("Петя", new List<Card<decimal>>() 
            {
                new Card<decimal> ("1236 4598 5896 4587", 1000), 
                new Card<decimal> ("1236 4785 5896 4758")
            }));
        Storage.Clients.Add(new Client("Вася", new List<Card<decimal>>()
            {
                new Card<decimal> ("1245 8965 1265 4589", 5_000_000)
            }));

        Clients_Grid.ItemsSource = Storage.Clients;
        From_Client_Combo.ItemsSource = Storage.Clients;
        To_Client_Combo.ItemsSource = Storage.Clients;


        
    }

    private void Clients_Grid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        var client = Clients_Grid.SelectedItem as Client;
        Cards_Grid.ItemsSource = client?.Cards;

        
    }

    private void Add_Button_Click(object sender, RoutedEventArgs e)
    {
        var client = Clients_Grid.SelectedItem as Client;
        var cardName = CardName_TextBox.Text;
        var money = Convert.ToDecimal(Money_TextBox.Text);
        CardManager.OpenCard(client, cardName, money);

        Cards_Grid.ItemsSource = null;
        Cards_Grid.ItemsSource = client?.Cards;

        CardName_TextBox.Text = null;
        Money_TextBox.Text = null;
    }

    private void DeleteCard_Button_Click(object sender, RoutedEventArgs e)
    {
        var card = Cards_Grid.SelectedItem as Card<decimal>;
        var client = Clients_Grid.SelectedItem as Client;
        
        if (card == null)
        {
            return;
        }

        CardManager.CloseCard(client, card);

        Cards_Grid.ItemsSource = null;
        Cards_Grid.ItemsSource = client?.Cards;
    }
    private void From_Client_Combo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        var client = From_Client_Combo.SelectedItem as Client;
        From_Card_Combo.ItemsSource = client?.Cards;
    }
    private void To_Client_Combo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        var client = To_Client_Combo.SelectedItem as Client;
        To_Card_Combo.ItemsSource = client?.Cards;
    }

    private void Transfer_Button_Click(object sender, RoutedEventArgs e)
    {
        var fromCard = From_Card_Combo.SelectedItem as Card<decimal>;
        var toCard = To_Card_Combo.SelectedItem as Card<decimal>;
        var money = Convert.ToDecimal(TransferMoney_TextBox.Text);
        CardManager.Transfer(fromCard, toCard, money);

        var client = Clients_Grid.SelectedItem as Client;
        Cards_Grid.ItemsSource = null;
        Cards_Grid.ItemsSource = client?.Cards;

        From_Client_Combo.SelectedItem = null;
        To_Client_Combo.SelectedItem = null;
        From_Card_Combo.SelectedItem = null;
        To_Card_Combo.SelectedItem = null;
        TransferMoney_TextBox.Text = null;

    }


}
