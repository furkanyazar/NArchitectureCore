using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class OperationClaim : Entity<int>
{
    public int? ParentOperationClaimId { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }

    public virtual OperationClaim? ParentOperationClaim { get; set; }
    public virtual ICollection<UserGroupOperationClaim> UserGroupOperationClaims { get; set; } = null!;

    public OperationClaim()
    {
        Name = string.Empty;
        Value = string.Empty;
    }

    public OperationClaim(string name, string value)
    {
        Name = name;
        Value = value;
    }

    public OperationClaim(int id, string name, string value)
        : base(id)
    {
        Name = name;
        Value = value;
    }
}
