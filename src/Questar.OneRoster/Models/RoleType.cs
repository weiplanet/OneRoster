namespace Questar.OneRoster.Models
{
    using System.Runtime.Serialization;

    public enum RoleType
    {
        [EnumMember(Value = "administrator")]
        Administrator,

        [EnumMember(Value = "aide")]
        Aide,

        [EnumMember(Value = "guardian")]
        Guardian,

        [EnumMember(Value = "parent")]
        Parent,

        [EnumMember(Value = "proctor")]
        Proctor,

        [EnumMember(Value = "relative")]
        Relative,

        [EnumMember(Value = "student")]
        Student,

        [EnumMember(Value = "teacher")]
        Teacher
    }
}