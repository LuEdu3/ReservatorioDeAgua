Console.Clear();

bool boiaaA =true;
int boiaA;
bool boiaaB = true;
int boiaB;
bool boiaaC = true;
int boiaC;
// bool eletroValvS1 = true;
// bool eletroValvS2 = true;
// bool erro = true;

Console.WriteLine("Insira o Estado das boia A:");
if(int.TryParse(Console.ReadLine(),out boiaA))
{
    if(boiaA == 0)
    {
        boiaaA =false;
        Console.WriteLine("Bomba desligada");
    }
    else if(boiaA ==1)
    {
        Console.WriteLine("Nível A do Reservátorio alcançado, ligando bomba.");
    }
}
Console.WriteLine("Insira o Estado das boia B:");
if(int.TryParse(Console.ReadLine(),out boiaB))
{
    if(boiaB == 0)
    {
        boiaaB =false;
        Console.WriteLine("adssdas");
    }
    else if(boiaB ==1 && boiaA ==1)
    {
        Console.WriteLine("Valvula S2 desligada");
    }
}
Console.WriteLine("Insira o Estado das boia C:");
if(int.TryParse(Console.ReadLine(),out boiaC))
{
    if(boiaC == 0)
    {
        boiaaA =false;
        Console.WriteLine("Caixa d'agua 2 precisando de agua");
    }
    else if(boiaC ==1)
    {
        Console.WriteLine("Bomba C Ligada");
    }
}


// Console.WriteLine("Estados das boias:");
// if (boiaA == false && boiaB == false && boiaC == false && eletroValvS1 == false && eletroValvS2 == true && erro == false)
// {
//     Console.WriteLine("0");
// }
// if (boiaA == false && boiaB == false && boiaC == true && eletroValvS1 == false && eletroValvS2 == true && erro == false)
// {
//     Console.WriteLine("1");
// }
// if (boiaA == false && boiaB == true && boiaC == false && eletroValvS1 == false && eletroValvS2 == true && erro == true)
// {
//     Console.WriteLine("2");
// }
// if (boiaA == true && boiaB == false && boiaC == false && eletroValvS1 == false && eletroValvS2 == true && erro == true)
// {
//     Console.WriteLine("3");
// }
// if (boiaA == true && boiaB == false && boiaC == true && eletroValvS1 == true && eletroValvS2 == true && erro == false)
// {
//     Console.WriteLine("4");
// }
// if (boiaA == true && boiaB == true && boiaC == false && eletroValvS1 == true && eletroValvS2 == true && erro == false)
// {
//     Console.WriteLine("5");
// }
// if (boiaA == true && boiaB == true && boiaC == false && eletroValvS1 == true && eletroValvS2 == false && erro == false)
// {
//     Console.WriteLine("6");
// }
// if (boiaA == true && boiaB == true && boiaC == false && eletroValvS1 == false && eletroValvS2 == true && erro == false)
// {
//     Console.WriteLine("7");
// }
// else
// {
//     Console.WriteLine("8");
// }
