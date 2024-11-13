﻿using System;
using System.Collections.Generic;

class Progasmd
{
    static void Ordenar(int[] vetor)
    {
        int menor, aux;
        for (int i = 0; i < vetor.Length; i++)
        {
            menor = i;
            for (int j = i + 1; j < vetor.Length; j++)
            {
                if (vetor[j] < vetor[menor])
                {
                    menor = j;
                }                
            }
            aux = vetor[i];
            vetor[i] = vetor[menor];
            vetor[menor]  = aux;
        }
    }
    static void Imprimir(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }
        System.Console.WriteLine("");
    }
}