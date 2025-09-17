using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hrm_api.Model;

public class LoggedRequest
{
    [Key]
    public int Id { get; set; }
    public string Description { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string UserID { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string Method { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string Controller { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string ActionName { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string Path { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string QueryString { get; set; }

    [Column(TypeName = "nvarchar(max)")]
    public string RequestBody { get; set; }

    [Column(TypeName = "nvarchar(250)")]
    public string Status { get; set; } = "ERROR";
    public double Duration { get; set; }
    public string Remark { get; set; }
        
    [Column(TypeName = "bit")]
    public bool IsDeleted { get; set; } = false;

    [Column(TypeName = "nvarchar(250)")]
    public string CreatedBy { get; set; } = "*** SYSTEM ***";

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; } = DateTime.Now;
}