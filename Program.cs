// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//EXERCÌCIO 2

//Armazenamento de dados

double baseT;
double altura;
double resultado;

//Entrada de dados

Console.WriteLine("");
Console.WriteLine("Olá. Digite o valor da base do seu triangulo");
baseT = double.Parse(Console.ReadLine());
Console.WriteLine("Certo, agora digite o valor da altura do triangulo");
altura = double.Parse(Console.ReadLine());

//Opração a ser realizada

resultado = (baseT*altura)/2;

//Resultado

Console.WriteLine("");
Console.WriteLine("O resultado da Área do Triangulo é " + resultado);
