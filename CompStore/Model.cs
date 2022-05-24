using System.Windows.Forms;

namespace CompStore
{
    public class Model : Record
    {
        public int eqType { get; set; }
        public int vendor { get; set; }
        public int consumable { get; set; }
        public string eqTypeText { get; set; }
        public string vendorText { get; set; }
        public string conText { get; set; }

        public override ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(eqTypeText);
            str.SubItems.Add(vendorText);
            str.SubItems.Add(name);
            str.SubItems.Add(conText);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public override bool Contains(string search)
        {
            search = search.ToLower();
            return (eqTypeText.ToLower().Contains(search) |
                vendorText.ToLower().Contains(search) |
                name.ToLower().Contains(search) |
                conText.ToLower().Contains(search) |
                comment.ToLower().Contains(search));
        }
    }
}
