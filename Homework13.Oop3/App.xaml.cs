using System.Windows;
using System.Windows.Threading;

namespace Homework13.Oop3;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        e.Handled = true;
        MessageBox.Show(e.Exception.Message);
    }
}


//Что нужно сделать
//Разработайте для банка «А» прототип банковской системы, которая содержит
//информацию о клиентах и их счетах.Счётом любого клиента можно управлять:

//открывать и закрывать счета;
//осуществлять переводы с одного счёта на другой;
//Используя обобщение и параметризированные классы, реализуйте методы открытия,
//закрытия счетов, а также перевода средств между счетами клиентов.



//Советы и рекомендации
//На ваше усмотрение, где и как будут храниться данные при реализации программы с графическим интерфейсом. 



//Что оценивается
//Реализован графический интерфейс.
//Используются параметризованные шаблоны.
//Наличие конструктора в классе.