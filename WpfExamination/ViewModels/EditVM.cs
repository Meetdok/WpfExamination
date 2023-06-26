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
    internal class EditVM
    {
        public List<AirplanesClass> AirplanesClass { get; set; }
        public Airplane EditAirplane { get; set; }
        public CommandVM EditAir { get; set; }
        Airplane original;       

        public EditVM(Airplane airplane)
        {
            AirplanesClass = AviaSalesContext.GetInstance().AirplanesClasses.ToList(); //СПИСОК

            original = airplane; ////РЕДАКТИРОВАНИЕ
            this.EditAirplane = new Airplane
            {
                AirplanesId = airplane.AirplanesId,
                AirplaneTitle = airplane.AirplaneTitle,
                Places = airplane.Places,
                ClassId = airplane.ClassId
            };


            EditAir = new CommandVM(() => {
                AviaSalesContext.GetInstance().Entry<Airplane>(original).
                       CurrentValues.SetValues(EditAirplane);
                AviaSalesContext.GetInstance().SaveChanges();
                MessageBox.Show("Заебал");
            });
        }
    }
}
