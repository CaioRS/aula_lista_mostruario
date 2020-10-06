using System;

class vendedor{
  private double salario;
  private double comissao;
  private string nome;

  public vendedor (double s, double c , string n){
    salario = s;
    comissao = c;
    nome = n;
  }

  public void SetNome(string n){
    nome = n;
  }

  public string GetNome(){
    return nome;
  }


  public double receber_relatorio(double valor_vendas){
    return (salario + comissao*valor_vendas);
  }
}