namespace WebApplication1.Models
{
    public class DarrylModel
    {
        public string Title { get; set; } = string.Empty;
        public string LicenseNumber { get; set; } = string.Empty;
        public string StudentClass { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Github { get; set; } = string.Empty;
        public string PhotoPath { get; set; } = string.Empty;
        public string Signature { get; set; } = string.Empty;
        public List<string> Achievements { get; set; } = new List<string>();
    }
}