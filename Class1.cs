using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L3
{

    struct Article
    {
        public int id;
        public string title;
        public int price;
        public ArticleType Type;
        public Article(int id, string title, int price, ArticleType type) 
        {
            this.id = id;
            this.title = title;
            this.price = price;
            this.Type = type;
        }
    }
    public enum ArticleType 
    { 
        Type1,
        Type2, 
        Type3
    }

    struct Client
    {
        public int id;
        public string FIO;
        public string adres;
        public int PhoneNumb;
        public int OrderNum;
        public int OrderSum;

        public ClientType Type;

        public Client(int  id, string FIO, string adres, int PhoneNumb, int OrderNum, int OrderSum, ClientType type) 
        { 
            this.id = id;
            this.FIO = FIO;
            this.adres = adres;
            this.PhoneNumb = PhoneNumb;
            this.OrderNum = OrderNum;
            this.OrderSum = OrderSum;
            this.Type = type;
        }
    }
    public enum ClientType
    {
        VIP_Extra,
        VIP,
        basic,
        UnStat

    }



    public partial class Class
    {
        private int _num;
        public int Num { get { return _num; } set { _num = value; } }
        public string Asd2 { get; set; }

        public void Der(int num = 12, params int[] cow) 
        {
            Article article1 = new Article(1,"Товар 1", 100, ArticleType.Type1);
        }
        public void ClientS()
        {
            Client client1 = new Client(10, "QWERTY", "Adres",8111, 12, 48, ClientType.VIP_Extra);
        }
    }
}
