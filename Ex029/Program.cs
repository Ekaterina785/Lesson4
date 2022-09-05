int[] array = new int[8];
int y = 0;
while(y <8)
{
     array[y] = new Random().Next(1, 101);
     Console.WriteLine(array[y]); 
     y++;
}
