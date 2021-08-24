using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace CompStore
{
    static class Reports
    {
        static Graphics g;

        public static void UserCard(bool preview, List<User> users, List<Equipment> equipments)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrintPage += new PrintPageEventHandler(UserCardPage);
            doc.DocumentName = "Карточка учёта";

            if (preview)
            {
                PrintPreviewDialog dialog = new PrintPreviewDialog();
                dialog.Document = doc;
                dialog.ShowIcon = false;
                dialog.ClientSize = new Size(1200, 800);
                dialog.ShowDialog();
            }
            else
            {
                PrintDialog dialog = new PrintDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    doc.PrinterSettings = dialog.PrinterSettings;
                    doc.PrinterSettings.DefaultPageSettings.Landscape = true;
                    try { doc.Print(); } catch { }
                }
            }
        }


        static void UserCardPage(object sender, PrintPageEventArgs e)
        {
            g = e.Graphics;
            g.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(0, 0, 100, 100));
        }
    }
}
