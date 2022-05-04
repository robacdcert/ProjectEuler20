//Project Euler 20
//n! means n × (n − 1) × ... × 3 × 2 × 1
//For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
//and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
//Find the sum of the digits in the number 100!

using System.Numerics;

Console.Write("Enter an intger: ");
string input = Console.ReadLine();
long integer = Convert.ToInt32(input);
BigInteger factor = 1;

while (integer > 0)
{
    factor = factor * integer;
    integer--;
}

string factorString = factor.ToString();
int digits = factorString.Length;
string x;
int y;
int sum = 0;

for (int i = 0; i < digits; i++)
{
    x = factorString.Substring(i,1);
    y = Convert.ToInt32(x);
    sum = sum + y;
}

Console.WriteLine("Factor: " + factor);
Console.WriteLine("Sum: " + sum);