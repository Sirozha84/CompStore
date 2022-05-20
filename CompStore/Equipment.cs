using System;
using System.Windows.Forms;
using System.Globalization;

namespace CompStore
{
    public class Equipment : Record
    {
        public int model { get; set; }
        public string sn { get; set; }
        public string iN { get; set; }
        public bool iNv { get; set; }
        public string mac { get; set; }
        public string ip { get; set; }
        public string prop { get; set; }
        public string price { get; set; }
        public int provider { get; set; }
        public bool buy { get; set; }
        public DateTime buyDate { get; set; }
        public bool dec { get; set; }
        public DateTime decDate { get; set; }
        public bool printer { get; set; }
        public int consumable { get; set; }
        public int user;
        public string userText;
        public string roomText;
        public string isDtText;
        public string provText;
        public override ListViewItem ToListView()
        {
            ListViewItem str = new ListViewItem(nameText);
            str.SubItems.Add(sn);
            str.SubItems.Add(iN);
            str.SubItems.Add(userText);
            str.SubItems.Add(roomText);
            str.SubItems.Add(mac);
            str.SubItems.Add(ip);
            str.SubItems.Add(isDtText != "" ? DateTime.ParseExact(isDtText, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("dd.MM.yyyy") : "");
            str.SubItems.Add(buy ? buyDate.ToString("dd.MM.yyyy") : "");
            str.SubItems.Add(dec ? decDate.ToString("dd.MM.yyyy") : "");
            str.SubItems.Add(molText);
            str.SubItems.Add(comment);
            str.Tag = this;
            return str;
        }

        public override bool Contains(string search)
        {
            search = search.ToLower();
            return (nameText.ToLower().Contains(search) |
                sn.ToLower().Contains(search) |
                iN.ToLower().Contains(search) |
                userText.ToLower().Contains(search) |
                roomText.ToLower().Contains(search) |
                isDtText.ToLower().Contains(search) |
                mac.ToLower().Contains(search) |
                ip.ToLower().Contains(search) |
                comment.ToLower().Contains(search));
        }

    }
}
