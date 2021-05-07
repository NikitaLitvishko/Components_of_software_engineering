using System;
using IIG.BinaryFlag;

class Program
{
    static void Main(string[] args)
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(1, true);
        Console.WriteLine(flag.GetFlag());
    }
}
