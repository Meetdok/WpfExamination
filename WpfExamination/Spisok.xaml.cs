using Microsoft.EntityFrameworkCore;
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
using System.Windows.Shapes;
using WpfExamination.DB;
using WpfExamination.Models;
using WpfExamination.Tools;
using WpfExamination.ViewModels;

namespace WpfExamination
{
    /// <summary>
    /// Логика взаимодействия для Spisok.xaml
    /// </summary>
    public partial class Spisok : Window
    {      
        public Spisok()
        {
            InitializeComponent();
            DataContext = new SpisokVM();
           
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            Spisok newWin = new Spisok();           
            newWin.Show();
            this.Close();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            AddAirplane addAirplane = new AddAirplane();
            addAirplane.Show();
        }
    }
}
