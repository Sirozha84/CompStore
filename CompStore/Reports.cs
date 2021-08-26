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
        static List<User> users;
        static List<Equipment> equipments;
        static int itemNumber;
        static int pageNumber;

        //Шрифты и карандаши
        static Graphics g;
        static Font font10 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);
        static Font font10B = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Pixel);
        static Font font20B = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel);
        static StringFormat inCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
        static StringFormat inLeft = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };
        static StringFormat inRight = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };
        static Pen slim = new Pen(Color.Black, 1);
        static Pen bold = new Pen(Color.Black, 2);

        const int leftBorder = 80;
        const int topBorder = 80;
        static int[] columns;
        static int[] rows;

        public static void UserCard(bool preview, List<User> usersList, List<Equipment> equipmentsList)
        {
            users = usersList;
            equipments = equipmentsList;
            itemNumber = 0;
            pageNumber = 0;

            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrintPage += new PrintPageEventHandler(UserCardPage);
            doc.DocumentName = "Карточка учёта";

            if (preview)
            {
                PrintPreviewDialog dialog = new PrintPreviewDialog();
                dialog.Document = doc;
                dialog.ShowIcon = false;
                dialog.ClientSize = new Size(1100, 800);
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
            User user = users[itemNumber];
            g = e.Graphics;
            columns = new int[] { 140, 90, 90, 80, 70, 100, 70, 70, 70, 70, 80, 50, 50 };
            rows = new int[] { 20, 20, 20, 20, 20, 20, 20, 26, 41, 41, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };

            write(g, 3, 0, 3, 1, "КАРТОЧКА № ___", font20B, 0, 0);
            write(g, 2, 1, 4, 1, "учёта малоценных и быстроизнашивающихся предметов", font10B, 0, 0);
            write(g, 0, 3, "Организация", font10, 0, 0);
            write(g, 1, 3, 2, 1, "___", font10, 0, 0);
            write(g, 0, 5, "Структурное подразделение", font10, 0, 0);
            write(g, 1, 5, 2, 1, "___", font10B, 0, 0);

            write(g, 9, 0, 4, 1, "Типовая межотраслевая форма № МБ-2", font10, 0, 0);
            write(g, 9, 1, 4, 1, "Утверждена Постановлением Госкомстата России", font10, 0, 0);
            write(g, 9, 2, 4, 1, "от 30.10.1997 № 71а", font10, 0, 0);
            write(g, 11, 3, 2, 1, "Коды", font10, 1, 1);
            write(g, 9, 4, 2, 1, "Форма по ОКУД", font10, 2, 0);
            write(g, 11, 4, 2, 1, "0320001", font10, 1, 1);
            write(g, 9, 5, 2, 1, "по ОКПО", font10, 2, 0);
            write(g, 11, 4, 2, 2, "", font10, 0, 2);

            write(g, 3, 7, 1, 2, "Дата\nсоставления", font10, 1, 2);
            write(g, 4, 7, 1, 2, "Код вида\nоперации", font10, 1, 2);
            write(g, 5, 7, 2, 2, "Структурное подразделение", font10, 1, 2);
            write(g, 7, 7, 2, 2, "Вид деятельности", font10, 1, 2);
            write(g, 9, 7, 2, 1, "Корреспондирющий\nсчёт", font10, 1, 1);
            write(g, 9, 8, "Счёт,\nсубсчёт", font10, 1, 1);
            write(g, 10, 8, "Код,\nаналитического\nучёта", font10, 1, 1);
            write(g, 9, 7, 2, 2, "", font10, 1, 2);
            write(g, 11, 7, 2,2, "Табельный номер,\nполучателя", font10, 1, 2);

            write(g, 3, 9, "___", font10, 1, 2);
            write(g, 4, 9, "", font10, 1, 2);
            write(g, 5, 9, 2, 1, "___", font10, 1, 2);
            write(g, 7, 9, 2, 1, "", font10, 1, 2);
            write(g, 9, 9, "", font10, 1, 2);
            write(g, 10, 9, "", font10, 1, 2);
            write(g, 11, 9, 2, 1, "", font10, 1, 2);

            write(g, 0, 11, "Фамилия, И., О.", font10, 0, 0);
            write(g, 1, 11, 5, 1, user.nameText, font10, 0, 0);
            write(g, 0, 12, "Профессия", font10, 0, 0);
            write(g, 0, 13, "Должность", font10, 0, 0);
            write(g, 1, 13, 5, 1, user.postText, font10, 0, 0);

            /*if (listUsers.SelectedIndices.Count == 1)
                foreach (Equipment eq in equipments)
                    foreach (ListViewItem item in listUsers.SelectedItems)
                        if (((User)item.Tag).ID == eq.user)
                            listUsEquipment.Items.Add(eq.ToListView());*/
            if (itemNumber < users.Count - 1)
            {
                itemNumber++;
                e.HasMorePages = true;
            }
        }

        /// <summary>
        /// Рисование текста в сетке с размером 1*1
        /// align: 0 - выравнивание текста слева, 1 - по центру, 2 - справа
        /// border: 0 - нет, 1 - тонкая рамка, 2 - толстая рамка
        /// </summary>
        /// <param name="g"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="border"></param>
        static void write(Graphics g, int x, int y, string text, Font font, int align, int border)
        {
            write(g, x, y, 1, 1, text, font, align, border);
        }

        /// <summary>
        /// Рисование текста в сетке
        /// align: 0 - выравнивание текста слева, 1 - по центру, 2 - справа
        /// border: 0 - нет, 1 - тонкая рамка, 2 - толстая рамка
        /// </summary>
        /// <param name="g"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="text"></param>
        /// <param name="font"></param>
        /// <param name="border"></param>
        static void write(Graphics g, int x, int y, int w, int h, string text, Font font, int align, int border)
        {
            int left = leftBorder;
            for (int i = 0; i < x; i++) left += columns[i];
            int top = topBorder;
            for (int i = 0; i < y; i++) top += rows[i];
            int width = 0;
            for (int i = 0; i < w; i++) width += columns[x+i];
            int height = 0;
            for (int i = 0; i < h; i++) height += rows[y+i];
            Rectangle rect = new Rectangle(left, top, width, height);
            if (align == 0) g.DrawString(text, font, Brushes.Black, rect, inLeft);
            if (align == 1) g.DrawString(text, font, Brushes.Black, rect, inCenter);
            if (align == 2) g.DrawString(text, font, Brushes.Black, rect, inRight);
            if (border == 1) g.DrawRectangle(slim, rect);
            if (border == 2) g.DrawRectangle(bold, rect);

            //Отладочное
            //g.DrawRectangle(slim, rect);
        }
    }
}
