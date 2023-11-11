//Stefeson
 
double SalarioM, SalarioD, SalarioH, hTrabalhadas;
 
Console.Clear();
 
Console.WriteLine("De acordo com suas horas extras você recebe mais 40% do valor em cima disso");
Console.WriteLine ("Qual seu salário?:");
SalarioM = Convert.ToInt32(Console.ReadLine());

Thread.Sleep(1000);
 
SalarioH = SalarioM / (8 * 20);
SalarioD = SalarioH * 8;
 
Console.WriteLine($"Você recebe por dia: {SalarioD.ToString("N2")} Reais");
 
Thread.Sleep(3000);

Console.WriteLine ($"Por hora: {SalarioH.ToString("N2")} Reais");
 
Thread.Sleep(5000);
Console.Clear();
 
Console.WriteLine ("Quantas horas EXTRAS você realizou hoje?");
Console.WriteLine ("Horas extras trabalhadas:");
hTrabalhadas = Convert.ToDouble(Console.ReadLine());

double ValorHExtra = hTrabalhadas * (SalarioH * 1.4);

double Resultado = SalarioD + ValorHExtra;

double SalarioFM = Resultado + SalarioM;

Console.WriteLine ($"Seu salário no final do dia de acordo com as horas extras é: {Resultado.ToString("N2")} R$");
Console.WriteLine ($"E seu salário no final do mês será:{SalarioFM.ToString("N2")} R$");