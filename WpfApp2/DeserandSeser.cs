using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApp2
{
    public class DeserandSeser
    {
        public static void JsonNotesSave(List<ModelNotes> allnotes)
        {
            File.WriteAllText("jsonnotes.json", JsonConvert.SerializeObject(allnotes));
        }
        public static List<ModelNotes> JsonNotesLoad(DateTime date = default)
        {
            List<ModelNotes> allnotes = new List<ModelNotes>();
            try
            {
                List<ModelNotes> raw_notes = JsonConvert.DeserializeObject<List<ModelNotes>>(File.ReadAllText("jsonnotes.json"));
                foreach (ModelNotes notemodel in raw_notes)
                {
                    if (notemodel.date == date || date == default)
                        allnotes.Add(notemodel);
                }
            }
            catch
            {
                allnotes = new List<ModelNotes>();
                File.WriteAllText("jsonnotes.json", JsonConvert.SerializeObject(allnotes));

            }
            return allnotes;
        }
    }
}
