namespace Aula13Uber
{
    public class Passageiro : Usuario
    {
        public string SolicitarMotorista(){
            return " Procurando motoristas disponíveis...";

        }
        public string Pagar(string statusCorrida){
            if(statusCorrida == "finalizada"){
                return "Pagamento efetuado";
            }
            return "Pagamento pendente pois a corrida não foi finalizada";
        }
    } 
}