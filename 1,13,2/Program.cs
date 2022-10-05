int number = 0;
int max=0;
do
{
    number = Convert.ToInt32(Console.ReadLine());
    if (number > max)
    {
        max = number;
    }
    }
while (number != 0 );
    Console.WriteLine(max);
