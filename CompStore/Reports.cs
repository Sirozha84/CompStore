using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace CompStore
{
    static class Reports
    {
        static Graphics g;
        static List<User> users;
        static List<Record> equipments;
        static int itemNumber;
        static int pageNumber;

        //Шрифты и карандаши
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

        public static void UserCard(bool preview, List<User> usersList, List<Record> equipmentsList)
        {
            users = usersList;
            equipments = equipmentsList;
            CompanyProperties.Load();
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
            g = e.Graphics;
            const int strList1 = 9;
            const int strList2 = 19;
            User user = users[itemNumber];
            List<Equipment> items = new List<Equipment>();
            foreach (Equipment eq in equipments)
                if (eq.user == user.ID)
                    items.Add(eq);

            
            int st = 0;
            columns = new int[] { 150, 90, 90, 80, 70, 100, 70, 70, 70, 70, 80, 50, 50 };
            if (pageNumber == 0)
            {
                rows = new int[] { 10, 15, 15, 15, 15, 15, 15, 15, 26, 41, 41, 15, 15, 15, 15, 15, 25, 27, 12, 30, 30, 30, 30, 30, 30, 30, 30, 30, 15, 15, 10, 20, 15 };

                Write(3, st++, 3, 2, "КАРТОЧКА № " + (CompanyProperties.LastUserCardNum++).ToString(), font20B);
                CompanyProperties.Save();
                Write(9, st++, 4, 1, "Типовая межотраслевая форма № МБ-2", font10);
                Write(2, st, 4, 1, "учёта малоценных и быстроизнашивающихся предметов", font10B);
                Write(9, st++, 4, 1, "Утверждена Постановлением Госкомстата России", font10);
                Write(9, st++, 4, 1, "от 30.10.1997 № 71а", font10);
                Write(0, st, "Организация", font10);
                Write(1, st, 2, 1, CompanyProperties.Companay, font10);
                write(11, st++, 2, 1, "Коды", font10, 1, 1);
                write(9, st, 2, 1, "Форма по ОКУД", font10, 2, 0);
                write(11, st, 2, 1, "0320001", font10, 1, 1);
                Border(11, st++, 2, 2, 2);
                Write(0, st, "Структурное подразделение", font10);
                Write(1, st, 2, 1, CompanyProperties.Departament, font10B);
                write(9, st, 2, 1, "по ОКПО", font10, 2, 0);
                st = 8;

                write(3, st, 1, 2, "Дата\nсоставления", font10, 1, 2);
                write(4, st, 1, 2, "Код вида\nоперации", font10, 1, 2);
                write(5, st, 2, 2, "Структурное подразделение", font10, 1, 2);
                write(7, st, 2, 2, "Вид деятельности", font10, 1, 2);
                write(9, st, 2, 1, "Корреспондирющий\nсчёт", font10, 1, 1);
                write(9, st, 2, 2, "", font10, 1, 2);
                write(11, st++, 2, 2, "Табельный номер,\nполучателя", font10, 1, 2);
                Write(9, st, "Счёт,\nсубсчёт", font10, 1, 1);
                Write(10, st++, "Код,\nаналитического\nучёта", font10, 1, 1);
                Write(3, st, DateTime.Now.ToString("dd.MM.yyyy"), font10, 1, 2);
                Border(4, st, 1, 1, 2);
                write(5, st, 2, 1, user.depText, font10, 1, 2);
                Border(7, st, 2, 1, 2);
                Border(9, st, 1, 1, 2);
                Border(10, st, 1, 1, 2);
                Border(11, st, 2, 1, 2);

                st = 12;
                Write(0, st, "Фамилия, И., О.", font10);
                Write(1, st++, 5, 1, user.nameText, font10);
                Write(0, st++, "Профессия", font10);
                Write(0, st, "Должность", font10);
                Write(1, st, 5, 1, user.postText, font10);

                st = 16;

                Border(0, 16, 3, 12, 2);
                Border(3, 16, 3, 12, 2);
                Border(6, 16, 3, 12, 2);
                Border(9, 16, 2, 12, 2);
                Border(11, 16, 1, 12, 2);
                Border(12, 16, 1, 12, 2);
            }
            else
            {
                rows = new int[] { 25, 27, 12, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 15, 15, 10, 20, 15 };
                Border(0, 0, 3, 22, 2);
                Border(3, 0, 3, 22, 2);
                Border(6, 0, 3, 22, 2);
                Border(9, 0, 2, 22, 2);
                Border(11, 0, 1, 22, 2);
                Border(12, 0, 1, 22, 2);
            }

            //Шапка основной таблицы
            write(0, st, 3, 1, "Предмет", font10, 1, 1);
            write(3, st, 3, 1, "Выдано", font10, 1, 1);
            write(6, st, 3, 1, "Возвращено", font10, 1, 1);
            write(9, st, 2, 1, "Акт выбытия", font10, 1, 1);
            write(11, st, 1, 2, "Срок\nслужбы", font10, 1, 1);
            write(12, st++, 1, 2, "Номер\nпаспорта", font10, 1, 1);
            Write(0, st, "Наименование, марка,\nразмер", font10, 1, 1);
            Write(1, st, "Номенклатур-\nный номер", font10, 1, 1);
            Write(2, st, "Заводской\nномер", font10, 1, 1);
            Write(3, st, "Дата", font10, 1, 1);
            Write(4, st, "Количество", font10, 1, 1);
            Write(5, st, "Подпись\nработника", font10, 1, 1);
            Write(6, st, "Дата", font10, 1, 1);
            Write(7, st, "Количество", font10, 1, 1);
            Write(8, st, "Подпись\nработника", font10, 1, 1);
            Write(9, st, "Номер", font10, 1, 1);
            Write(10, st++, "Дата", font10, 1, 1);
            for (int i = 0; i < 13; i++)
                Write(i, st, (i + 1).ToString(), font10, 1, 1);

            //Определяем следующий номер строки
            int strNum = 0;
            for (int i = 0; i < pageNumber; i++)
            {
                if (pageNumber == 1) strNum += strList1;
                if (pageNumber > 1) strNum += strList2;
            }

            //Строки основной таблицы
            st++;
            int maxS = pageNumber == 0 ? strList1 : strList2;
            for (int i = 0; i < maxS; i++)
            {
                for (int j = 0; j < 13; j++)
                    Border(j, st + i, 1, 1, 1);
                if (strNum < items.Count)
                {
                    Write(0, st + i, items[strNum].nameText, font10);
                    Write(1, st + i, items[strNum].iN, font10, 1, 0);
                    Write(2, st + i, items[strNum].sn, font10, 1, 0);
                    Write(3, st + i, items[strNum].buyDate.ToString("dd.MM.yyyy"), font10, 1, 0);
                    Write(4, st + i, "1", font10, 1, 0);
                    strNum++;
                }
            }

            if (strNum < items.Count)
            {
                pageNumber++;
                e.HasMorePages = true;
            }
            else
            {
                st += 1 + (pageNumber == 0 ? strList1 : strList2);
                Write(0, st, "Карточку заполнил", font10);
                write(1, st, 2, 1, "___________________", font10, 1, 0);
                write(4, st++, 2, 1, "___________________", font10, 1, 0);
                write(1, st, 2, 1, "(должность)", font10, 1, 0);
                Write(3, st, "(подпись)", font10, 1, 0);
                write(4, st, 2, 1, "(расшифровка подписи)", font10, 1, 0);
                st += 2;
                write(1, st, 3, 0, "\" _____ \" _______________ " + DateTime.Now.ToString("yyyy") + "г.", font10, 1, 0);

                if (itemNumber < users.Count - 1)
                {
                    itemNumber++;
                    e.HasMorePages = true;
                }
                pageNumber = 0;
            }
        }

        static void Border(int x, int y, int w, int h, int border)
        {
            write(x, y, w, h, "", font10, 0, border);
        }

        static void Write(int x, int y, string text, Font font)
        {
            write(x, y, 1, 1, text, font, 0, 0);
        }
        static void Write(int x, int y, int w, int h, string text, Font font)
        {
            write(x, y, w, h, text, font, 0, 0);
        }

        static void Write(int x, int y, string text, Font font, int align, int border)
        {
            write(x, y, 1, 1, text, font, align, border);
        }

        // align: 0 - выравнивание текста слева, 1 - по центру, 2 - справа
        // border: 0 - нет, 1 - тонкая рамка, 2 - толстая рамка
        static void write(int x, int y, int w, int h, string text, Font font, int align, int border)
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
