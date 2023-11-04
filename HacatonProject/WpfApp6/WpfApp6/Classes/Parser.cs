using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WpfApp6.Classes.ClassHelper;

namespace WpfApp6.Classes
{
    public class Parser
    {

        public static void TestConnection3()
        {
            students.Clear();

            Workbook wb = new Workbook(StudentsFilePath);

            Worksheet worksheet = wb.Worksheets[1];

            int id = 1;
            int rows = worksheet.Cells.MaxDataRow;

            for (int i = 1; i < rows+1; i++)
            {
                Student student = new Student();

                student.IDStudent = id;
                id++;
                try
                {

                    string[] fullname = ("" + worksheet.Cells[i, 5].Value).Split(' ');
                    foreach (string name in fullname)
                    {
                        if (name != "")
                            student.FullName += name + " ";
                    }

                    for (int j = 1; j < groupes.Count; j++)
                    {

                        string[] strings = groupes[j].TitleGroupe.Split(' ');
                        string group = strings[0].Substring(1, strings[0].Length - 1);

                        if (group.Substring(0, 1) == "-")
                        {
                            group = group.Substring(1, group.Length - 1);
                        }
                        if (group.Substring(group.Length - 2, 2) == "ВБ")
                        {
                            group = group.Substring(0, group.Length - 2);
                        }
                        string group1 = null;
                        if ("" + worksheet.Cells[i, 0].Value != "" && "" + worksheet.Cells[i, 0].Value != "0")
                        {
                            string[] strings1 = ("" + worksheet.Cells[i, 0].Value).Split(' ');
                            group1 = strings1[0].Substring(1, strings1[0].Length - 1);
                            if (group1.Substring(0, 1) == "-")
                            {
                                group1 = group1.Substring(1, group1.Length - 1);
                            }
                            if (group1.Substring(group1.Length - 2, 2) == "ВБ")
                            {
                                group1 = group1.Substring(0, group1.Length - 2);
                            }
                        }


                        if (group == group1)
                        {
                            student.Groupe = groupes[j].IdGroupe;
                            j = groupes.Count;

                        }
                    }
                    student.UnderGroupe = "" + worksheet.Cells[i, 1].Value; 
                    student.Budget = "" + worksheet.Cells[i, 4].Value; 
                    student.GroupeString = "" + worksheet.Cells[i, 0].Value;
                    student.OrderOfEnrollment = "" + worksheet.Cells[i, 6].Value;
                    student.Specialtity = "" + worksheet.Cells[i, 2].Value;
                    student.Kurator = "" + worksheet.Cells[i, 3].Value;
                    student.TheOrderOfTheAcademyVacation = "" + worksheet.Cells[i, 7].Value;
                    student.ReasonVacation = "" + worksheet.Cells[i, 8].Value;
                    student.ExitDateFromTheAcademyVacation = "" + worksheet.Cells[i, 9].Value;
                    student.RestorationOrder = "" + worksheet.Cells[i, 10].Value;
                    student.OrderOfExpulsion = "" + worksheet.Cells[i, 11].Value;
                    student.ReasonExpulsion = "" + worksheet.Cells[i, 12].Value;
                    student.Gender = "" + worksheet.Cells[i, 13].Value;
                    student.RegistrationInMoscow = "" + worksheet.Cells[i, 14].Value;
                    student.Birthday = "" + worksheet.Cells[i, 15].Value;
                    student.Phone = "" + worksheet.Cells[i, 16].Value;
                    student.MothersFullNameMobilePhone = "" + worksheet.Cells[i, 17].Value;
                    student.PhathersFullNameMobilePhone = "" + worksheet.Cells[i, 18].Value;
                    student.HomePhone = "" + worksheet.Cells[i, 19].Value;
                    student.AddressOfActualResidence = "" + worksheet.Cells[i, 20].Value;
                    student.AddressOfRegistration = "" + worksheet.Cells[i, 21].Value;
                    student.PassportData = "" + worksheet.Cells[i, 22].Value;
                    student.MedicalPolicyNumberIssuedByWhom = "" + worksheet.Cells[i, 23].Value;
                    student.SNILS = "" + worksheet.Cells[i, 24].Value;
                    student.INN = "" + worksheet.Cells[i, 25].Value;
                    student.PostalAddress = "" + worksheet.Cells[i, 26].Value;
                    student.Competence = "" + worksheet.Cells[i, 27].Value;
                    student.VaccinationAgainstCovid19 = "" + worksheet.Cells[i, 28].Value;
                    student.HeadOfTheWRC = "" + worksheet.Cells[i, 29].Value;

                    students.Add(student);
                }
                catch (Exception ex)
                {

                }
            }
        }
        public static void TestConnection2()
        {

            teachers.Clear();

            Workbook wb = new Workbook(TeacherFilePath);


            Worksheet worksheet = wb.Worksheets[0];

            int rows = worksheet.Cells.MaxDataRow;
            int id = 1;
            Teacher teacher1 = new Teacher();
            for (int i = 0; i < rows + 1; i++)
            {

                Teacher teacher = new Teacher();
                teacher.IdTeacher = id;
                id++;
                string[] fullname = ("" + worksheet.Cells[i, 0].Value).Split(' ');



                foreach (string name in fullname)
                {
                    if (name != "")
                    {
                        teacher.FullName += name + " ";
                    }
                }
                teachers.Add(teacher);
            }

        }
        public static void TestConnection1()
        {

            disciplines.Clear();
            Workbook wb = new Workbook(TarificationFilePath);


            Worksheet worksheet = wb.Worksheets[0];

            int rows = worksheet.Cells.MaxDataRow;
            int id = 1;

            for (int i = 3; i < rows; i++)
            {
                bool check = true;
                for (int j = 0; j < disciplines.Count; j++)
                {
                    if ("" + worksheet.Cells[i, 0].Value == disciplines[j].Title)
                    {
                        check = false;
                    }

                }
                if (check)
                {
                    Discipline discipline = new Discipline();
                    discipline.IdDiscipline = id;
                    id++;
                    discipline.Title = "" + worksheet.Cells[i, 0].Value;
                    disciplines.Add(discipline);
                }
            }
        }
        public static void TestConnection()
        {

            groupes.Clear();
            Workbook wb = new Workbook(StudentsFilePath);


            Worksheet worksheet = wb.Worksheets[1];

            int rows = worksheet.Cells.MaxDataRow;
            int id = 1;

            Groupe groupe1 = new Groupe();
            groupe1.IdGroupe = id;
            id++;
            groupe1.TitleGroupe = ("Все группы");
            groupes.Add(groupe1);

            for (int i = 1; i < rows; i++)
            {
                bool check = true;
                for (int j = 0; j < groupes.Count; j++)
                {
                    string[] strings = groupes[j].TitleGroupe.Split(' ');
                    string group = strings[0].Substring(1, strings[0].Length - 1);

                    if (group.Substring(0, 1) == "-")
                    {
                        group = group.Substring(1, group.Length - 1);
                    }
                    if (group.Substring(group.Length - 2, 2) == "ВБ")
                    {
                        group = group.Substring(0, group.Length - 2);
                    }
                    string group1 = null;
                    if ("" + worksheet.Cells[i, 0].Value != "" && "" + worksheet.Cells[i, 0].Value != "0")
                    {
                        string[] strings1 = ("" + worksheet.Cells[i, 0].Value).Split(' ');
                        group1 = strings1[0].Substring(1, strings1[0].Length - 1);
                        if (group1.Substring(0, 1) == "-")
                        {
                            group1 = group1.Substring(1, group1.Length - 1);
                        }
                        if (group1.Substring(group1.Length - 2, 2) == "ВБ")
                        {
                            group1 = group1.Substring(0, group1.Length - 2);
                        }
                    }


                    if (group == group1)
                    {

                    check = false;
                    }
                    
                }
                if (check)
                {
                    Groupe groupe = new Groupe();
                    groupe.IdGroupe = id;
                    id++;
                    groupe.TitleGroupe = ("" + worksheet.Cells[i, 0].Value).Trim();
                    groupes.Add(groupe);
                }
            }

        }


        


    }
}
