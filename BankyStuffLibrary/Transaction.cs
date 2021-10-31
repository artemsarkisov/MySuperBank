using System;
using System.Globalization;
using Humanizer;

namespace BankyStuffLibrary
{
    public class Transaction
    {
        public decimal Amount { get; set; }

        public string HumanReadableAmount {
            get
            {
                return ((int)Amount).ToWords();
            }
        }

        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}