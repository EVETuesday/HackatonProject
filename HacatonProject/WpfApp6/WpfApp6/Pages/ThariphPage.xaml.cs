using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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
using static WpfApp6.Classes.Parser;
using static WpfApp6.Classes.WordData;

namespace WpfApp6.Pages
{
    /// <summary>
    /// Логика взаимодействия для ThariphPage.xaml
    /// </summary>
    public partial class ThariphPage : Page
    {
        public Discipline objToAdd;
        public MainWindow mainWindow;
        public ComplexWindow complexWindow;
        ObservableCollection<Discipline> disciplinesData = new ObservableCollection<Discipline>();

        public ThariphPage(MainWindow mainWindow)
        {
            InitializeComponent();
            if (BlockBTN)
            {
                //BtnDel.IsEnabled = false;
                dg.IsReadOnly = true;
            }
            dg.ItemsSource = disciplines;
            disciplinesData = disciplines;
            this.mainWindow = mainWindow;
        }
        public ThariphPage(ComplexWindow complexWindow2)
        {
            InitializeComponent();
            if (BlockBTN)
            {
                //BtnDel.IsEnabled = false;
                dg.IsReadOnly = true;
            }
            dg.ItemsSource = disciplines;
            disciplinesData = disciplines;
            dg.IsReadOnly = true;
            complexWindow = complexWindow2;
        }
        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            objToAdd = dg.SelectedItem as Discipline;
            if (complexWindow != null)
            {
                if (objToAdd != null)
                {
                    complexWindow.lblDiscipline.Text = objToAdd.Title;
                    return;
                }
            }

            objToAdd = dg.SelectedItem as Discipline;
            if (objToAdd != null)
            {
                WordData.IdDiscipline = objToAdd.IdDiscipline;
                WordData.Discipline = disciplines.Where(i => i.IdDiscipline == objToAdd.IdDiscipline).FirstOrDefault().Title;
                mainWindow.GetInfoLV();
                TestConnection1();
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
                    objToAdd.IdDiscipline = Convert.ToInt32(colomn1);
                }
                FrameworkElement element2 = dg.Columns[1].GetCellContent(e.Row);
                if (element2.GetType() == typeof(TextBox))
                {
                    var colomn2 = ((TextBox)element2).Text;
                    objToAdd.Title = "" + colomn2;
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
                    Workbook wb = new Workbook(TarificationFilePath);

                    Worksheet worksheet = wb.Worksheets[0];

                    if (objToAdd.IdDiscipline == 0)
                    {
                        objToAdd.IdDiscipline = worksheet.Cells.MaxDataRow + 1;
                    }

                    worksheet.Cells[objToAdd.IdDiscipline, 0].Value = objToAdd.Title;



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
            dg.ItemsSource = disciplinesData.Where(i => i.Title.ToLower().Contains(tbSearch.Text.ToLower()));
            dg.IsReadOnly = true;
            //BtnDel.IsEnabled = false;

            if (string.IsNullOrEmpty(tbSearch.Text) && WordData.Group == null)
            {
                dg.ItemsSource = disciplinesData;
                dg.IsReadOnly = false;
               // BtnDel.IsEnabled = true;
            }

        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var Res = MessageBox.Show("Вы уверены?", "Продолжить", MessageBoxButton.YesNo);
            if (Res == MessageBoxResult.Yes)
            {
                if (dg.SelectedItem == null)
                {
                    return;
                }
                Workbook wb = new Workbook(TarificationFilePath);

                Worksheet worksheet = wb.Worksheets[0];

                worksheet.Cells.DeleteRow(objToAdd.IdDiscipline - 1);
                wb.Save(TarificationFilePath);
                TestConnection1();
                IdDiscipline = 0;
                WordData.Discipline = "";
                mainWindow.GetInfoLV();
            }
            else
            {
                return;
            }
        }
    }
}
