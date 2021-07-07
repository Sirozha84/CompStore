using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompStore
{
    public class Move
    {
        public int ID;
        public int equipment;
        public int filial;
        public int building;
        public int room;
        public int dep;
        public int user;
        public DateTime date = DateTime.Now;
        public string comment;

        public string eqText;
        public string userText;
        public string roomText;

    }
}
