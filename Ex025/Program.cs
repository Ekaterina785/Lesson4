Console.Write("Введите число: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int s=1;
int i =0;
while(i<b)
{
    s=s*a;
    i++;
}
Console.WriteLine(s);

