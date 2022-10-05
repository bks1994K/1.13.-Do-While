int number = 0;
int s = 0;
do
{
    number = Convert.ToInt32(Console.ReadLine());
    if ((number % 3 == 0 || number % 7 == 0 || number % 11 == 0) && number != 0)
    {
        s = s + 1;
    }
}
while (number != 0);
Console.WriteLine(s);