namespace Aula13Uber
{
    public class Motorista : Usuario
    {
     public string  Carro{ get; set; }
     public string Placa { get; set; }
     
     public  string aceitarPassageiro(string Nome){
         if( Nome == "Passageiro aceitado"){
             return " indo em direção ao destino";
         }
         return "Passageiro chegou ao seu destino";
     }
     public bool receberPagamento(){
         return true;
     }
     
    }
}