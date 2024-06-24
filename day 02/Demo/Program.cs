using System.Runtime.CompilerServices;

namespace Demo
{
    class Program
    {
        //Entry Point (Start Point)
        static void Main()
        {
            #region ValueType
            //int X;

            //CLR Will Allocate 4 UnIntialized Bytes At Stack
            // int : C# KeyWord

            //X = 5;

            //Int32 Y = 10;

            //CLR Will Allocate 4 UnIntialized Bytes At Stack = 10
            // Int32: BCL

            //Y = X; //5

            //X++;  //6 

            //Console.WriteLine(Y);
            #endregion

            #region Reference Type

            //Point p1 ;

            ///// Declare For Reference Of Type "Point" , Refering to NULL
            ///// This Reference 'p1' Can Refer to an Object From type "point" OR another type "Inherting
            ///// CLR Will Allocate 4 Bytes For the Reference AT STACK
            ///// CLR WILL Allocate 0 Bytes AT HEAP

            //p1 = new Point(); //has 2 References [p1,p2]( اسمين دلع );

            /////1.Allocate Required Number Of Bytes In Heab (Object size + CLR Overhead Variables)
            ///// 2.Initialize (Cross out ) Allocted Bytes With Default Value Of Tts Datatype
            ///// 3.Call user-Defined Constructor if exists
            ///// 4.Assingn The Reference to a allocated Object

            //Console.WriteLine(p1.x); //0 
            //Console.WriteLine(p1.y); //0

            //Point p2 = new Point(); //Unreachable Object

            //p2=p1 ;

            //p2.x = 10;

            //Console.WriteLine(p1.x);


            #endregion

            #region Object 01



            //Point p1 = new Point(); // X = 0 , Y = 0
            //Point P2 = new Point(); // X = 0 , Y = 0

            //////Console.WriteLine(p1.ToString()); //Day-02-G02-.point

            ////Console.WriteLine(p1.GetHashCode());
            ////Console.WriteLine(P2.GetHashCode());


            ////Console.WriteLine(p1.Equals(P2));  // fulse

            //object 01;

            ////Console.WriteLine(p1.GetType().Name);  //Namespace.Datatype [Day-02-G02.Point] 
            //#endregion

            //01 = new object();
            ////new

            ////Declare For Reference of type "Object" , Refering to NULL

            //// 4 Bytes Have been Allocated at stack for the reference '01'

            ////0 Bytes Have been Allocated at heap 

            //// this reference '01' can refer to an instance of type " Object" Or of another type "inheriting from Object"

            //01 = new string ("Ahmed");

            //01 = "Ahmed"; //syntax sugar

            //01 = 5; //boxing 
            //01 = 3.3;
            //01 = 'A'
            //01 = true;
            //01 = new DateTime();
            //01 = new DateOnly();
            //01 = new TimeOnly();


            #endregion

            #region Object 02
            // parent = child

            //  object 01 = new Point();

            //  01 = new string("Ahmed");

            // 01 = new Point();

            // string X = (string)01;

            //parent = child 
            // animal = dog 
            // animal = cat 
            // animal = fox 

            // fox = (fox ) animal

            #endregion

            #region fractions
            //float X = 5.3F;
            //double Y = 4.34;
            //decimal z = 9943.4m;


            ///// Discard => just for reabability

            //long Number = 100_000_000_000;
            //Console.WriteLine(Number);

            #endregion

            #region Implicit casting vs Explicit casting 

            /// int x = 8 ;
            /// long y =/*(long)*/ x; // 1.iplcicit casting [safe casting]
            ///Console.WriteLine(y); //8
            ///

            ///  long x = 8;
            ///  x = 435456576567;
            ///  int y = (int)x; //2.explicit casting [unsafe casting]
            ///  Console.WriteLine(y);


            ///  checked
            /// {
            ///     int y = (int)x; //2.explicit casting [unsafe casting]
            /// }
            /// unchecked
            /// {
            ///  Console.WriteLine(y);
            ///}


            //int x = 5;
            //double y =/*(double)*/x;  //1.implicit casting [safe casting]
            //Console.WriteLine(y);


            //double x = 5.5;
            //int y = (int)x; // 2. explcit casting [unsafe casting]

            #endregion

            #region parse and convert
            #region convert

            //** convert is a class containting set of used of methods used for casting from datatype to anouther**/

            //Console.Write("please enter your name: ");
            //string name = Console.ReadLine()?? "na";


            //Console.Write("please enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("please enter your salary: ");
            //decimal salary =Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.Beep(324, 1000);

            //Console.WriteLine("enter name is" + name);
            //Console.WriteLine("your age is " +age);
            //Console.WriteLine("your salary is "+ salary);

            #endregion

            #region parse 

            //parse : is a method used for casting from string to the caller datatype 

            //Console.Write("please enter your name: ");
            //string name = Console.ReadLine()?? "na";


            //Console.Write("please enter your age: ");
            //int age = int.Parse(Console.ReadLine()?? "0");

            //Console.Write("please enter your salary: ");
            //decimal salary =decimal.Parse(Console.ReadLine()?? "0");

            //Console.Clear();
            //Console.Beep(324, 1000);

            //Console.WriteLine("enter name is" + name);
            //Console.WriteLine("your age is " +age);
            //Console.WriteLine("your salary is "+ salary);
            #endregion


            //string x = "5";
            //x = "ahmed";
            //int y=int.Parse(x);
            //Console.WriteLine(y);

            //string X = "true";
            //X = "hamda";
            //bool flag =Convert.ToBoolean(X);
            //Console.WriteLine(flag); //true



            #endregion

            #region try parse

            //string x = "Ahmed";

            //    int y;
            //bool flag =int.TryParse(x, out y); //if casting failed no exception will be thrown


            //Console.WriteLine(flag); //fulse
            //Console.WriteLine(y); //0
            #endregion

            #region unary opreators

            ///unary operators => works on one operand (variable)
            ///int x = 10;
            ///
            ///1. ++ 

            ///1.1 prefix [increment and then print ]
            ///Console.WriteLine(x++); // print 10
            ///1.2 postfix [print and then increment]
            ///Console.WriteLine(x++); //print 10 
            ///
            ///.2 
            ///
            ////2.1 perfix [decrement and then print ]
            ///Console.WriteLine(--x); // print 9
            ///2.2 postfix [print and then decrement]
            ///Console.WriteLine(x--);//print 10

            #endregion

            #region assigment operator

            //int x;
            //x = 4;
            //x += 2; // x = x + 2
            //x -= 2; // x = x - 2
            //x *= 2; // x = x * 2
            //x /= 2; // x = x / 2
            //x %= 2; // x = x % 2
            #endregion

            #region logical operators
            //int x = 6, y = 5;

            //Console.WriteLine(x == y); //equal
            //Console.WriteLine(x != y); // not equal
            //Console.WriteLine(x > y); //more than
            //Console.WriteLine(x >= y); //more than or equal
            //Console.WriteLine(x < y); //less than
            //Console.WriteLine(x <= y); //less than or equal

            #endregion

            #region bitwise operators 

            //Console.WriteLine(!false);

            //Console.WriteLine(false && true);//short circuit

            //Console.WriteLine(true || false);

            //Console.WriteLine(4 < 5 && 7 < 9);
            #endregion

            #region teranry operator 

            //int x = 10, y = 5;
            //string message;
            //if (x > y)
            //{
            //    message = "x is more than y ";
            //}
            //else if (x < y)
            //{
            //    message = "x is less than y ";
            //}
            #endregion



            #region operators prioty [precednce] and asscoitivaity

            /*
             * 1. unary operators (prefix)
             * 2. round baraces()
             * 3. * / %
             * 4. + - 
             */
            //  int Equation = 4 + 3 * 8;
            //   Console.WriteLine(Equation); // 28


            //int a = 20;
            //int b = 10;
            //int c = 15;
            //int d = 5;
            //int equation;


            //equation = (a + b) * c / d; // (30 * 15 )/5

            //equation = ((a + b) * c) / d; //(30 * 15)/5


            //equation = (a + b) * (c / d); //(30*15) /5 

            //equation = a + (b + c / d); //20 + 150/5 
            #endregion



        }
    }
}
