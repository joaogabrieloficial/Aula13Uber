namespace Aula13Uber
{
    public class Conta : Usuario
    {
        public string Agencia { get; set; }
        public string conta { get; set; }

        public string Cadastrar(){
            return "Cadastro efetuado";
        }
        public void Excluir(){
            
        }
    }
}