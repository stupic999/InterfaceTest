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
        public string Type { get { return "knight"; } }
        public int Atk { get { return 2; } }
        public int Def { get { return 5; } }
        int hp=10;
        public int Hp { get { return hp; } set { hp = value; } }
        public int isDamaged(int selfHp, int EmyAtk, int selfDef)
        {
            int damage = EmyAtk - selfDef;
            if (damage <= 0)
            {
                damage = 1;
            }
            selfHp -= damage;
            if (selfHp <= 0)
            {
                selfHp = 0;
                Console.Write("Died");
            }
            return selfHp;
        }
    }

    class CMagician : IType
    {
        public string Type { get { return "magician"; } }
        public int Atk { get { return 7; } }
        public int Def { get { return 1; } }
        int hp = 6;
        public int Hp { get { return hp; } set { hp = value; } }
        public int isDamaged(int selfHp, int EmyAtk, int selfDef)
        {
            int damage = EmyAtk - selfDef;
            if (damage <= 0)
            {
                damage = 1;
            }
            selfHp -= damage;
            if (selfHp <= 0)
            {
                selfHp = 0;
                Console.Write("Died");
            }
            return selfHp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CKnight knight = new CKnight();
            CMagician magician = new CMagician();

            Console.WriteLine("法师先攻,骑士目前血量：" + knight.Hp);
            knight.Hp=knight.isDamaged(knight.Hp, magician.Atk, knight.Def);
            Console.WriteLine("骑士目前血量：" + knight.Hp);
            Console.ReadKey();
        }
    }
}
