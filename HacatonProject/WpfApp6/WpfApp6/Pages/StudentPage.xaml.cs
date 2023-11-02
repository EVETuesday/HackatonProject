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
    /// Логика взаимодействия для StudentPage.xaml
    /// </summary>
    public partial class StudentPage : Page
    {
        public Student objToAdd;
        public MainWindow mainWindow;
        public ObservableCollection<Student> studentsData = new ObservableCollection<Student>();

        public StudentPage(MainWindow mainWindow)
        {
            InitializeComponent();
            if (BlockBTN)
            {
                BtnDel.IsEnabled = false;
                dg.IsReadOnly = true;
            }
            this.mainWindow = mainWindow;
            if (IdGroup == 1) {
                dg.ItemsSource = students;
                studentsData = students;
            }
            else
            {
                dg.ItemsSource = students.Where(i => i.Groupe == WordData.IdGroup);
                studentsData= new ObservableCollection<Student>(students.Where(i => i.Groupe == WordData.IdGroup));
                dg.IsReadOnly = true;
            }
            
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
                 Workbook wb = new Workbook(StudentsFilePath);

                 Worksheet worksheet = wb.Worksheets[1];

                 worksheet.Cells.DeleteRow(objToAdd.IDStudent);
                 wb.Save(StudentsFilePath);
                 TestConnection3();

            }
            else
            {
                return;
            }
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            objToAdd = dg.SelectedItem as Student;
            
            mainWindow.GetInfoLV();
        }

        private void dg_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            try
            {

                FrameworkElement[] element = new FrameworkElement[30];
                for (int i = 0; i < element.Length; i++)
                {
                    element[i] = dg.Columns[i].GetCellContent(e.Row);
                }
                if (element[0].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[0]).Text; objToAdd.GroupeString = "" + colomn; }
                if (element[1].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[1]).Text; objToAdd.UnderGroupe = "" + colomn; }
                if (element[2].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[2]).Text; objToAdd.Specialtity = "" + colomn; }
                if (element[3].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[3]).Text; objToAdd.Kurator = "" + colomn; }
                if (element[4].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[4]).Text; objToAdd.Budget = "" + colomn; }
                if (element[5].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[5]).Text; objToAdd.FullName = "" + colomn; }
                if (element[6].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[6]).Text; objToAdd.OrderOfEnrollment = "" + colomn; }
                if (element[7].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[7]).Text; objToAdd.TheOrderOfTheAcademyVacation = "" + colomn; }
                if (element[8].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[8]).Text; objToAdd.ReasonVacation = "" + colomn; }
                if (element[9].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[9]).Text; objToAdd.ExitDateFromTheAcademyVacation = "" + colomn; }
                if (element[10].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[10]).Text; objToAdd.RestorationOrder = "" + colomn; }
                if (element[11].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[11]).Text; objToAdd.OrderOfExpulsion = "" + colomn; }
                if (element[12].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[12]).Text; objToAdd.ReasonExpulsion = "" + colomn; }
                if (element[13].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[13]).Text; objToAdd.Gender = "" + colomn; }
                if (element[14].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[14]).Text; objToAdd.RegistrationInMoscow = "" + colomn; }
                if (element[15].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[15]).Text; objToAdd.Birthday = "" + colomn; }
                if (element[16].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[16]).Text; objToAdd.Phone = "" + colomn; }
                if (element[17].GetType() == typeof(TextBox)){var colomn = ((TextBox)element[17]).Text; objToAdd.MothersFullNameMobilePhone = "" + colomn;}
                if (element[18].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[18]).Text; objToAdd.PhathersFullNameMobilePhone = "" + colomn; }
                if (element[19].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[19]).Text; objToAdd.HomePhone = "" + colomn; }
                if (element[20].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[20]).Text; objToAdd.AddressOfActualResidence = "" + colomn; }
                if (element[21].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[21]).Text; objToAdd.AddressOfRegistration = "" + colomn; }
                if (element[22].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[22]).Text; objToAdd.PassportData = "" + colomn; }
                if (element[23].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[23]).Text; objToAdd.MedicalPolicyNumberIssuedByWhom = "" + colomn; }
                if (element[24].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[24]).Text; objToAdd.SNILS = "" + colomn; }
                if (element[25].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[25]).Text; objToAdd.INN = "" + colomn; }
                if (element[26].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[26]).Text; objToAdd.PostalAddress = "" + colomn; }
                if (element[27].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[27]).Text; objToAdd.Competence = "" + colomn; }
                if (element[28].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[28]).Text; objToAdd.VaccinationAgainstCovid19 = "" + colomn; }
                if (element[29].GetType() == typeof(TextBox)) { var colomn = ((TextBox)element[29]).Text; objToAdd.HeadOfTheWRC = "" + colomn; }



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
                var Res = MessageBox.Show("Вы уверены?", "Продолжить", MessageBoxButton.YesNo);
                if (Res == MessageBoxResult.Yes)
                {
                    Workbook wb = new Workbook(StudentsFilePath);

                    Worksheet worksheet = wb.Worksheets[1];

                    if (objToAdd.IDStudent == 0)
                    {
                        objToAdd.IDStudent = worksheet.Cells.MaxDataRow+1;
                    }

                    worksheet.Cells[objToAdd.IDStudent, 5].Value = objToAdd.FullName;

                    worksheet.Cells[objToAdd.IDStudent, 0].Value = objToAdd.GroupeString;



                    if (objToAdd.UnderGroupe == "1")
                    {
                        worksheet.Cells[objToAdd.IDStudent, 1].Value = 1;
                    }
                    else 
                    {
                        worksheet.Cells[objToAdd.IDStudent, 1].Value = 2;
                    }
                    



                    worksheet.Cells[objToAdd.IDStudent, 2].Value = objToAdd.Specialtity;

                    if (objToAdd.UnderGroupe == "Б")
                    {
                        worksheet.Cells[objToAdd.IDStudent, 4].Value = "Б";
                    }
                    else
                    {
                        worksheet.Cells[objToAdd.IDStudent, 4].Value = "ВБ";
                    }


                    worksheet.Cells[objToAdd.IDStudent, 3].Value = objToAdd.Kurator;
                    worksheet.Cells[objToAdd.IDStudent, 6].Value = objToAdd.OrderOfEnrollment;
                    worksheet.Cells[objToAdd.IDStudent, 7].Value = objToAdd.TheOrderOfTheAcademyVacation;
                    worksheet.Cells[objToAdd.IDStudent, 8].Value = objToAdd.ReasonVacation;
                    worksheet.Cells[objToAdd.IDStudent, 9].Value = objToAdd.ExitDateFromTheAcademyVacation;
                    worksheet.Cells[objToAdd.IDStudent, 10].Value = objToAdd.RestorationOrder;
                    worksheet.Cells[objToAdd.IDStudent, 11].Value = objToAdd.OrderOfExpulsion;
                    worksheet.Cells[objToAdd.IDStudent, 12].Value = objToAdd.ReasonExpulsion;
                    worksheet.Cells[objToAdd.IDStudent, 13].Value = objToAdd.Gender;
                    worksheet.Cells[objToAdd.IDStudent, 14].Value = objToAdd.RegistrationInMoscow;
                    worksheet.Cells[objToAdd.IDStudent, 15].Value = objToAdd.Birthday;
                    worksheet.Cells[objToAdd.IDStudent, 16].Value = objToAdd.Phone;
                    worksheet.Cells[objToAdd.IDStudent, 17].Value = objToAdd.MothersFullNameMobilePhone;
                    worksheet.Cells[objToAdd.IDStudent, 18].Value = objToAdd.PhathersFullNameMobilePhone;
                    worksheet.Cells[objToAdd.IDStudent, 19].Value = objToAdd.HomePhone;
                    worksheet.Cells[objToAdd.IDStudent, 20].Value = objToAdd.AddressOfActualResidence;
                    worksheet.Cells[objToAdd.IDStudent, 21].Value = objToAdd.AddressOfRegistration;
                    worksheet.Cells[objToAdd.IDStudent, 22].Value = objToAdd.PassportData;
                    worksheet.Cells[objToAdd.IDStudent, 23].Value = objToAdd.MedicalPolicyNumberIssuedByWhom;
                    worksheet.Cells[objToAdd.IDStudent, 24].Value = objToAdd.SNILS;
                    worksheet.Cells[objToAdd.IDStudent, 25].Value = objToAdd.INN;
                    worksheet.Cells[objToAdd.IDStudent, 26].Value = objToAdd.PostalAddress;
                    worksheet.Cells[objToAdd.IDStudent, 27].Value = objToAdd.Competence;
                    worksheet.Cells[objToAdd.IDStudent, 28].Value = objToAdd.VaccinationAgainstCovid19;
                    worksheet.Cells[objToAdd.IDStudent, 29].Value = objToAdd.HeadOfTheWRC;



                    wb.Save(StudentsFilePath);
                    TestConnection3();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dg.ItemsSource = studentsData.Where(i=>i.FullName.ToLower().Contains(tbSearch.Text.ToLower()));
            dg.IsReadOnly = true;
            BtnDel.IsEnabled = false;

            if (string.IsNullOrEmpty(tbSearch.Text) && WordData.Group==null)
            {
                dg.ItemsSource = studentsData;
                dg.IsReadOnly = false;
                BtnDel.IsEnabled = true;
            }
        }
    }

}

