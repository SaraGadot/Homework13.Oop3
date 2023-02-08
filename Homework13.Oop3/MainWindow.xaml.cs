﻿using Homework13.Oop3.Data;
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

    private void Clients_Grid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        var client = Clients_Grid.SelectedItem as Client;
        Cards_Grid.ItemsSource = client?.Cards;
    }

    private void Add_Button_Click(object sender, RoutedEventArgs e)
    {
        var client = Clients_Grid.SelectedItem as Client;
        client?.Cards.Add(new Card(CardName_TextBox.Text, Convert.ToDecimal(Money_TextBox.Text)));
        
        Cards_Grid.ItemsSource = null;
        Cards_Grid.ItemsSource = client?.Cards;

        CardName_TextBox.Text = null;
        Money_TextBox.Text = null;
    }

    private void DeleteCard_Button_Click(object sender, RoutedEventArgs e)
    {
        var card = Cards_Grid.SelectedItem as Card;
        var client = Clients_Grid.SelectedItem as Client;
        client?.Cards.Remove(card);

        Cards_Grid.ItemsSource = null;
        Cards_Grid.ItemsSource = client?.Cards;
    }
    
}
