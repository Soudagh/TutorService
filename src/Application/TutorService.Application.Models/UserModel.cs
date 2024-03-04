namespace DefaultNamespace;

public class UserModel
{
    private string _userId;
    private string _fullName;
    private string _phone;
    private string _mail;
    private string _avatar;
    private string _login;
    private string _passwordHashed;
    private RoleEnum _role;

    public UserModel(string userId,
        string fullName,
        string phone,
        string mail,
        string avatar,
        string login,
        string passwordHashed,
        RoleEnum role)
    {
        _userId = userId;
        _fullName = fullName;
        _phone = phone;
        _mail = mail;
        _avatar = avatar;
        _login = login;
        _passwordHashed = passwordHashed;
        _role = role;
    }
}