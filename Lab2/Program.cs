using System;
using IIG.BinaryFlag;

class Program
{
    static void Main(string[] args)
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        bool? exp = flag.GetFlag();

        Console.WriteLine(exp);

        flag.ResetFlag(0);
        flag.ResetFlag(1);

        bool? act = flag.GetFlag();

        Console.WriteLine(act);
    }
}
