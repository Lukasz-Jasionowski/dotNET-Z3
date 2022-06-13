using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_Z3
{
    class Model
    {
        LinkedList<Record> records = new LinkedList<Record>();
        public LinkedList<Record> Records { get => records; set => records = value; }
        public Model()
        {
            records.AddLast(new Record("Metal","Andrzej","Czarna Strefa","CD","3.20"));
        }
    }
}
