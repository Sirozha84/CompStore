using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CompStore
{
    public class Filial
    {
        public int ID;
        public string name;
        public string adress;
        public string comment;

        public ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(name);
            str.SubItems.Add(adress);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public bool Contains(string search)
        {
            search = search.ToLower();
            return (name.ToLower().Contains(search) |
                adress.ToLower().Contains(search) |
                comment.ToLower().Contains(search));
        }
    }
}
