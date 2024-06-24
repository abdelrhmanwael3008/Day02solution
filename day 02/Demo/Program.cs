namespace Demo
{
    class Program
    {
        //Entry Point (Start Point)
        static void Main()
        {
            int X;

            // CLR Will Allocate 4 UnIntialized Bytes At Stack
            // int : C# KeyWord

            X = 5;

            Int32 Y = 10;

            // CLR Will Allocate 4 UnIntialized Bytes At Stack = 10
            // Int32 :BCL

            Y = X; //5

            X++;  //6 

            Console.WriteLine(Y);
        }
    }
}
