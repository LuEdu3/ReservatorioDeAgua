bool boiaA =true;
bool boiaB =true;
bool boiaC =true;

Console.WriteLine("Estados das boias:");
if(boiaA == false && boiaB ==false && boiaC ==false)
{
    Console.WriteLine("Reservatorios todos vazios, ligar eletroválvula S2 ");
}
if(boiaA ==true && boiaB == false && boiaC == false)
{
    Console.WriteLine("Bomba ligada para a caixa de água");
}
if(boiaA ==true && boiaB == false && boiaC ==true)
{
    Console.WriteLine("Caixa Cheia, enchendo reservatório até boia B");
}
// if(boiaA ==true && boiaB ==true && boiaC ==true)
// {
//     Console.WriteLine("Todas os reservatórios cheios. Parar eletroválvula S2");
// }