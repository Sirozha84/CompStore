using System.Windows.Forms;

namespace CompStore
{
    public class Model
    {
        public int ID { get; set; }
        public int eqType { get; set; }
        public int brand { get; set; }
        public string name { get; set; }
        public string comment { get; set; }
        public string eqTypeText { get; set; }
        public string brandText { get; set; }
        public string nameText { get; set; }

        public ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(eqTypeText);
            str.SubItems.Add(brandText);
            str.SubItems.Add(name);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public bool Contains(string search)
        {
            search = search.ToLower();
            return (eqTypeText.ToLower().Contains(search) |
                brandText.ToLower().Contains(search) |
                name.ToLower().Contains(search) |
                comment.ToLower().Contains(search));
        }
    }
}
