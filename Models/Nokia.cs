namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - IMPLEMENTADO
    public class Nokia : Smartphone
    {
         public Nokia(string numero) : base(numero){
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no seu Nokia.");
        }
    }
}