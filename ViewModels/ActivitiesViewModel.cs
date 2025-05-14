using marjetaUredi.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marjetaUredi.Data.DataModels;

namespace marjetaUredi.ViewModels
{
    public class ActivitiesViewModel : BaseViewModel
    {

        //private workshoprepository _workshoprepo;
        //public ObservableCollection<Workshop> Workshops { get; set; }

        //v konstruktorju se naredi objekt repositoryija
        // -->>  stinrg conection ; _workshoprepo = new workshoprepository(connectionString);

        //var workshopsList = _workshoprepo.GetAllWorkshops();
        //Workshops = new ObservableCollection<Workshop>(workshopsList);

        public ObservableCollection<Workshop> WorkshopsList;

        public ActivitiesViewModel()
        {
            WorkshopsRepository workshopsRepository = new WorkshopsRepository();

            WorkshopsList = workshopsRepository.getWorkshopsList();

        }

    }
}
