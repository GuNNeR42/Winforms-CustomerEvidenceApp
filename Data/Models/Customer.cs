namespace CustomerEvidenceApp.Data.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public int IQ { get; set; }
        public string Gender { get; set; }
        public bool GdprAgreement { get; set; }
    }
}
