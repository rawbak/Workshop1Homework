//Программа, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число - ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
do
{
  if (i%2==0)
  {
    Console.Write(i + ", ");
  }
  i++;
}
while (i<N);
