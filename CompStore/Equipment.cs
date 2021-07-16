using System;
using System.Windows.Forms;

namespace CompStore
{
    public class Equipment
    {
        public int ID { get; set; }
        public int eqType { get; set; }
        public int brand { get; set; }
        public int model { get; set; }
        public string sn { get; set; }
        public string iN { get; set; }
        public bool buy { get; set; }
        public DateTime buyDate { get; set; }
        public string comment { get; set; }
        public string nameText { get; set; }
        public ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(nameText);
            str.SubItems.Add(sn);
            str.SubItems.Add(iN);
            str.SubItems.Add("");
            str.SubItems.Add("");
            str.SubItems.Add(buy ? buyDate.ToString("dd.MM.yyyy") : "");
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public bool Contains(string search)
        {
            search = search.ToLower();
            return (nameText.ToLower().Contains(search) |
                sn.ToLower().Contains(search) |
                iN.ToLower().Contains(search) |
                comment.ToLower().Contains(search));
        }

    }
}
