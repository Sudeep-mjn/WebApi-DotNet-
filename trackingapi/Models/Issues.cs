using System.ComponentModel.DataAnnotations;

namespace trackingapi.Models
{
    public class Issues
    {
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public IssuesType IssuesType { get; set; }
        public DateTime? Completed { get; set; }
    }

    public enum Priority
    {
        Low, Medium,High
    }

    public enum IssuesType
    {
        Fearures, Bug, Documentation
    }

}
