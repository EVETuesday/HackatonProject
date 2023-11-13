using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp6.Classes;
namespace WpfApp6.Classes
{
    public class ClassHelper
    {
        public static ObservableCollection<Teacher> teachers { get; set; } = new ObservableCollection<Teacher>();
        public static ObservableCollection<Groupe> groupes { get; set; } = new ObservableCollection<Groupe>();
        public static ObservableCollection<Discipline> disciplines { get; set; } = new ObservableCollection<Discipline>();
        public static ObservableCollection<Thariph> thariphs { get; set; } = new ObservableCollection<Thariph>();
        public static ObservableCollection<Student> students { get; set; } = new ObservableCollection<Student>();
        




        public static string StudentsFilePath;
        public static string TeacherFilePath;
        public static string TarificationFilePath;

        public static string VedomostFilePath;
        public static string FolderVedomostFilePath;






        public static bool BlockBTN = false;
        public static bool ComplexExam = false;






        public static int NuberVedomost { get; set; }











        public static void TextInput()
        {
            if (WordData.IdGroup != 1 && WordData.IdMuchitel != 0 && WordData.IdDiscipline != 0)
            {

                var helper = new WordInserter(VedomostFilePath);
                string[] strings = WordData.Signer.Split(' ');
                string fio = strings[0] + " " + strings[1].Substring(0, 1) + ". " + strings[2].Substring(0, 1) + ". ";
                string fio2 = String.Empty;
                if (strings.Length > 4) 
                {
                    fio2 = strings[3] + " " + strings[4].Substring(0, 1) + ". " + strings[5].Substring(0, 1) + ". " + "/__________";
                }
                var items = new Dictionary<string, string>()
            {
                {"<Discipline_name>",  WordData.Discipline},
                {"<Group_name>", WordData.Group },
                {"<Course_name>", WordData.Group[0].ToString() },
                {"<Date>", DateTime.Now.ToString("dd.MM.yyyy") },
                {"<Speciality_name>", WordData.Specialtity },
                {"<Teacher_name>", WordData.Muchitel },
                {"<Signer>", fio + "/__________"},
                {"<Signer2>", fio2}
            };


                helper.Process(items, WordData.Studs);
            }
        }
    }
}
