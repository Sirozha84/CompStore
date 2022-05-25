using System;
using System.Windows.Forms;

namespace CompStore
{
    internal class Service : Record
    {
        public int equipment { get; set; }
        public DateTime date { get; set; }
        public int work { get; set; }
        public int consumable { get; set; }
        public int counter { get; set; }

        public override ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(date.ToString("dd.MM.yyyy"));
            str.SubItems.Add(molText);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public override bool Contains(string search)
        {
            search = search.ToLower();
            return ( molText.ToLower().Contains(search) |
                     comment.ToLower().Contains(search));
        }
    }
}
