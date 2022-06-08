using System;
using System.Windows.Forms;
using System.Drawing;

namespace CompStore
{
    public abstract class Record
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string nameText { get; set; }    //Имя в текстовом виде, на случай когда у элемента нет имени и оно складывается и разных данных
        public string comment { get; set; }

        //Поля, которые не читаются из List<Record>, когда находятся в дочерних классах
        public DateTime date { get; set; }
        public string nameINText { get; set; }
        public int room { get; set; }
        public bool dis { get; set; }
        public DateTime disDate { get; set; }
        public int mol { get; set; }

        public string molText;                   

        public abstract ListViewItem ToListView();
        public abstract bool Contains(string search);

        internal void SetColor(ListViewItem str)
        {
            if (dis)
            {
                str.ForeColor = Color.Gray;
                str.BackColor = Color.LightGray;
            }
        }
    }
}
