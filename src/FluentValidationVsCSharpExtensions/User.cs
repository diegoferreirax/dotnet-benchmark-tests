namespace FluentValidationVsCShapExtensions;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Role { get; set; } = null!;

    public User(Guid id, string name, string email, string password, string role)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
        Role = role;
    }
}
