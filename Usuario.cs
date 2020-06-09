namespace Aula13Uber
{
    public class Usuario
    {
        private string login = "joão@gmail.com";
        private string senha = "mestredocaos123";
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string LocalizacaoAtual {get;set;}
        public string TokenLogin {get; set;}

        public bool Login(string login,string senha){
            if(this.login == login && this.senha == senha){
                TokenLogin ="jifu8udfije8ufj34iu5834rue0w9i3i";
                return true;
            }
            return false;
        }
         public void Logout(){
             TokenLogin = "";
         }
        
    }
}