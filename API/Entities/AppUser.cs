using API.Extensions;

namespace API.Entities;

/// <summary>
/// This class is used to store the user information in the database.
/// </summary>
public class AppUser
{
    /// <summary>
    /// This is the auto-incremented primary key of the user.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// this property is used to store the username of the user.
    /// </summary>
    public required string UserName { get; set; }

    /// <summary>
    /// this property is used to store the password hash of the user.
    /// </summary>
    public byte[] PasswordHash { get; set; } = [];

    /// <summary>
    /// this property is used to store the password salt of the user.
    /// </summary>
    public byte[] PasswordSalt { get; set; } = [];

    public DateOnly DateOfBirth { get; set; }

    public required string KnownAs { get; set; }

    public DateTime Created { get; set; } = DateTime.UtcNow;

    public DateTime LastActive { get; set; } = DateTime.UtcNow;

    public required string Gender { get; set; }

    public string? Introduction { get; set; }

    public string? Interests { get; set; }

    public string? LookingFor { get; set; }

    public required string City { get; set; }

    public required string Country { get; set; }

    public List<Photo> Photos { get; set; } = [];

    // public int GetAge(){
    //     return DateOfBirth.CalculateAge();
    // }

}
