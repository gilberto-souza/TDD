using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTeste
{
    private CalculadoraService _calc;

    public CalculadoraTeste(){
        _calc = new CalculadoraService();
    }

    //Realizando teste de Soma com dois valores inteiros
    [Fact]
    public void TestSoma()
    {
        int num1 =2;
        int num2 = 3;

        int resultado = _calc.Soma(num1,num2);

        Assert.Equal(5,resultado);
    }

    //Realizando teste de Subtração com dois valores inteiros
    [Fact]
    public void TestSubtracao()
    {
        int num1 =4;
        int num2 = 3;

        int resultado = _calc.Subtracao(num1,num2);

        Assert.Equal(1,resultado);
    }

    //Realizando teste de Multiplicação com dois valores inteiros
    [Fact]
    public void TestMultiplica()
    {
        int num1 =2;
        int num2 = 3;

        int resultado = _calc.Multiplicacao(num1,num2);

        Assert.Equal(6,resultado);
    }

    //Realizando teste de Divisão com dois valores inteiros
    [Fact]
    public void TestDivisao()
    {
        int num1 =6;
        int num2 = 3;

        int resultado = _calc.Divisao(num1,num2);

        Assert.Equal(2,resultado);
    }
    //Realizando teste de valores colocados no historico
    [Fact]
    public void TestHistorico()
    {           
        int num1 =2;
        int num2 = 3;
        Historico hist = new Historico("Subtração",num1,num2);

        int resultado = _calc.Subtracao(num1,num2);
        var operacao="";
        foreach(var i in _calc.ListarHistorico()){
            operacao= i.Operacao;
        }

        Assert.Equal(hist.Operacao,operacao);
    }
        
}