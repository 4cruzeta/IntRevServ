namespace IntRevServ.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer()                            // Corrigida linha de public para protected
        {                                               // Construtor de classe abstrata não deve ser
        }                                               // público.

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
