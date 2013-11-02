using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class OneAdapter
    {
    }

    public class Mobile
    {
        public void Charge(ITwoHole twoHole)
        {
            twoHole.Connect();
            AddPower();

            
        }

        private void AddPower()
        {
            Console.WriteLine("Power is increaing。。。。。");
        }
    }

    public class ThreeHole
    {
        public void Connect()
        {
            LeftConnect();
            RightConnect();
            ExtraConnect();
        }

        public void ExtraConnect()
        {
            Console.WriteLine("Zero line is connecting .....");
        }

        public void RightConnect()
        {
            Console.WriteLine("fire line is connectiong....");
        }

        public void LeftConnect()
        {
            Console.WriteLine("grond line is connectiong....");
        }
    }
    public class LineWithTwoHole:ITwoHole
    {
        private ThreeHole threeHole;
        public LineWithTwoHole(ThreeHole threehole)
        {
            this.threeHole = threehole;
        }

        public void Connect()
        {
            threeHole.LeftConnect();
            threeHole.RightConnect();
        }
    }

    public interface ITwoHole
    {
        void Connect();
    }
}
