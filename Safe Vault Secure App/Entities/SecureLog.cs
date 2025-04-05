namespace Safe_Vault_Secure_App.Entities
{
    public class SecureLog
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string PerformedBy { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
