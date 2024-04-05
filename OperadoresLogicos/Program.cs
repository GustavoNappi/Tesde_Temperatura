
//Teste de temperatura
Console.WriteLine("Qual é a temperatura lá fora?");
double temp = Convert.ToDouble(Console.ReadLine());

if (temp >= 10 && temp <= 25)
{
    Console.WriteLine("está é um tempo agradavel lá fora");
}

else if (temp <= -50 || temp >= 50)
{
    Console.WriteLine("NÃO VAI LÁ FORA");
}


Console.ReadKey();