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
    internal class AddVM
    {
        public List<AirplanesClass> AirplanesClass { get; set; }
        public AirplanesClass SelectedClass { get; set; }       
        public string Title { get; set; }
        public int Seats { get; set; }
        public CommandVM Add { get; set; }
        public AddVM()
        {
            AirplanesClass = AviaSalesContext.GetInstance().AirplanesClasses.ToList();

            Add = new CommandVM(() =>
            {
                var add = AviaSalesContext.GetInstance().Add(new Airplane {AirplaneTitle = Title, Places = Seats, ClassId = SelectedClass.AirplaneClassId });
                AviaSalesContext.GetInstance().SaveChanges();
                MessageBox.Show("Сохранилось");
            });
        }
    }
}
