using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Lab_5
{
    class PrinterWindows
    {
        public string Name { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("  ");
        }
        public virtual void Print()
        {
            Console.WriteLine(" ");
        }
    }
}