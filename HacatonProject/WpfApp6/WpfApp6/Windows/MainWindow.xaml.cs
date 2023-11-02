using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using WpfApp6.Pages;
using static WpfApp6.Classes.ClassHelper;
using static WpfApp6.Classes.Parser;
using static WpfApp6.Classes.WordData;

namespace WpfApp6.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<WordData> wordDatas = new List<WordData>();
        public MainWindow mainWindow;

        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
            VedomostFilePath = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10) + @"\\Docs\ZVedomost.doc";
            Fra.Navigate(new GroupePage(mainWindow));
            BtnGroupe.Background = Brushes.White;
            BtnGroupe.Foreground = Brushes.Black;

        }

        public void GetInfoLV()
        {
            TbFullName.Text = WordData.Signer;
            TbGroup.Text = WordData.Group;
            TbDiscipline.Text = WordData.Discipline;
        }

        private void BtnGroupe_Click(object sender, RoutedEventArgs e)
        {
            GroupePage groupePage = new GroupePage(mainWindow);
            Fra.Navigate(groupePage);
            BtnGroupe.Background = Brushes.White;
            BtnTeacher.Background = Brushes.Transparent;
            BtnStudent.Background = Brushes.Transparent;
            BtnThriph.Background = Brushes.Transparent;
            BtnVedomost.Background = Brushes.Transparent;

            BtnGroupe.Foreground = Brushes.Black;
            BtnTeacher.Foreground = Brushes.White;
            BtnStudent.Foreground = Brushes.White;
            BtnThriph.Foreground = Brushes.White;
            BtnVedomost.Foreground = Brushes.White;

            GetInfoLV();
        }

        private void BtnStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentPage studentPage = new StudentPage(mainWindow);
            Fra.Navigate(studentPage);
            BtnGroupe.Background = Brushes.Transparent;
            BtnTeacher.Background = Brushes.Transparent;
            BtnStudent.Background = Brushes.White;
            BtnThriph.Background = Brushes.Transparent;
            BtnVedomost.Background = Brushes.Transparent;

            BtnGroupe.Foreground = Brushes.White;
            BtnTeacher.Foreground = Brushes.White;
            BtnStudent.Foreground = Brushes.Black;
            BtnThriph.Foreground = Brushes.White;
            BtnVedomost.Foreground = Brushes.White;

            GetInfoLV();
        }

        private void BtnTeacher_Click(object sender, RoutedEventArgs e)
        {
            TeacherPage teacherPage = new TeacherPage(mainWindow);
            Fra.Navigate(teacherPage);
            BtnGroupe.Background = Brushes.Transparent;
            BtnTeacher.Background = Brushes.White;
            BtnStudent.Background = Brushes.Transparent;
            BtnThriph.Background = Brushes.Transparent;
            BtnVedomost.Background = Brushes.Transparent;

            BtnGroupe.Foreground = Brushes.White;
            BtnTeacher.Foreground = Brushes.Black;
            BtnStudent.Foreground = Brushes.White;
            BtnThriph.Foreground = Brushes.White;
            BtnVedomost.Foreground = Brushes.White;

            GetInfoLV();
        }

        private void BtnThriph_Click(object sender, RoutedEventArgs e)
        {
            ThariphPage thariphPage = new ThariphPage(mainWindow);
            Fra.Navigate(thariphPage);
            BtnGroupe.Background = Brushes.Transparent;
            BtnTeacher.Background = Brushes.Transparent;
            BtnStudent.Background = Brushes.Transparent;
            BtnThriph.Background = Brushes.White;
            BtnVedomost.Background = Brushes.Transparent;

            BtnGroupe.Foreground = Brushes.White;
            BtnTeacher.Foreground = Brushes.White;
            BtnStudent.Foreground = Brushes.White;
            BtnThriph.Foreground = Brushes.Black;
            BtnVedomost.Foreground = Brushes.White;

            GetInfoLV();
        }

        private void BtnVedomost_Click(object sender, RoutedEventArgs e)
        {
            VedomostPage v = new VedomostPage(mainWindow);
            Fra.Navigate(v);
            BtnGroupe.Background = Brushes.Transparent;
            BtnTeacher.Background = Brushes.Transparent;
            BtnStudent.Background = Brushes.Transparent;
            BtnThriph.Background = Brushes.Transparent;
            BtnVedomost.Background = Brushes.White;

            BtnGroupe.Foreground = Brushes.White;
            BtnTeacher.Foreground = Brushes.White;
            BtnStudent.Foreground = Brushes.White;
            BtnThriph.Foreground = Brushes.White;
            BtnVedomost.Foreground = Brushes.Black;

            GetInfoLV();
        }

        private void btnRel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Classes.Parser.TestConnection();
                Classes.Parser.TestConnection1();
                Classes.Parser.TestConnection2();
                Classes.Parser.TestConnection3();
            }
            catch (Exception)
            {
                MessageBox.Show("При импорте возникла ошибка");
                return;
            }
            
            GetInfoLV();
        }
    }
}
