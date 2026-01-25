namespace LoanSystem.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Property
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
