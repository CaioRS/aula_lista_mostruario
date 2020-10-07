using System.Collections.Generic;
using System;

class mostruario {
   private double valor = 0;

  //TAD
  private vendedor Representante;
       //EST  <TAD>    VARIAVEL 
  public List <veiculo> carros;

  public mostruario(vendedor v){
    Representante = v;
    carros = new List<veiculo>();

  }

  public void setRepresentante(vendedor v){
    Representante = v;
  }

  public double CalculaValor(){
    for(int i=0;i<carros.Count;i++){
      valor+=carros[i].GetValor();
    }
    return valor;
  }

}