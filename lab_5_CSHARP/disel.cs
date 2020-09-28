using System;

namespace ConsoleApp1
{
    class disel : dvs
    {
        private int cetan;

        public disel() : base()
        {
            cetan = 50;
        }

        public disel(int series, int numBlocks, int cetan) : base(series, numBlocks)
        {
            this.cetan = cetan;
        }


        public new void print()
        {
            base.print();
            Console.WriteLine("cetan: " + cetan);
        }

        public int getCetan()
        {
            return cetan;
        }
        public void setCetan(int cetan)
        {
            this.cetan = cetan;
        }
    }

}