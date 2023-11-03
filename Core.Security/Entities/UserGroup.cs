using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class UserGroup : Entity<int>
{
    public string Name { get; set; }

    public virtual ICollection<User> Users { get; set; } = null!;
    public virtual ICollection<UserGroupOperationClaim> UserGroupOperationClaims { get; set; } = null!;

    public UserGroup()
    {
        Name = string.Empty;
    }

    public UserGroup(string name)
    {
        Name = name;
    }

    public UserGroup(int id, string name)
        : base(id)
    {
        Name = name;
    }
}
