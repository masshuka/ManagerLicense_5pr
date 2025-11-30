using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Classes
{
    public class Client
    {
        public string Token { get; set; }
        public string Login { get; set; }
        public DateTime DateConnect { get; set; }
        public Client()
        {
            Random random = new Random();
            string Chars = "ASDFGHTYasdfghty123";
            this.Token = new string(Enumerable.Repeat(Chars, 15).Select(x => x[random.Next(Chars.Length)]).ToArray());
            DateConnect = DateTime.Now;
        }
    }
}
