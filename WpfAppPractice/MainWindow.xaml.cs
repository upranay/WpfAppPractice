using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Task<string> ReadFileData()
        {
            var filePath = "D:\\Pranay\\Source\\TxtPractice";
            System.IO.StreamReader reader = new System.IO.StreamReader(filePath);
             string? lines = reader.ReadLine();
            var t = new Task(() => reader.ReadLine());
            t.Start();
            return Task.FromResult(string.Empty);
        }

        public IEnumerable<Employee> ReadCSVFile(string csvName)
        {
            string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(csvName, "csv"));
            return lines.Select(line =>
            {
                string[] data = line.Split(';');
                return new Employee(data[0], data[1], Convert.ToInt32(data[2]), data[3], data[4]);
            });
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            ListViewEmployee.ItemsSource = ReadCSVFile("D:\\Pranay\\Source\\Employee");
        }
    }
}
