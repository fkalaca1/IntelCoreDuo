using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    public class Ocjena
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OcjenaId { get; set; }
        private int ocjenaP;
        private String komentar;
        private Parking maticni;
        private User ocjenitelj;

        public Ocjena() { }
        public event PropertyChangedEventHandler PropertyChanged;

        public Ocjena(int ocjenaP, String komentar, Parking maticni, User ocjenitelj)
        {
            this.ocjenaP = ocjenaP;
            this.komentar = komentar;
            this.maticni = maticni;
            this.ocjenitelj = ocjenitelj;
        }

        public int ParkingId { get; set; }
        public int UserId { get; set; }
        public int OcjenaP { get { return ocjenaP; } set { Set(ref ocjenaP, value); } }
        public String Komentar { get { return komentar; } set { Set(ref komentar, value); } }
        [ForeignKey("ParkingId")]
        public virtual Parking Maticni { get { return maticni; } set { Set(ref maticni, value); } }
        [ForeignKey("UserId")]
        public virtual User Ocjenitelj { get { return ocjenitelj; } set { Set(ref ocjenitelj, value); } }

        protected virtual void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool Set<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (Equals(storage, value)) return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
