using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для GroupePage.xaml
    /// </summary>
    public partial class GroupePage : Page
    {
        public MainWindow mainWindow;

        public GroupePage(MainWindow mainWindow)
        {
            InitializeComponent();
            getGroups();
            this.mainWindow = mainWindow;
            TestConnection();
            TestConnection1();
            TestConnection2();
            TestConnection3();

        }
        void getGroups()
        {
            lvMain.ItemsSource = groupes;
        }
        void getGroups(string word)
        {
            List<Groupe> list = groupes.Where(i=>i.TitleGroupe.ToLower().Contains(word.ToLower())).ToList();
            lvMain.ItemsSource = list;
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            getGroups(tbSearch.Text);
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }
            Groupe selectedProduct = button.DataContext as Groupe;
            if (selectedProduct != null)
            {
                IdGroup = selectedProduct.IdGroupe;
                Group = selectedProduct.TitleGroupe;
                if (IdGroup != 1)
                { 
                    Specialtity = students.Where(i => i.Groupe == selectedProduct.IdGroupe).FirstOrDefault().Specialtity;
                }
                
                List<string> strings = new List<string>();
                foreach (Student name in students.Where(i => i.Groupe == selectedProduct.IdGroupe))
                {
                    if(name.ReasonExpulsion != null && name.ReasonVacation != null)
                    {
                        strings.Add(name.FullName);
                    }
                   
                }
                WordData.Studs = strings.ToArray();
                mainWindow.GetInfoLV();
                BlockBTN = true;
            }
        }
    }
}
