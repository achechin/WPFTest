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
using WpfApp1.Classes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person person = new Person();
            string name = person.name;
            int age= person.age;
            person.Print();
            person.name = "Sergey";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            string name = person.name;
            int age = person.age;
            person.Print();
            person.name = "Sergey";
            output.Content = person.name;

            Person tom=new Person();

            CalcRectangle calcRectangle = new CalcRectangle();
            float height = calcRectangle.height;
            float width = calcRectangle.width;
            output.Content = calcRectangle.Area(24.2f, 12.3f);
            output2.Content = calcRectangle.Perimeter(24.2f, 12.3f);
            output_figure.Content = height;
            output_figure2.Content = width;
        }
    }
}