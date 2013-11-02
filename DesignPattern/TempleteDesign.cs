using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class CoffeeinBeverage
    {
        public void BoiltWater()
        {
            Console.WriteLine("Boiting water....");
        }

        public void PrepareRecipe()
        {
            BoiltWater();
            Brew();
            PourInCup();
            if( WantCondiments())
            {
                AddCondiments();

            }
            
        }

        public virtual bool WantCondiments()
        {
            return true;
        }

        public abstract void AddCondiments();

        private void PourInCup()
        {
            Console.WriteLine("Pouring water into cup....");
        }

        public abstract void Brew();
    }

    public class Tea:CoffeeinBeverage
    {


        public override void AddCondiments()
        {
            Console.WriteLine("add salt");
        }

        public override void Brew()
        {
            Console.WriteLine("add tea");
        }

        public override bool WantCondiments()
        {
            return false;
        }
    }

    public class NoSaltTea : CoffeeinBeverage
    {


        public override void AddCondiments()
        {
            Console.WriteLine("add salt");
        }

        public override void Brew()
        {
            Console.WriteLine("add tea");
        }

        public override bool WantCondiments()
        {
            return true;
        }
    }
    
}
