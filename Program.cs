using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
           Usuario user =new Usuario();

           System.Console.WriteLine("Digite seu login");
           string login = Console.ReadLine();

           System.Console.WriteLine("Digite sua senha");
           string senha = Console.ReadLine();

           user.Login(login, senha);

           if(user.TokenLogin != "" && user.TokenLogin != null){

               System.Console.WriteLine("Acesso liberado! Usuário logado");
               System.Console.WriteLine(user.TokenLogin);
           }else{
               Console.WriteLine("Usuário deslogado");

               Corrida corrida = new Corrida();

               corrida.aceitarPassageiro(user.Nome);
               corrida.Cancelar();
               corrida.receberPagamento();
               

           }
        }
    }
}
