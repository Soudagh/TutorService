namespace TutorService.Application.Models.Entities;

public class User
{
    public Guid UserId { get; set; }

    public string FullName { get; set; }

    public string Phone { get; set; }

    public string Mail { get; set; }

    public string Avatar { get; set; }

    public string Login { get; set; }

    public string PasswordHashed { get; set; }

    public Roles Role { get; set; }

    public User(
        Guid userId,
        string fullName,
        string phone,
        string mail,
        string avatar,
        string login,
        string passwordHashed,
        Roles role)
    {
        UserId = userId;
        FullName = fullName;
        Phone = phone;
        Mail = mail;
        Avatar = avatar;
        Login = login;
        PasswordHashed = passwordHashed;
        Role = role;
    }
}