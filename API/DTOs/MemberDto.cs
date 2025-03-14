namespace API.DTOs;

public class MemberDto
{
        /// <summary>
    /// This is the auto-incremented primary key of the user.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// this property is used to store the username of the user.
    /// </summary>
    public string? Username { get; set; }

    public int Age {get; set;}

    public string? PhotoUrl { get; set; }

    public string? KnownAs { get; set; }

    public DateTime Created { get; set; }

    public DateTime LastActive { get; set; }

    public string? Gender { get; set; }

    public string? Introduction { get; set; }

    public string? Interests { get; set; }

    public string? LookingFor { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public List<PhotoDto>? Photos { get; set; }

}
