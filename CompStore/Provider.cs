using System.Windows.Forms;

namespace CompStore
{
    public class Provider
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string manager { get; set; }
        public string comment { get; set; }

        public ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(name);
            str.SubItems.Add(adress);
            str.SubItems.Add(phone);
            str.SubItems.Add(manager);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public bool Contains(string search)
        {
            search = search.ToLower();
            return (name.ToLower().Contains(search) |
                adress.ToLower().Contains(search) |
                phone.ToLower().Contains(search) |
                manager.ToLower().Contains(search) |
                comment.ToLower().Contains(search));
        }
    }
}
