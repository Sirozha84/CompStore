using System;
using System.Windows.Forms;

namespace CompStore
{
    public class Move : Record
    {
        public int equipment { get; set; }
        public int user { get; set; }
        public int room { get; set; }
        public DateTime date { get; set; }

        public string eqText;
        public string userText;
        public string roomText;

        public override ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(date.ToString("dd.MM.yyyy"));
            str.SubItems.Add(eqText);
            str.SubItems.Add(userText);
            str.SubItems.Add(roomText);
            str.SubItems.Add(molText);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public override bool Contains(string search)
        {
            search = search.ToLower();
            return (eqText.ToLower().Contains(search) |
                     userText.ToLower().Contains(search) |
                     roomText.ToLower().Contains(search) |
                     molText.ToLower().Contains(search) |
                     comment.ToLower().Contains(search));
        }

        public Move newMove(int equipment)
        {
            Move move = new Move();
            move.equipment = equipment;
            move.user = user;
            move.room = room;
            move.date = date;
            move.mol = mol;
            move.comment = comment;
            return move;
        }
    }
}
