namespace Polimorfismo
{
    public class Gol : Carro
    {

        //override -> Me mostra quem eu posso sobreescrever

        public override void AumentarAno(int quantidadeAnos)
        {
            //Por puxar da base, eu posso implementar ações direto do método que está na base, e aqui eu apenas o chamo já com suas ações atribuidas.
            base.AumentarAno(quantidadeAnos);
            //Base -> Classe mãe, de onde todos herdam algum método, neste caso, a mãe seria a classe "Carro".
            Ano += quantidadeAnos;
        }

        //public override void AumentarAno(int quantidadeAnos)
        //{
        //    Ano += quantidadeAnos; 
        //}
    }
}
