using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class UserGroupOperationClaim : Entity<int>
{
    public int UserGroupId { get; set; }
    public int OperationClaimId { get; set; }

    public virtual UserGroup UserGroup { get; set; } = null!;
    public virtual OperationClaim OperationClaim { get; set; } = null!;

    public UserGroupOperationClaim() { }

    public UserGroupOperationClaim(int userGroupId, int operationClaimId)
    {
        UserGroupId = userGroupId;
        OperationClaimId = operationClaimId;
    }

    public UserGroupOperationClaim(int id, int userGroupId, int operationClaimId)
        : base(id)
    {
        UserGroupId = userGroupId;
        OperationClaimId = operationClaimId;
    }
}
