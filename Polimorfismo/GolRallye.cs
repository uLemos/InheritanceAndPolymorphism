namespace Polimorfismo
{
    public class GolRallye : Carro
    {
        public void AumentarAno(int multiploDe, int valorBase)
        {
            Ano += (multiploDe * valorBase);
        }
        public void AumentarAno()
        {
            Ano += 10;
        }
        
        //Método diferente de aplicar um override
        public override void AumentarAno(int quantidadeAnos)
        {
            Ano += quantidadeAnos;
        }

        //public override void AumentarAno(int quantidadeAnos)
        //{
        //    base.AumentarAno(quantidadeAnos);
        //    Ano += quantidadeAnos;
        //}
    }
}
