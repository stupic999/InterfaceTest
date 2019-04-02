using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    interface IType
    {
        string Type {  get; }
        int Atk { get;  }
        int Def { get;  }
        int Hp { get;  }
        int isDamaged(int hp,int atk, int def);    
    }

    class CKnight:IType
    {
        string type="knight";
        public string Type { get; }
        int atk = 2;
        public int Atk { get; }
        int def = 10;
        public int Def { get; }
        int hp = 100;
        public int Hp { get; }
        public int isDamaged(int hp,int atk,int def)
        {
            int damage = atk - def ;
            if (damage <= 0)
                damage = 1;
            hp -= damage;
            if (hp <= 0)
            {
                hp = 0;
                Console.Write("Died");
            }
            return hp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
