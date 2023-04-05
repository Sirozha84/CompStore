using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CompStore
{
    public class Service : Record
    {
        public int equipment { get; set; }
        public int work { get; set; }       //1 - Ремонт, 2 - заправка
        public int consumable { get; set; }
        public int counter { get; set; }
        public int rate { get; set; }

        public string eqText;
        public string cnText;
        public string usrText;
        public string depText;
        public override ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(date.ToString("dd.MM.yyyy"));
            str.SubItems.Add(eqText);
            string w = "";
            if (work == 1) w = "Ремонт";
            if (work == 2) w = "Заправка";
            str.SubItems.Add(usrText);
            str.SubItems.Add(depText);
            str.SubItems.Add(w);
            str.SubItems.Add(cnText);
            str.SubItems.Add(counter.ToString("### ### ###"));
            str.SubItems.Add(rate.ToString("### ### ###"));
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public override bool Contains(string search)
        {
            search = search.ToLower();
            return ( eqText.ToLower().Contains(search) |
                     cnText.ToLower().Contains(search) |
                     comment.ToLower().Contains(search));
        }

        /// <summary>
        /// Пересчёт расходов
        /// </summary>
        public void RateCalc()
        {
            if (work != 2) return;

            List<Record> list = DB.Load("services");

            int last = 0;
            foreach (Record r in list)
            {
                Service s = (Service)r;
                int newRate = 0;
                if (s.equipment == equipment)
                {
                    if (s.work == 2 && last != 0) newRate = s.counter - last;
                    if (s.rate != newRate)
                    {
                        s.rate = newRate;
                        DB.Update("services", s);
                    }
                    last = s.counter;
                }
            }

        }
    }
}
