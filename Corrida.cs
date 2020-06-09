namespace Aula13Uber
{
    public class Corrida : Motorista
    {
        public string LocalInicio { get; set; }
        public string LocalChegada { get; set; }
        public string StatusCorrida { get; set; }
        public string Motorista { get; set; }
        public string Passageiro { get; set; }

        public string Cancelar(){
            return "Corrida cancelada O-ONI-CHAN (>_<)' ";
        }

    }
}