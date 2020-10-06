using System;

class veiculo{
  private string marca;
  private int ano;
  private int km;
  private double valor;

  public veiculo (string m, int a, int k , double v){
    marca = m;
    ano = a;
    km = k;
    valor = v;
  }

  public void relatorio(){
    Console.WriteLine("Informações do Veículo");
    Console.WriteLine("Marca:{0} | Ano:{1}",marca,ano);
    Console.WriteLine("Valor:{0} | Kilometragem:{1}",valor,km);
  }

  public void atualiza_valor(int ano_base){
    valor = valor - (ano_base - ano)*2.05;
  }
}