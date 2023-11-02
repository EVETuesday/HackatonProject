using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp6.Windows;
using static WpfApp6.Classes.ClassHelper;
using static WpfApp6.Classes.Parser;
using static WpfApp6.Classes.WordData;
namespace WpfApp6.Pages
{
    /// <summary>
    /// Логика взаимодействия для TeacherPage.xaml
    /// </summary>
    public partial class TeacherPage : Page
    {
        public Teacher objToAdd;
        public MainWindow mainWindow;
        public ComplexWindow complexWindow;
        ObservableCollection<Teacher> teacherData = new ObservableCollection<Teacher>();

        public TeacherPage(MainWindow mainWindow)
        {
            InitializeComponent();
            if (BlockBTN)
            {
                BtnDel.IsEnabled = false;
                dg.IsReadOnly = true;
            }
            dg.ItemsSource = teachers;
            teacherData=teachers;
            this.mainWindow = mainWindow;
        }

        public TeacherPage(ComplexWindow complexWindow2)
        {
            InitializeComponent();
            if (BlockBTN)
            {
                BtnDel.IsEnabled = false;
                dg.IsReadOnly = true;
            }
            dg.ItemsSource = teachers;
            teacherData = teachers;
            complexWindow = complexWindow2;
            dg.IsReadOnly=true;
            BtnDel.Visibility= Visibility.Collapsed;
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var Res = MessageBox.Show("Вы уверены?", "Продолжить", MessageBoxButton.YesNo);
            if (Res == MessageBoxResult.Yes)
            {
                if (dg.SelectedItem==null)
                {
                    return;
                }
                Workbook wb = new Workbook(TeacherFilePath);

                Worksheet worksheet = wb.Worksheets[0];

                worksheet.Cells.DeleteRow(objToAdd.IdTeacher - 1);
                wb.Save(TeacherFilePath);
                TestConnection2();
                IdMuchitel = 0;
                Muchitel = "";
                Signer = Muchitel;
                mainWindow.GetInfoLV();
            }
            else
            {
                return;
            }
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            objToAdd = dg.SelectedItem as Teacher;
            if (complexWindow != null)
            {
                if (objToAdd != null)
                {
                    complexWindow.lblTeacher.Text = objToAdd.FullName;
                    return;
                }
            }

            if (objToAdd != null)
            {
                IdMuchitel = objToAdd.IdTeacher;
                Muchitel = objToAdd.FullName;
                Signer = Muchitel;
                mainWindow.GetInfoLV();
            }

        }

        private void dg_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {
                FrameworkElement element1 = dg.Columns[0].GetCellContent(e.Row);
                if (element1.GetType() == typeof(TextBox))
                {
                    var colomn1 = ((TextBox)element1).Text;
                    objToAdd.IdTeacher = Convert.ToInt32(colomn1);
                }
                FrameworkElement element2 = dg.Columns[1].GetCellContent(e.Row);
                if (element2.GetType() == typeof(TextBox))
                {
                    var colomn2 = ((TextBox)element2).Text;
                    objToAdd.FullName = "" + colomn2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            try
            {
                var Res = MessageBox.Show("Сохранить", "Сохранение", MessageBoxButton.YesNo);
                if (Res == MessageBoxResult.Yes)
                {
                    Workbook wb = new Workbook(TeacherFilePath);

                    Worksheet worksheet = wb.Worksheets[0];

                    if (objToAdd.IdTeacher == 0)
                    {
                        objToAdd.IdTeacher = worksheet.Cells.MaxDataRow + 1;
                    }

                    worksheet.Cells[objToAdd.IdTeacher, 0].Value = objToAdd.FullName;



                    wb.Save(TeacherFilePath);
                    TestConnection2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dg.ItemsSource = teacherData.Where(i => i.FullName.ToLower().Contains(tbSearch.Text.ToLower()));
            dg.IsReadOnly = true;
            BtnDel.IsEnabled = false;

            if (string.IsNullOrEmpty(tbSearch.Text) && WordData.Group == null)
            {
                dg.ItemsSource = teacherData;
                dg.IsReadOnly = false;
                BtnDel.IsEnabled = true;
            }

        }






    }

}

