namespace CaseCustomerDomain.Entities
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public int Status { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
