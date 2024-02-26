
using System;

//Console.Clear();

/** menu**/
Menu();


static void Menu(){
Console.Clear();
System.Console.WriteLine("----------Menu------------");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtracao");
Console.WriteLine("3 - Multiplicacao");
Console.WriteLine("4 - Divisao");
System.Console.WriteLine("--------------------");
Console.WriteLine("Selecione uma opção acima: ");

int opcao = int.Parse(Console.ReadLine());

switch(opcao){
    case 1: soma(); break;
    case 2: subtracao(); break;
    case 3: multiplicacao(); break;
    case 4: divisao(); break;
    case 0: break;
    default: Menu();break;
}

}

static void soma (){

    Console.Clear();
    Console.WriteLine("primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());


    System.Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    System.Console.WriteLine(" ");

    System.Console.WriteLine("Resultado da soma é: "+ (v1 + v2));
    Console.ReadKey();
    Menu();


}

static void divisao(){
    
    Console.Clear();
    Console.WriteLine("primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());


    System.Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    System.Console.WriteLine(" ");

    System.Console.WriteLine("Resultado da soma é: "+ (v1 / v2));
    Console.ReadKey();
    Menu();


}

static void subtracao(){

    Console.Clear();
    Console.WriteLine("primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());


    System.Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    System.Console.WriteLine(" ");

    System.Console.WriteLine("Resultado da soma é: "+ (v1 - v2));

    Console.ReadKey();
    Menu();

}

static void multiplicacao(){


    Console.Clear();
    Console.WriteLine("primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());


    System.Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    System.Console.WriteLine(" ");

    System.Console.WriteLine("Resultado da soma é: "+ (v1 * v2));
    Console.ReadKey();
    Menu();

}



