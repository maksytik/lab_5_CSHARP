using System;

namespace ConsoleApp1
{
    class engine : mainInfo
    {
        private int series;



        public engine()
        {
            series = 0;
        }
        public engine(int series)
        {
            this.series = series;
        }
        public void print()
        {
            Console.WriteLine("series:" + series);
        }


        public void setSeries(int series)
        {
            this.series = series;
        }
    }

}