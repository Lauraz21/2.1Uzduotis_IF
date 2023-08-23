Console.WriteLine("Iveskite temperatura: ");
int temp = Convert.ToInt32(Console.ReadLine());
if (temp < 0)
{
    Console.WriteLine("Salta");
}
else if (temp >=0 && temp <=20)
{
   Console.WriteLine("Vesu");
}
else if (temp > 20)
{
    Console.WriteLine("Karsta");
}