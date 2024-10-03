// Atividade:

// Refaça o programa de controle de nível de água mostrado na figura a seguir e use
// a plataforma GitHub para produção deste programa.
// Lembrar que :

// 1 – A bomba de agua não pode funcionar com o reservatório vazio
// 2 – A bomba devera ligar na quando o nível de agua reservatório estiver abaixo da
// boia c
// 3 – A eletroválvula S2 irá permitir entrada de água enquanto a boia b não for
// acionada
// 4 – O sistema deverá exibir um sinal de erro quando houver inconsistência no sistema
// da monitoramento do reservatório 1 evitando que a bomba e a eletroválvula acione

using System.ComponentModel;
Console.WriteLine("Eletroválvula S2 esta ligada? 1 para Sim /2 para Não: ");
if (int.TryParse(Console.ReadLine(), out int eletroValv))
{
    if (eletroValv == 1)
    {
        Console.WriteLine("\nEletroválvula S2 foi ligada");
    }
    else
    {
        Console.WriteLine("Eletroválvula não foi ligada");
    }
    return1:
    Console.WriteLine("Quer ligar a bomba?: 1 para sim / 2 para não");
    if (int.TryParse(Console.ReadLine(), out int bombaDeAgua))
    {
        if (eletroValv == 1 && bombaDeAgua == 1)
        {
            Console.WriteLine("Bomba de água foi ligada ");
            Console.WriteLine($"{bombaDeAgua}");
        }
        else
            {

            }
        if (eletroValv == 2 && bombaDeAgua == 1)
        {
            Console.WriteLine("Bomba de água não foi ligada pois eletroválvula fechada ou nivel de agua baixo");
        }
        else
            {
                
            }
        if (eletroValv == 1 )
        {
            Console.WriteLine("Bomba de agua não foi ligada pois nivel de água no reservatório copasa baixo");
            
        }
        else
            {
                Console.WriteLine("Bomba desligada enchendo reservatório.");
            }
    
    
    switch(bombaDeAgua & eletroValv)
    {
        case 1:
            Console.WriteLine("Caixa de água enchendo");
            int caixaDeAgua =1;

    if(caixaDeAgua ==1)
    {
        Console.WriteLine("Nível de água máximo, pare a bomba");
        goto return1;
    }
    break;
    
    }
}
}



