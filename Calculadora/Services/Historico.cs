namespace Calculadora.Services;

public class Historico{

    public string? Operacao {get;}
    public int? Valor1 {get;}
    public int? Valor2 {get;}

    
    public Historico(string operacao,int valor1,int valor2){
        Operacao = operacao;
        Valor1 = valor1;
        Valor2 = valor2;
    }

    public Historico(){
        
    }

}