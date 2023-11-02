using Aspose.Cells;
using Microsoft.Win32;
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
using System.Windows.Forms;
using System.IO;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp6.Classes;
using static WpfApp6.Classes.ClassHelper;


namespace WpfApp6.Windows
{
    /// <summary>
    /// Логика взаимодействия для DocumentSearch.xaml
    /// </summary>
    public partial class DocumentSearch : Window
    {
        public DocumentSearch()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10) + @"\\Docs\PathSave.txt"))
            {
                string lynx = sr.ReadToEnd();
                if (!string.IsNullOrEmpty(lynx))
                {
                    string[] lynxKitten = new string[2];
                    lynxKitten=lynx.Split('\n');
                    tbDox.Text = lynxKitten[0].Substring(0, lynxKitten[0].Length-1);
                    tbVed.Text = lynxKitten[1].Substring(0, lynxKitten[1].Length-1);

                    StudentsFilePath = tbDox.Text + @"\\Список студентов.xlsx";
                    TeacherFilePath = tbDox.Text + @"\\Преподаватели.xlsx";
                    TarificationFilePath = tbDox.Text + @"\\Предметы.xlsx";


                }
                sr.Close();
            }
        }

        private void tbDox_GotFocus(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            tbDox.Text = folderBrowser.SelectedPath;

            StudentsFilePath = tbDox.Text + @"\\Список студентов.xlsx";
            TeacherFilePath = tbDox.Text + @"\\Преподаватели.xlsx";
            TarificationFilePath = tbDox.Text + @"\\Предметы.xlsx";
            
            

        }

        private void tbVed_GotFocus(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            tbVed.Text = folderBrowser.SelectedPath;
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Parser.TestConnection();
                Parser.TestConnection1();
                Parser.TestConnection2();
                Parser.TestConnection3();
                lblDox.Content = "✔";
                lblDox.Foreground = Brushes.Green;
            }
            catch (Exception)
            {
                lblDox.Content = "X";
                lblDox.Foreground = Brushes.Red;
            }

            if (string.IsNullOrEmpty(tbVed.Text))
            {
                
                lblVed.Content = "X";
                lblVed.Foreground = Brushes.Red;
            }
            else
            {
                    lblVed.Content = "✔";
                    lblVed.Foreground = Brushes.Green;
                
            }

            if (lblDox.Content.ToString()== "✔" && lblVed.Content.ToString() == "✔")
            {
                btnGo.IsEnabled = true;
            }
            else
            {
                btnGo.IsEnabled = false;
            }
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            FolderVedomostFilePath = tbVed.Text;
            using(StreamWriter sr = new StreamWriter(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10) + @"\\Docs\PathSave.txt"))
            {
                sr.WriteLine(tbDox.Text);
                sr.WriteLine(tbVed.Text);
                sr.Close();
            }
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
