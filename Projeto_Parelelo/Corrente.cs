namespace projeto_paralelo
{
    public class Corrente: Conta
    {
        public double limite { get; private set;}

         public Corrente(string argNumero, string argAgencia, double argLimite) : base(argNumero, argAgencia)
        {
            setlimmite(argLimite);
        }

     
        public void setlimmite(double argLimite){
            if (argLimite > 100){
                this.limite = argLimite;
            }
            else
                this.limite = 0;
        }

        public override bool Sacar(double argValor)
        {
            if((argValor <= (base.saldo + this.limite)))
            {
                base.setSaldo(base.saldo - argValor);
                return true;
            }
            else{
                return false;
            }
                
        }
        public new string ToString(){
            string texto = base.ToString();
                           texto += "\nlimite: " + this.limite;
            return texto;               
        }     
    }
}