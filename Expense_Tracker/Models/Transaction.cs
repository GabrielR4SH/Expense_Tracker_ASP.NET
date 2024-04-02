namespace Expense_Tracker.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }

        //CategoryID

        public int Amount { get; set; }

        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
