double Pow(int a,int b)
{
    double power = 1;
    for (int i = 1; i <= Math.Abs(b); i++)
    power *= a;
    if (b > 0)
        return power;
    else
        return 1/power;
}

int a = 3,b = 5;
Console.WriteLine(b + "^" + a + " = " + Pow(a,b));

a = 2; b = 4;
Console.WriteLine(b + "^" + a + " = " + Pow(a,b));