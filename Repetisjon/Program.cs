// See https://aka.ms/new-console-template for more information
using Repetisjon.BilEksempel;



Console.WriteLine(A.a);
Console.WriteLine(B.b);

//BilProgram bilProgram = new BilProgram();
//bilProgram.KjørProgram();


class A
{
    public static readonly int a = B.b + 1;
    // ...
}
class B
{
    public static readonly int b = A.a + 1;
    // ...
}
