using System.Windows.Forms;

namespace CompStore
{
    public class Filial : Record
    {
        public string adress { get; set; }

        public override ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(name);
            str.SubItems.Add(adress);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public override bool Contains(string search)
        {
            search = search.ToLower();
            return (name.ToLower().Contains(search) |
                adress.ToLower().Contains(search) |
                comment.ToLower().Contains(search));
        }
    }
}
