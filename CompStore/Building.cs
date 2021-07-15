using System.Windows.Forms;

namespace CompStore
{
    public class Building
    {
        public int ID { get; set; }
        public int filial { get; set; }
        public string name { get; set; }
        public string comment { get; set; }
        public string filialText { get; set; }
        public string nameText { get; set; }

        public ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(filialText);
            str.SubItems.Add(name);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public bool Contains(string search)
        {
            search = search.ToLower();
            return (filialText.ToLower().Contains(search) |
                name.ToLower().Contains(search) |
                comment.ToLower().Contains(search));
        }
    }
}
