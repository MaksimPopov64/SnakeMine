using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,2,'$');          
              

            Point p2 = new Point(2,3,'%');
           
            

            HorizontalLine line = new HorizontalLine(0,78,0,'+');
            HorizontalLine line1 = new HorizontalLine(0, 78, 24, '+');        

            VerticalLine line2 = new VerticalLine(0, 24, 0, '+');
            VerticalLine line3= new VerticalLine(0, 24, 78, '+');


            line.Drow();
            line1.Drow();
            line2.Drow();
            line3.Drow();

            Point p = new Point(3, 4, '+');

            Snake Snake = new Snake(p, 4, Direction.RIGHT);
            Snake.Drow();

            Console.ReadLine();

        }
       
        }
    }

