namespace TutorService.Application.Models;

public class TutorModel : UserModel
{
    private string _tutorId;
    private string _userId;
    private string[] _subjects;
    private string _dateStartTeaching;
    private string _place;

    public TutorModel(string userId, string fullName, string phone, string mail, string avatar, string login,
        string passwordHashed, RoleEnum role, string tutorId, string[] subjects, string dateStartTeaching,
        string place) : base(userId, fullName, phone, mail, avatar, login, passwordHashed, role)
    {
        _userId = userId;
        _tutorId = tutorId;
        _subjects = subjects;
        _dateStartTeaching = dateStartTeaching;
        _place = place;
    }
}