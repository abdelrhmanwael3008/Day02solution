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


        }
    }
}
