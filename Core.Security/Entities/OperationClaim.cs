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

    public OperationClaim(int? parentOperationClaimId, string name, string value)
    {
        ParentOperationClaimId = parentOperationClaimId;
        Name = name;
        Value = value;
    }

    public OperationClaim(int id, int? parentOperationClaimId, string name, string value)
        : base(id)
    {
        Id = id;
        ParentOperationClaimId = parentOperationClaimId;
        Name = name;
        Value = value;
    }
}
