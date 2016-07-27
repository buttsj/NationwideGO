using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace TemporaryVariables.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public int JavaYears { get; set; }
        public int SQLYears { get; set; }
        public int RubyYears { get; set; }
        public int JavascriptYears { get; set; }
        public int Points { get; set; }

        public string CardAndPoints { get; set; }
    }
}