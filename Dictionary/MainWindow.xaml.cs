using Dictionary.Class;
using System.Windows;

namespace Dictionary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WordBox wordBox = new WordBox();

        int num = 0;//Текущее количество слов
        int max = 50;//Максимальное количество слов
        int money = 100;//Количество денег
        int priceMax = 5;//Цена добавления 

        //Метод для обновления информации на екране
        public void menu()
        {
            NUM.Text = $"{num}";//Присваиваем текст из  Num
            LVL.Text = $"{num / 10}"; //Определяем уровень и выводим на экран
        }

        public MainWindow()
        {
            InitializeComponent();
            MAX.Text = $"{max}";
            Money.Text = $"{money}$";
        }

        //Кнопка сохранения
        private void Save(object sender, RoutedEventArgs e)
        {

            if (FirstWord.Text == "" || SecondWord.Text == "")
            {
                MessageBox.Show("Поля пустые");
                return;
            }
            else
            {
                if (num < max)
                {
                    //Добавляем дочерний елемент для списка слов
                    List.Children.Add(wordBox.createText(FirstWord.Text, SecondWord.Text));

                    //Делаем поле пусым
                    FirstWord.Text = "";
                    SecondWord.Text = "";
                    num++;
                    menu();
                }
                else { MessageBox.Show("Недостаточно места"); }

            }

            
        }

        //Добавление +10 к максимальному количеству слов
        private void add10(object sender, RoutedEventArgs e)
        {

            if (money >= priceMax)
            {
                max += 10;
                money -= 5;
                MAX.Text = $"{max}";
                Money.Text = $"{money}$";
            }
            else 
            {
                MessageBox.Show("Недостаточно средств для покупки");
            }
            
        }
    }
}
