namespace Aula13Uber
{
    public class Cartao : Conta
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public string Bandeira { get; set; }
        public string Cvv { get; set; }

        public string CadastrarCartao(){
            return "Cartão Cadastrado";
        }
         public string excluir(){
          return "cartão excluido";
         }
    }
}