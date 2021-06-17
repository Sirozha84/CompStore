using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompStore
{
    public class Room
    {
        public int ID;
        public int filial;
        public string filialText;
        public string name;
        public string comment;
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

