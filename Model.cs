using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_Z3
{
    class Model
    {

        public ObservableCollection<Record> Records{ get; set;} = new ObservableCollection<Record>();

        public Model()
        {
            Records.Add(new Record("Alladyn", "Guy Ritchie", "Disney", "DVD", "02:08:12"));
            Records.Add(new Record("Mainstream Sellout", "Machine Gun Kelly", "Bad Boy/Interscope", "CD", "00:40:18"));
            Records.Add(new Record("That’s the Spirit", "Bring Me The Horizon", "RCA Records Label", "CD", "00:43:61"));
            Records.Add(new Record("Warcraft: Początek", "Duncan Jones", "Legendary Pictures", "DVD", "02:03:05"));
            Records.Add(new Record("Solutions ", "K.Flay", "Night Street Records", "CD", "00:36:48"));
            Records.Add(new Record("Tomb Raider", "Roar Uthaug", "Warner Bros", "DVD", "01:58:13"));
        }

        internal Record AddNewRecord()
        {
            Record newRecord = new Record();
            Records.Add(newRecord);
            return newRecord;
        }
    }
}