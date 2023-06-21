using System;

class Program {
 public static void Main (string[] args) {
   int i, j, l, n, p;
   char[] entradaTexto = new char[1001];
   char[] linhas = new char[1002];
   n = Convert.ToInt32(Console.ReadLine());
   for (i = 0; i < n; i++)
   {
       entradaTexto = Console.ReadLine().ToCharArray();
       l = entradaTexto.Length;

       for (j = 0; j < l; j++)
       {
         //Deslocando três posições para a direita
         if ((entradaTexto[j] >= 'A') && (entradaTexto[j] <= 'Z') || (entradaTexto[j] >= 'a') && (entradaTexto[j] <= 'z'))
         {
             entradaTexto[j] += Convert.ToChar(3);

         }
       }
       p = l - 1;

       //Criando uma cópia auxiliar da string
       for (j = 0; j < l; j++)
       {
           linhas[j] = entradaTexto[p];
           p--;
       }
       linhas[j] = Convert.ToChar(0);

       //Deslocando uma posição para a esquerda
       for(j = l/2; j < l; j++)
       {
           linhas[j] -= Convert.ToChar(1);
       }
       Console.WriteLine(linhas);
     }
   }
 }