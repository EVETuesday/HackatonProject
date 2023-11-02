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
using WpfApp6.Classes;
using WpfApp6.Windows;
using static WpfApp6.Classes.ClassHelper;

namespace WpfApp6.Pages
{
    /// <summary>
    /// Логика взаимодействия для VedomostPage.xaml
    /// </summary>
    public partial class VedomostPage : Page
    {
        MainWindow mainWindow;
        public VedomostPage(MainWindow mainWindow2)
        {
            InitializeComponent();
            mainWindow = mainWindow2;
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NuberVedomost = 1;
            if (ComplexLine())
            {
                
                return;
            }
            
            VedomostFilePath = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10) + @"\\Docs\ZVedomost.doc";
            ClassHelper.TextInput();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NuberVedomost = 2;
            if (ComplexLine())
            {
                return;
            }
            VedomostFilePath = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10) + @"\\Docs\KVedomost.doc";
            ClassHelper.TextInput();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NuberVedomost = 3;
            if (ComplexLine())
            {
                return;
            }
            VedomostFilePath = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10) + @"\\Docs\EVedomost.doc";
            ClassHelper.TextInput();
        }

        private void btnComplex_Click(object sender, RoutedEventArgs e)
        {
            if (btnComplex.Content.ToString()=="")
            {
                btnComplex.Content = "✔";
                ComplexExam = !ComplexExam;
            }
            else
            {
                btnComplex.Content = "";
                ComplexExam = !ComplexExam;
            }
        }
        public bool ComplexLine()
        {
            if (!ComplexExam)
            {
                return false;
            }
            ComplexWindow complexWindow = new ComplexWindow(mainWindow);
            complexWindow.Show();
            return true;
        }
    }
}
