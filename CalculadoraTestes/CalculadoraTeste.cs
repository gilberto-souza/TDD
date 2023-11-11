using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTeste
{
    private CalculadoraService _calc;

    public CalculadoraTeste(){
        _calc = new CalculadoraService();
    }

    //Realizando teste de Soma com dois valores inteiros
    [Theory]
    [InlineData (2,3,5)]
    [InlineData (4,3,7)]
    public void TestSoma(int valor1, int valor2, int resu)
    {
        int resultado = _calc.Soma(valor1,valor2);

        Assert.Equal(resu,resultado);
    }

    //Realizando teste de Subtração com dois valores inteiros
    [Theory]
    [InlineData (4,3,1)]
    [InlineData (44,3,41)]
    public void TestSubtracao(int valor1, int valor2, int resu)
    {
        int resultado = _calc.Subtracao(valor1,valor2);

        Assert.Equal(resu,resultado);
    }

    //Realizando teste de Multiplicação com dois valores inteiros
    [Theory]
    [InlineData (4,3,12)]
    [InlineData (4,4,16)]
    public void TestMultiplica(int valor1, int valor2, int resu)
    {
        int resultado = _calc.Multiplicacao(valor1,valor2);

        Assert.Equal(resu,resultado);
    }

    //Realizando teste de Divisão com dois valores inteiros
    [Theory]
    [InlineData (21,3,7)]
    [InlineData (4,4,1)]
    public void TestDivisao(int valor1, int valor2, int resu)
    {
        int resultado = _calc.Divisao(valor1,valor2);

        Assert.Equal(resu,resultado);
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