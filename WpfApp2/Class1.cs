using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace WpfApp2
{
    public class ModelNotes
    {
        public int number;
        public DateTime date;
        public string NAME;
        public string DESCR;
        public ModelNotes(int number, string Name, string Descr, DateTime date)
        {
            this.NAME = Name;
            this.DESCR = Descr;
            this.date = date;
            this.number = number;
        }
    }
}
