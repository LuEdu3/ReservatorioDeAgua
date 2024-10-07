bool boiaA = true;
bool boiaB = true;
bool boiaC = true;
bool eletroValvS1 = true;
bool eletroValvS2 = true;
bool erro = true;

Console.WriteLine("Estados das boias:");
if (boiaA == false && boiaB == false && boiaC == false && eletroValvS1 == false && eletroValvS2 == true && erro == false)
{
    Console.WriteLine("0");
}
if (boiaA == false && boiaB == false && boiaC == true && eletroValvS1 == false && eletroValvS2 == true && erro == false)
{
    Console.WriteLine("1");
}
if (boiaA == false && boiaB == true && boiaC == false && eletroValvS1 == false && eletroValvS2 == true && erro == true)
{
    Console.WriteLine("2");
}
if (boiaA == true && boiaB == false && boiaC == false && eletroValvS1 == false && eletroValvS2 == true && erro == true)
{
    Console.WriteLine("3");
}
if (boiaA == true && boiaB == false && boiaC == true && eletroValvS1 == true && eletroValvS2 == true && erro == false)
{
    Console.WriteLine("4");
}
if (boiaA == true && boiaB == true && boiaC == false && eletroValvS1 == true && eletroValvS2 == true && erro == false)
{
    Console.WriteLine("5");
}
if (boiaA == true && boiaB == true && boiaC == false && eletroValvS1 == true && eletroValvS2 == false && erro == false)
{
    Console.WriteLine("6");
}
if (boiaA == true && boiaB == true && boiaC == false && eletroValvS1 == false && eletroValvS2 == true && erro == false)
{
    Console.WriteLine("7");
}
else
{
    Console.WriteLine("8");
}
