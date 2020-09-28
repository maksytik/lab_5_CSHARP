using System;

namespace ConsoleApp1
{
    class reactive : engine, type
    {
        private int thrust;
        private bool liquid;

        public reactive() : base()
        {
            thrust = 0;
            liquid = false;
        }
        public reactive(int series, int thrust, bool liquid) : base(series)
        {
            this.liquid = liquid;
            this.thrust = thrust;
        }

        public new void print()
        {
            base.print();
            Console.WriteLine("thrust: " + thrust);
            Console.WriteLine("liquid: " + liquid);
        }

        public int getThrust()
        {
            return thrust;
        }
        public void setThrust(int thrust)
        {
            this.thrust = thrust;
        }
        public bool isLiquid()
        {
            return liquid;
        }

        public void setLiquid(bool liquid)
        {
            this.liquid = liquid;
        }
    }

}