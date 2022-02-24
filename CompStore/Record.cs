﻿using System;
using System.Windows.Forms;

namespace CompStore
{
    public abstract class Record
    {
        public int ID { get; set; }
        public string nameText { get; set; }
        public string comment { get; set; }
        public abstract ListViewItem ToListView();
        public abstract bool Contains(string search);
    }
}
