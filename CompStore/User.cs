using System;
using System.Windows.Forms;

namespace CompStore
{
    public class User
    {
        public int ID;
        public string f;
        public string i;
        public string o;
        public int post;
        public int dep;
        public int filial;
        public int building;
        public int room;
        public bool emp = true;
        public DateTime empDate = DateTime.Now;
        public bool dis;
        public DateTime disDate = DateTime.Now;
        public string comment;

        public string fioText;
        public string postText;
        public string depText;
        public string roomText;
        public ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(fioText);
            str.SubItems.Add(postText);
            str.SubItems.Add(depText);
            str.SubItems.Add(roomText);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public bool Contains(string search)
        {
            search = search.ToLower();
            return (fioText.ToLower().Contains(search) |
                    postText.ToLower().Contains(search) |
                    depText.ToLower().Contains(search) |
                    roomText.ToLower().Contains(search) |
                    comment.ToLower().Contains(search));
        }

    }
}
