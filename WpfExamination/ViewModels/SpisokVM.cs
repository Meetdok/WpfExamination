using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfExamination.DB;
using WpfExamination.Models;
using WpfExamination.Tools;

namespace WpfExamination.ViewModels
{
    internal class SpisokVM
    {
        public List<Airplane> Airplanes { get; set; }
        public CommandVM Delete { get; set; }
        public Airplane SelectedAirplane { get; set; }

        public SpisokVM()
       {            
            Airplanes = AviaSalesContext.GetInstance().Airplanes.Include(s => s.Class).ToList(); //СПИСОК
                    
            Delete = new CommandVM(() => {              
                try
                {
                    AviaSalesContext.GetInstance().Airplanes.Remove(SelectedAirplane); //УДАЛЕНИЕ
                    AviaSalesContext.GetInstance().SaveChanges();
                    MessageBox.Show("Удалилось");
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            });
        }
    }
}
