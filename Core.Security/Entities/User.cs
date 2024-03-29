﻿using Core.Persistence.Repositories;
using Core.Security.Enums;

namespace Core.Security.Entities;

public class User : Entity<int>
{
    public int UserGroupId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public bool Status { get; set; }
    public AuthenticatorType AuthenticatorType { get; set; }

    public virtual UserGroup UserGroup { get; set; } = null!;
    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = null!;
    public virtual ICollection<EmailAuthenticator> EmailAuthenticators { get; set; } = null!;
    public virtual ICollection<OtpAuthenticator> OtpAuthenticators { get; set; } = null!;

    public User()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        PasswordSalt = Array.Empty<byte>();
        PasswordHash = Array.Empty<byte>();
    }

    public User(
        int userGroupId,
        string firstName,
        string lastName,
        string email,
        byte[] passwordSalt,
        byte[] passwordHash,
        bool status,
        AuthenticatorType authenticatorType
    )
    {
        UserGroupId = userGroupId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
        AuthenticatorType = authenticatorType;
    }

    public User(
        int id,
        int userGroupId,
        string firstName,
        string lastName,
        string email,
        byte[] passwordSalt,
        byte[] passwordHash,
        bool status,
        AuthenticatorType authenticatorType
    )
        : base(id)
    {
        UserGroupId = userGroupId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
        AuthenticatorType = authenticatorType;
    }
}
