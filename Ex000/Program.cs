Console.Write("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int y = 0;
while(y <8)
{
     array[y] = new Random().Next(0, 2);
     Console.WriteLine(array[y]); 
     y++;
}
