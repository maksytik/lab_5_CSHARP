using System;

namespace ConsoleApp1
{
    class dvs : engine
    {
        private int numBlocks;


        public dvs() : base()
        {
            numBlocks = 1;
        }

        public dvs(int series, int numBlocks) : base(series)
        {
            this.numBlocks = numBlocks;
        }

        public new void print()
        {
            base.print();
            Console.WriteLine("num of blocks: " + numBlocks);
        }


        public int getNumBlocks()
        {
            return numBlocks;
        }

        public void setNumBlocks(int numBlocks)
        {
            this.numBlocks = numBlocks;
        }
    }

}