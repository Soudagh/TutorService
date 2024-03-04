namespace TutorService.Application.Models;

public class PupilModel: UserModel
{
    private string _studentId;
    private string _userId;
    private int _grade;
    private string _fullNameParent;
    private string _phoneNumberParent;

    public PupilModel(string studentId, string userId, int grade, string fullNameParent, string phoneNumberParent)
    {
        _studentId = studentId;
        _userId = userId;
        _grade = grade;
        _fullNameParent = fullNameParent;
        _phoneNumberParent = phoneNumberParent;
    }
}