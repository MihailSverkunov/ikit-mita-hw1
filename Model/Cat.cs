using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private int age;
        public Cat(int a)
        {
            age = a;
        }


        public string Name;
        

        private int health;

        public void Feed()
        {
            if (health + 1 < 10) health++;
        }

        public void Punish()
        {
            if (health - 1 > 0) health--;
        }

        public string Color
        {
            get
            {
                if (health < 3) return "Красный";
                if (health > 2 && health < 6) return "Желтый";
                else return "Зелёный";
            }
        }
    }
}
