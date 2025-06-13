﻿string Pergunta;
Console.Clear();
Console.WriteLine("--- Groot Chatbot ---");

while (true)
{
    Console.Write("pergunta: ");
    Pergunta = Console.ReadLine();

    if (Pergunta == "tchau") 
    {
        Console.WriteLine("         Resposta: Eu sou Groot.");
        return;
    }
    else 
    {
        Console.WriteLine("         Resposta: Eu sou Groot.");
        
    }
}