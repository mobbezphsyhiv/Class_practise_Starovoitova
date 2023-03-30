using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Pattern
{
    class Program
    {

        class Fifo
        {

            string[] data;
            public void add(string s)
            {
                ///
            }

            public string get()
            {
                return "";
            }

        }


        abstract class Stationery
        {


        }

        abstract class ToolstoDraw : Stationery
        {
            protected string color;
            protected int thickness;
            protected int price;

            public abstract void draw();

            protected void doSomething()
            {
                Console.WriteLine("doSomething");
            }

        }

        class Pencil : ToolstoDraw
        {
            private bool isHaveEraser;

            public override void draw()
            {
                Console.WriteLine("Pencil is drawing");
            }

        }

        class Pen : ToolstoDraw
        {
            private int pasta = 100;
            private int ink_type;
            private bool isAuto;

            static private int globalCount = 0;

            static public void Something()
            {
                Console.WriteLine("There are " + globalCount + " pens");
            }

            public override void draw()
            {
                base.doSomething();
                //base.doDo();
                if (pasta > 0)
                {
                    Console.WriteLine("Pen is drawing");
                    pasta = pasta - 1;
                }
                else
                {

                }
            }

            public int getPasta()
            {
                return pasta;
            }

            public Pen(int pasta, int ink_type, bool isAuto,
                string color, int thickness, int price)
            {
                this.color = color;
                this.thickness = thickness;
                this.price = price;
                this.pasta = pasta;
                this.ink_type = ink_type;
                this.isAuto = isAuto;
                globalCount++;
            }

            public Pen(int pasta, int ink_type, bool isAuto)
            {
                this.pasta = pasta;
                this.ink_type = ink_type;
                this.isAuto = isAuto;
                globalCount++;
            }

            public Pen()
            {
                globalCount++;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Pen p1 = new Pen(100, 2, true);
            Pen p2 = new Pen(100, 1, false);
            Pen p3 = new Pen(100, 1, false, "red", 3, 100);
            Pencil pencil = new Pencil();

            Pen p4 = new Pen();
            p4.draw();

            //Pen.Something();

            //Console.WriteLine(p4.getPasta());
            //p4.draw();
            //p4.draw();
            //p4.draw();
            //p4.draw();
            //Console.WriteLine(p4.getPasta());
            //



            //ToolstoDraw[] arrOfTools = new ToolstoDraw[2];
            //arrOfTools[0] = p1;
            //arrOfTools[1] = pencil;

            //foreach (ToolstoDraw element in arrOfTools) {
            //    element.draw();

            //}


        }
    }
}
