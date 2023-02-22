using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static TableInfo tableinfo;
        public static DateTime SelDate = DateTime.Today;
        public MainWindow()
        {
            InitializeComponent();
            tableinfo = new TableInfo(SelDate);
            updateNoteswindow();
            dateContainer.SelectedDate = SelDate;
        }
        public void updateNoteswindow()
        {
            SelDate = tableinfo.SelDate2;
            Noteswindow.Items.Clear();
            tableinfo.update2Notes();
            foreach (ModelNotes notemodel in tableinfo.NowDataNotes)
            {
                Noteswindow.Items.Add(notemodel.NAME);
            }
            NAMEBox.Text = "";
            DescrBox.Text = "";
        }
        private void CreBut(object sender, RoutedEventArgs e)
        {
            string NAME = NAMEBox.Text;
            string descr = DescrBox.Text;
            tableinfo.NewNote(NAME, descr, SelDate);
            updateNoteswindow();
        }
        private void DelBut(object sender, RoutedEventArgs e)
        {
            tableinfo.DelNote(todayId: tableinfo.SelId);
            updateNoteswindow();
        }
        private void ChangeSelect(object sender, SelectionChangedEventArgs e)
        {
            if (Noteswindow.SelectedIndex != -1)
            {
                tableinfo.SelId = Noteswindow.SelectedIndex;
                ModelNotes selectedNote = tableinfo.NowDataNotes[tableinfo.SelId];
                NAMEBox.Text = selectedNote.NAME;
                DescrBox.Text = selectedNote.DESCR;
            }
        } 
    }
}