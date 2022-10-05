int a = 0;
int p = 0;
int m = 0;
do
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a > 0)
    {
        p=p + a;
    }
    else if (a < 0)
    {
        m = m + a;
    }
}
while (a != 0);
if (p > -m)
{
    Console.WriteLine(p);
}
else if (p < -m)
{
    Console.WriteLine(m);
}
else if (p == -m)
{ 
Console.WriteLine("Модули равны");
}