using System;
using System.Windows.Forms;

namespace CompStore
{
    public abstract class Record
    {
        public int ID { get; set; }
        public abstract ListViewItem ToListView();
    }
}
