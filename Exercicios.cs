﻿using System;

class Exercicios
{
    static void Main()
    {
        //Teste exercicios
        //Exercicio1();
        //Exercicio2();
        //Exercicio3();
        //Exercicio4();
    }


    public static void Exercicio1()
    {
        Console.WriteLine("Hello, World!");
    }

    public static void Exercicio2()
    {
        string nome;

        Console.WriteLine("Informe seu nome ");
        nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}!");
    }

    public static void Exercicio3()
    {
        string nome;
        int salario;

        Console.WriteLine("Informe seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Informe seu salário: ");
        salario = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Funcionário: {nome}\nSalário: {salario}");
    }


    public static void Exercicio4()
    {
        int numero1;
        int numero2;
        int resultado;

        Console.WriteLine("Informe o primeiro número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        resultado = numero1 + numero2;

        Console.WriteLine($"A soma entre {numero1} e {numero2} é: {resultado}");

    }
}