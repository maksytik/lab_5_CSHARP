using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface mainInfo
    {
        void print();
    }

    interface type
    {
        bool isLiquid();
        void setLiquid(bool yes);
    }
    class Program
    {
        delegate void dela();
        static void Main(string[] args)
        {

            engine mk1 = new engine(1251);
            dvs mk2 = new dvs(45632, 2);
            disel mk3 = new disel(967533, 3, 49);
            reactive mk1_1 = new reactive();


            dela newline = Console.WriteLine;
            dela a1 = mk1.print;
            dela a2 = mk2.print;
            dela a3 = mk3.print;
            dela a4 = mk1_1.print;
            dela result = a1 + newline + a2 + newline + a3 + newline + a4;
            result();

            Console.ReadKey();
        }

    }

}