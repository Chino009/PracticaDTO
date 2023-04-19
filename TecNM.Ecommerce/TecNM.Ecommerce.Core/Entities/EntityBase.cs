namespace TecNM.Ecommerce.Core.Entities;

public class EntityBase
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedTime { get; set; }
    public string UpdateBy { get; set; }
    public DateTime UpDateTime { get; set; }
}