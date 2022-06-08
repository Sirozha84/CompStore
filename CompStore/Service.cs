using System;
using System.Windows.Forms;

namespace CompStore
{
    public class Service : Record
    {
        public int equipment { get; set; }
        public int work { get; set; }       //1 - Ремонт, 2 - заправка
        public int consumable { get; set; }
        public int counter { get; set; }

        public string eqText;
        public string cnText;
        public override ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(date.ToString("dd.MM.yyyy"));
            str.SubItems.Add(eqText);
            string w = "";
            if (work == 1) w = "Ремонт";
            if (work == 2) w = "Запрвака";
            str.SubItems.Add(w);
            str.SubItems.Add(cnText);
            str.SubItems.Add(counter.ToString("### ### ###"));
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public override bool Contains(string search)
        {
            search = search.ToLower();
            return ( eqText.ToLower().Contains(search) |
                     cnText.ToLower().Contains(search) |
                     comment.ToLower().Contains(search));
        }
    }
}
