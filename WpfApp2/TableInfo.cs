using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class TableInfo
    {
        public List<ModelNotes> NowDataNotes;
        public DateTime SelDate2;
        public int SelId = -1;
        public List<ModelNotes> FullAllNotes;
        public TableInfo(DateTime date)
        {
            this.NowDataNotes = DeserandSeser.JsonNotesLoad(date);
            this.FullAllNotes = DeserandSeser.JsonNotesLoad(default);
            SelDate2 = date;
        }
        public void update2Notes()
        {
            this.NowDataNotes = DeserandSeser.JsonNotesLoad(this.SelDate2);
        }
        public void UpdateNotes()
        {
            DeserandSeser.JsonNotesSave(this.FullAllNotes);
        }
        public void NewNote(string NAME, string Descr, DateTime date)
        {

            ModelNotes notemodel = new ModelNotes(this.FullAllNotes.Count, NAME, Descr, date);
            this.FullAllNotes.Add(notemodel);
            DeserandSeser.JsonNotesSave(this.FullAllNotes);
            this.update2Notes();
        }

        public void DelNote(int number = -1, int todayId = -1)
        {
            if (todayId != -1)
                number = this.NowDataNotes[todayId].number;
            List<ModelNotes> newNotes = new List<ModelNotes>();
            foreach (ModelNotes notemodel in this.FullAllNotes)
            {
                if (notemodel.number != number)
                {
                    newNotes.Add(notemodel);
                }
            }
            this.FullAllNotes = newNotes;
            update2Notes();
            UpdateNotes();
        }
    }
}
