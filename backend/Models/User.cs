namespace Models;

public class User
{
    public int? Id { get; set; }
    public string? PasswordHash { get; set; }
    public string? Email { get; set; }
    public string? Name { get; internal set; }

    // Add any additional properties or annotations needed
}
