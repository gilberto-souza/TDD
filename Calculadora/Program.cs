using Calculadora.Services;

CalculadoraService c = new CalculadoraService();

int num1 = 6;
int num2 = 2;

Console.WriteLine($"{num1} + {num2} = {c.Soma(num1,num2)}");

foreach(var lis in c.ListarHistorico()){
    Console.WriteLine(lis.Operacao);
}