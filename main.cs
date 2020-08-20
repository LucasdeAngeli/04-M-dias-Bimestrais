using System;

//Faça um Programa que peça as 4 notas bimestrais e mostre a média.

class MainClass {
  public static void Main (string[] args) {
    float num1, num2, num3, num4, media;

    Console.WriteLine("Informe a 1ª nota: ");
    num1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe a 2ª nota: ");
    num2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe a 3ª nota: ");
    num3 = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe a 4ª nota: ");
    num4 = float.Parse(Console.ReadLine());

    //Calculo da media
    media = (num1+num2+num3+num4)/4;

    Console.WriteLine ("A média foi de: {0}", media);
  }
}