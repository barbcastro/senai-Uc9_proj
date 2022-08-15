namespace projeto_paralelo
{
    public abstract class Conta
    {
        public string? numero { get; private set; }     
        
        public string? agencia { get; private set; }
        
        public double saldo { get; private set;}
        
        public Conta(string argNumero, string argAgencia){
            setNumero(argNumero);
            setAgencia(argAgencia);
            setSaldo(0);
        }

        
        public void setNumero(string argNumero){
            if (argNumero.Length > 4){ 
                this.numero = argNumero;
            }   
        }
        public void setAgencia(string argAgencia){
            if(argAgencia.Length > 2){
                this.agencia = argAgencia;
            }
        }
        public void setSaldo(double argSaldo){
            this.saldo = argSaldo;
        }   
        public abstract bool Sacar(double argValor);
        public bool Depositar(double argValor)
        {
            if (argValor > 0){
                this.saldo = this.saldo + argValor;
                return true;
            }
            else{
                return false;
            }
            // depositar(100);
        }
        public string ToString(){
            string texto = "Agencia:" + this.agencia +
                           "\nNro. Conta: " + this.numero +
                           "\nSaldo: "+ this.saldo;
            return texto;               
        }                   
    }
}
