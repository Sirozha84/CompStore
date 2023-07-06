using System;
using System.Windows.Forms;

namespace CompStore
{
    public class User : Record
    {
        public string f { get; set; }
        public string i { get; set; }
        public string o { get; set; }
        public int post { get; set; }
        public int dep { get; set; }
        public int act { get; set; }
        public bool emp { get; set; }
        public DateTime empDate { get; set; }

        public string postText;
        public string depText;
        public string actText;
        public string roomText;
        public override ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(nameText);
            str.SubItems.Add(depText);
            str.SubItems.Add(postText);
            str.SubItems.Add(actText);
            str.SubItems.Add(roomText);
            str.SubItems.Add(comment);
            str.Tag = this;
            SetColor(str);
            return str;
        }

        public override bool Contains(string search)
        {
            search = search.ToLower();
            return (nameText.ToLower().Contains(search) |
                    postText.ToLower().Contains(search) |
                    actText.ToLower().Contains(search) |
                    depText.ToLower().Contains(search) |
                    roomText.ToLower().Contains(search) |
                    comment.ToLower().Contains(search));
        }
    }
}
