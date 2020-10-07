using System;

class MainClass {
  public static void Main (string[] args) {
    vendedor carlos = new vendedor(200.34 ,1.34,"Carlos");
    veiculo uno = new veiculo("Fiat", 2020 , 0 , 50000);
    double soma = 0;

    mostruario secaoA = new mostruario(carlos);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);

    soma = secaoA.CalculaValor();
    Console.WriteLine("SOMA >> {0}", soma);



  }
}