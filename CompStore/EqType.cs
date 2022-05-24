using System.Windows.Forms;

namespace CompStore
{
    public class EqType : Record
    {
        public bool printer { get; set; }

        public override ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(name);
            str.SubItems.Add(printer ? "Да" : "");
            str.Tag = this;
            return str;
        }

        public override bool Contains(string search)
        {
            search = search.ToLower();
            return name.ToLower().Contains(search);
        }
    }
}
