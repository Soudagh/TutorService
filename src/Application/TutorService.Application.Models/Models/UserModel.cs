namespace TutorService.Application.Models.Models;

public class UserModel
{
    public Guid UserId { get; set; }

    public string FullName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string Avatar { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string PasswordHashed { get; set; } = null!;

    public Roles Role { get; set; }
}