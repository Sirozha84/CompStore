﻿using System.Windows.Forms;

namespace CompStore
{
    public class Dep
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string comment { get; set; }

        public ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(name);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public bool Contains(string search)
        {
            search = search.ToLower();
            return (name.ToLower().Contains(search) |
                comment.ToLower().Contains(search));
        }
    }
}
