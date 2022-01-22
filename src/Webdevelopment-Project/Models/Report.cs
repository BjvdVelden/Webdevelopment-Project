using System.ComponentModel.DataAnnotations.Schema;

namespace Webdevelopment_Project.Models
{
public class Report
{
    public int ReportId{get;set;}
    public string Reden{get;set;}

    [ForeignKey("Message")]
    public int MessageId { get; set; }
    public Message Message { get; set; }

    [ForeignKey("ApplicationUser")]
    public string ApplicationUserID { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
}
}