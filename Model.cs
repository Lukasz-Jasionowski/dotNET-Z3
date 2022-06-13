using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_Z3
{
    class Model : INotifyPropertyChanged
    {
        LinkedList<Record> records = new LinkedList<Record>();

        public event PropertyChangedEventHandler PropertyChanged;

        public LinkedList<Record> Records { get => records; set => records = value; }

        public Model()
        {
            records.AddLast(new Record("Alladyn", "Guy Ritchie", "Disney", "DVD", "02:08:12"));
            records.AddLast(new Record("Mainstream Sellout", "Machine Gun Kelly", "Bad Boy/Interscope", "CD", "00:40:18"));
            records.AddLast(new Record("That’s the Spirit", "Bring Me The Horizon", "RCA Records Label", "CD", "00:43:61"));
            records.AddLast(new Record("Warcraft: Początek", "Duncan Jones", "Legendary Pictures", "DVD", "02:03:05"));
            records.AddLast(new Record("Solutions ", "K.Flay", "Night Street Records", "CD", "00:36:48"));
            records.AddLast(new Record("Tomb Raider", "Roar Uthaug", "Warner Bros", "DVD", "01:58:13"));
        }

        internal Record AddNewRecord()
        {
            Record newRecord = new Record();
            records.AddLast(newRecord);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Records"));
            return newRecord;
        }
    }
}