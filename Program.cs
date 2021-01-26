using System;

namespace Lab1_2
{
    class TTriangle
    {
        protected int a;
        protected int b;
        protected int c;
        
        public void Print()
        {
            Console.WriteLine("a={0}  b={1}  c={2}", a, b, c);
        }
       
        public void Sides()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a + b > c || b + c > a || a + c > b)
            {
                Console.WriteLine("трикутник існує");
            }
            else
            {
                Console.WriteLine("трикутника не існує");
            }
        }
        public int SideA
        {
            get
            {
                return a;
            }
        }
        public int SideB
        {
            get
            {
                return b;
            }
        }
        public int SideC
        {
            get
            {
                return c;
            }
        }
        public bool ChSideA
        {
            set
            {
               int tempa = int.Parse(Console.ReadLine());
                if (tempa + b > c || b + c > tempa || tempa + c > b)
                {
                    Console.WriteLine("трикутник існує");
                    a = tempa;
                }
                else
                {
                    Console.WriteLine("трикутника не існує");
                }
            }
        }
        public bool ChSideB
        {
            set
            {
                int tempb = int.Parse(Console.ReadLine());
                if (a + tempb > c || tempb + c > a || a + c > tempb)
                {
                    Console.WriteLine("трикутник існує");
                    b=tempb;
                }
                else
                {
                    Console.WriteLine("трикутника не існує");
                }
            }
        }
        public bool ChSideC
        {
            set
            {
                int tempc = int.Parse(Console.ReadLine());
                if (a + b > tempc || b + tempc > a || a + tempc > b)
                {
                    Console.WriteLine("трикутник існує");
                    c=tempc;
                }
                else
                {
                    Console.WriteLine("трикутника не існує");
                }
            }
        }
        public int Per()
        {
            int per = a + b + c;
            return per;
        }
        public double PL()
        {
            double per2 = Per() / 2.0;
            double pl = Math.Sqrt(per2*(per2 - a)*(per2-b)*(per2-c));
            return pl;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввеідть сторони трикутника");
            TTriangle tr = new TTriangle();
            tr.Sides();
            tr.Print();
            Console.WriteLine("{0}  {1}",tr.Per(),tr.PL());
        }
    }
}
