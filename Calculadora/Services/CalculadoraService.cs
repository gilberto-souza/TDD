namespace Calculadora.Services;

public class CalculadoraService{
    public List<Historico> hist {get;} = new List<Historico>();

    //Definição do Metodo Soma
    public int Soma (int valor1 , int valor2){
        AddHistorico("Soma",valor1,valor2);
        return valor1 + valor2;
    }    
    
    //Definição do Metodo Soma
    public int Subtracao (int valor1 , int valor2){
        AddHistorico("Subtração",valor1,valor2);
        return valor1 - valor2;
    }

    //Definição do Metodo Soma
    public int Multiplicacao (int valor1 , int valor2){
        AddHistorico("Multiplicação",valor1,valor2);
        return valor1 * valor2;
    }

    //Definição do Metodo Soma
    public int Divisao (int valor1 , int valor2){
        AddHistorico("Divisão",valor1,valor2);
        return valor1 / valor2;
    }

    //Criando historico de operações e valores
    public List<Historico> ListarHistorico(){
        return hist;
    }

    //Adicionando Historico
    public void AddHistorico(string operacao,int valor1, int valor2){
        hist.Add(new Historico(operacao,valor1,valor2));
    }
}
