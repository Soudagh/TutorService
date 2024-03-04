namespace TutorService.Application.Models;

public class StudentModel: UserModel
{
    private string _studentId;
    private string _userId;
    private int _grade;
    private string _fullNameParent;
    private string _phoneNumberParent;


    public StudentModel(string userId, string fullName, string phone, string mail, string avatar, string login, string passwordHashed, RoleEnum role, string studentId, string fullNameParent, string phoneNumberParent, int grade) : base(userId, fullName, phone, mail, avatar, login, passwordHashed, role)
    {
        _userId = userId;
        _studentId = studentId;
        _fullNameParent = fullNameParent;
        _phoneNumberParent = phoneNumberParent;
        _grade = grade;
    }
}