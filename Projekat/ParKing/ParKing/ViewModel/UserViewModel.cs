using ParKing.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.ViewModel
{
    class UserViewModel
    {
        public User User { get; set; }
        public UserViewModel()
        {
            List<Parking> parkinzi = new List<Parking>();
            //kupljenje parkinga iz baze
            User temp;
            if (parkinzi.Count != 0) temp = new VlasnikParkinga("riktash38@gmail.com", "062/157-463", "huehuehue", parkinzi);
            else temp = new User("riktash38@gmail.com", "062/157-463", "huehuehue");
            User = temp;
        }
    }
}
