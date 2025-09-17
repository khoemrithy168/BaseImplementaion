using System.ComponentModel.DataAnnotations;

namespace hrm_api.Model.Base;

public class BaseEntity
{
    [Key] public int ObjectID { get; set; }
    public int Status { get; set; } = 1;

    // [Column(TypeName = "int")]
    public int VersionNumber { get; set; } = 1;

    // [Column(TypeName = "nvarchar(250)")]
    // [Column(TypeName = "nvarchar250")]
    public string CreatedBy { get; set; } = "*** SYSTEM ***";

    // [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; } = DateTime.Now;

    // [Column(TypeName = "nvarchar250")]
    public string? ModifiedBy { get; set; }

    // [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public void Disable()
    {
        Status = 0;
    }

    internal string GenerateNumber(string label)
    {
        return $"{label}{ObjectID:D6}"; // D6 ensures 6-digit zero-padding
    }
}