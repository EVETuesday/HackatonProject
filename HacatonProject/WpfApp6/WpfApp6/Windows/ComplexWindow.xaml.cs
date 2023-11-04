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
using System.Windows.Shapes;
using WpfApp6.Classes;
using WpfApp6.Pages;
using static WpfApp6.Classes.ClassHelper;

namespace WpfApp6.Windows
{
    /// <summary>
    /// Логика взаимодействия для ComplexWindow.xaml
    /// </summary>
    public partial class ComplexWindow : Window
    {
        MainWindow mainWindow;
        public ComplexWindow( MainWindow mainWindow2)
        {
            mainWindow = mainWindow2;
            InitializeComponent();
          frDisciplite.Navigate(new ThariphPage(this));
          frTeacher.Navigate(new TeacherPage(this));
        }

        private void btnClearDescipline_Click(object sender, RoutedEventArgs e)
        {
            lblDiscipline.Text = "Дисциплина не выбранна";
        }

        private void btnClearTeacher_Click(object sender, RoutedEventArgs e)
        {
            lblTeacher.Text = "Учитель не выбранн";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ( lblDiscipline.Text == "Дисциплина не выбранна" && lblTeacher.Text == "Учитель не выбранн")
            {
                MessageBox.Show("Выберете учителя или дисциплину");
                return;
            }
            if (lblDiscipline.Text != "Дисциплина не выбранна")
            {
                WordData.Discipline += "; " + lblDiscipline.Text;
            }
            if (lblTeacher.Text != "Учитель не выбранн")
            {
                WordData.Muchitel += "; " + lblTeacher.Text;
                WordData.Signer += lblTeacher.Text;
            }
            
            
            switch (NuberVedomost)
            {
                case 1:
                    WordData.Discipline += " (Комплексная ведомость)";
                    VedomostFilePath = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10) + @"\\Docs\ZVedomost.doc";
                  ClassHelper.TextInput();
                    break;
                case 2:
                    VedomostFilePath = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10) + @"\\Docs\KVedomost.doc";
                    ClassHelper.TextInput();
                    break;
                case 3:
                    WordData.Discipline += " (Комплексная экзамен)";
                    VedomostFilePath = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10) + @"\\Docs\EVedomost.doc";
                    ClassHelper.TextInput();
                    break;
            }
        }
    }
}
