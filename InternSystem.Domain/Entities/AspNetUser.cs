using System.ComponentModel.DataAnnotations;
using InternSystem.Domain.Entities.BaseEntities;

namespace InternSystem.Domain.Entities;

public class AspNetUser : BaseEntity
{
    [Key]
    public long Id { get; set; }
    public string HoVaTen { get; set; }
}