Console.WriteLine("Iveskite temperatura: ");
float temp = Convert.ToSingle(Console.ReadLine());
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