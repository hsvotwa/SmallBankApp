namespace SmallBankApplication.Shared.Models
{
    public class JWTConfig
    {
        public JWTConfig() { }

        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double DurationInMinutes { get; set; }
    }
}
