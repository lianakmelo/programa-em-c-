using System;

class Program {
  public static void Main (string[] args) {
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.WriteLine("      Cadastro");
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write("nome:");
          Console.ForegroundColor = ConsoleColor.White;
          string nome = Console.ReadLine();

          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write("Senha: ");
          Console.ForegroundColor = ConsoleColor.White;
          string senha= Console.ReadLine();

           Console.ForegroundColor = ConsoleColor.DarkCyan;
           Console.Write("idade: ");
           Console.ForegroundColor = ConsoleColor.White;
           int age = int.Parse(Console.ReadLine());
        if (age < 18)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Sem permição:(");
        
        }
        else
        {
          Console.WriteLine(" ");
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("Sua permissão foi autorizada");
          Console.WriteLine(" ");
          Console.ForegroundColor = ConsoleColor.White;
          
         
             Console.ForegroundColor = ConsoleColor.Black;
             Console.Write("       Relatorio " + Environment.NewLine);
          Console.Write("nome: "+ nome + Environment.NewLine);
          Console.Write("senha: "+senha + Environment.NewLine);
          Console.Write("idade: "+age+" anos" + Environment.NewLine);
          
          DateTime dat = DateTime.Now;
          Console.WriteLine("data: {0:d} at {0:t}", dat);
        
         
        }
    
    }
}