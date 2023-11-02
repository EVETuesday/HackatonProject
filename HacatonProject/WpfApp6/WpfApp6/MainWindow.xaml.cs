using Aspose.Cells;
using System;
using System.Collections.Generic;
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
using static WpfApp6.Classes.ClassHelper;


namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            TestConnection();
            dg.ItemsSource = teachers;
            dg1.ItemsSource = groupes;
            dg2.ItemsSource = disciplines;
            dg3.ItemsSource = students;
        }
        private static void TestConnection()
        {
            Workbook wb = new Workbook(@"D:\ИСХОДНИКИ ДЛЯ ХАКАТОНА\Список студентов\Список студентов.xlsx");

            Worksheet worksheet = wb.Worksheets[1];
            
            int id = 1;
            int rows = worksheet.Cells.MaxDataRow;

            for (int i = 1; i < rows; i++)
            {
                Student student = new Student();

                student.IDStudent = id;
                id++;
                student.FullName = ""+worksheet.Cells[i, 5].Value; 
                for (int j = 0; j < groupes.Count; j++)
                {
                    if (groupes[i].TitleGroupe == ""+worksheet.Cells[j, 0].Value)
                    {
                        student.Groupe = groupes[j].IdGroupe;
                    }
                }
                if (""+worksheet.Cells[i, 1].Value == "1")
                {
                    student.UnderGroupe = true;
                }
                else
                {
                    student.UnderGroupe = false;
                }
                if (""+worksheet.Cells[i, 4].Value == "Б")
                {
                    student.Budget = true;
                }
                else
                {
                    student.Budget = false;
                }
                student.OrderOfEnrollment = ""+worksheet.Cells[i, 1].Value;
                student.TheOrderOfTheAcademyVacation = ""+worksheet.Cells[i, 6].Value;
                student.ReasonVacation = ""+worksheet.Cells[i, 7].Value;
                student.ExitDateFromTheAcademyVacation = ""+worksheet.Cells[i, 8].Value;
                student.RestorationOrder = ""+worksheet.Cells[i, 7].Value;
                student.OrderOfExpulsion = ""+worksheet.Cells[i, 8].Value;
                student.ReasonExpulsion = ""+worksheet.Cells[i, 9].Value;
                student.Gender = ""+worksheet.Cells[i, 10].Value;
                student.RegistrationInMoscow = ""+worksheet.Cells[i, 11].Value;
                student.Birthday = ""+worksheet.Cells[i, 12].Value;
                student.Phone = ""+worksheet.Cells[i, 13].Value;
                student.MothersFullNameMobilePhone = ""+worksheet.Cells[i, 14].Value;
                student.PhathersFullNameMobilePhone = ""+worksheet.Cells[i, 15].Value;
                student.HomePhone = ""+worksheet.Cells[i, 16].Value;
                student.AddressOfActualResidence = ""+worksheet.Cells[i, 17].Value;
                student.AddressOfRegistration = ""+worksheet.Cells[i, 18].Value;
                student.PassportData = ""+worksheet.Cells[i, 19].Value;
                student.MedicalPolicyNumberIssuedByWhom = ""+worksheet.Cells[i, 20].Value;
                student.SNILS = ""+worksheet.Cells[i, 21].Value;
                student.INN = ""+worksheet.Cells[i, 22].Value;
                student.PostalAddress = ""+worksheet.Cells[i, 23].Value;
                student.Competence = ""+worksheet.Cells[i, 24].Value;
                student.VaccinationAgainstCovid19 = ""+worksheet.Cells[i, 25].Value;
                student.HeadOfTheWRC = ""+worksheet.Cells[i, 26].Value;
                
                students.Add(student);
            }
            TestConnection1();
        }
        private static void TestConnection1()
        {
            Workbook wb = new Workbook(@"D:\ИСХОДНИКИ ДЛЯ ХАКАТОНА\Список преподавателей\Преподы.xlsx");


            Worksheet worksheet = wb.Worksheets[0];

            int rows = worksheet.Cells.MaxDataRow;
            int id = 1;
            for (int i = 0; i < rows; i++)
            {
                Teacher teacher = new Teacher();
                teacher.IdTeacher = id;
                id++;
                teacher.FullName = ""+worksheet.Cells[i, 1].Value;
                teachers.Add(teacher);
            }
            TestConnection2();
        }
        private static void TestConnection3()
        {
            Workbook wb = new Workbook(@"D:\ИСХОДНИКИ ДЛЯ ХАКАТОНА\Тарификация преподавателей\123.xls");


            Worksheet worksheet = wb.Worksheets[0];

            int rows = worksheet.Cells.MaxDataRow;
            int id = 1;
            
            for (int i = 3; i < rows; i++)
            {   
                bool check = true;
                for(int j = 0; j < disciplines.Count; j++)
                {
                    if (""+worksheet.Cells[i, 35].Value == disciplines[j].Title) 
                    {
                        check = false;
                    }
                    
                }
                if (check)
                    { 
                        Discipline discipline= new Discipline();
                        discipline.IdDiscipline = id;
                        id++;
                        discipline.Title = ""+worksheet.Cells[i, 35].Value;
                        disciplines.Add(discipline);
                    }
            }
            TestConnection4();
        }
        private static void TestConnection4()
        {
            Workbook wb = new Workbook(@"D:\ИСХОДНИКИ ДЛЯ ХАКАТОНА\Список студентов\Список студентов.xlsx");


            Worksheet worksheet = wb.Worksheets[1];

            int rows = worksheet.Cells.MaxDataRow;
            int id = 1;

            for (int i = 1; i < rows; i++)
            {
                bool check = true;
                for (int j = 0; j < groupes.Count; j++)
                {
                    if ((""+worksheet.Cells[i, 0].Value).Trim() == groupes[j].TitleGroupe)
                    {
                        check = false;
                    }

                }
                if (check)
                {
                    Groupe groupe = new Groupe();
                    groupe.IdGroupe = id;
                    id++;
                    groupe.TitleGroupe = (""+worksheet.Cells[i, 0].Value).Trim();
                    groupes.Add(groupe);
                }
            }
        }



        private static void TestConnection2()
        {
            Workbook wb = new Workbook(@"D:\ИСХОДНИКИ ДЛЯ ХАКАТОНА\Тарификация преподавателей\123.xls");
            
            Worksheet worksheet = wb.Worksheets[5];

            int rows = worksheet.Cells.MaxDataRow;


            

            
            for (int i = 1; i < rows; i++)
            {
                Thariph thariph = new Thariph();
                for (int j = 0; j < teachers.Count;j++) {
                    string[] strings = teachers[j].FullName.Split(' ');
                    string[] strings1 = (""+worksheet.Cells[i, 32].Value).Split(' ');
                    if (strings[0] == strings1[0]) 
                    {
                        thariph.IdTheacher = teachers[j].IdTeacher;
                    }
                }
                for (int j = 0; j < groupes.Count; j++)
                {
                    if (groupes[j].TitleGroupe == ""+worksheet.Cells[i, 33].Value)
                    {
                        thariph.IdTheacher = groupes[j].IdGroupe;
                    }
                }
                for (int j = 0; j < disciplines.Count; j++)
                {
                    string[] strings = (""+worksheet.Cells[i, 35].Value).Split(' ');
                    if (disciplines[j].Title == strings[1])
                    {
                        thariph.IdTheacher = disciplines[j].IdDiscipline;
                    }
                }

                thariphs.Add(thariph);
            }
            TestConnection3();
        }
    }
}
