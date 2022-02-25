using System.Windows.Forms;

namespace CompStore
{
    public class Post : Record
    {
        public override ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(name);
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
