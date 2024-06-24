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


        }
    }
}
