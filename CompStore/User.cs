using System;
using System.Windows.Forms;

namespace CompStore
{
    public class User
    {
        public int ID;
        public string f { get; set; }
        public string i { get; set; }
        public string o { get; set; }
        public int post { get; set; }
        public int dep { get; set; }
        public int room { get; set; }
        public bool emp { get; set; }
        public DateTime empDate { get; set; }
        public bool dis { get; set; }
        public DateTime disDate { get; set; }
        public string comment { get; set; }

        public string nameText;
        public string postText;
        public string depText;
        public string roomText;
        public ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(nameText);
            str.SubItems.Add(depText);
            str.SubItems.Add(postText);
            str.SubItems.Add(roomText);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public bool Contains(string search)
        {
            search = search.ToLower();
            return (nameText.ToLower().Contains(search) |
                    postText.ToLower().Contains(search) |
                    depText.ToLower().Contains(search) |
                    roomText.ToLower().Contains(search) |
                    comment.ToLower().Contains(search));
        }

    }
}
