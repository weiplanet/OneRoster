namespace Questar.OneRoster.Data
{
    public class UserGrade
    {
        internal UserGrade()
        {
        }

        public UserGrade(Grade grade)
        {
            Grade = grade;
        }

        public virtual User User { get; internal set; }

        public virtual int UserId { get; internal set; }

        public virtual Grade Grade { get; internal set; }

        public virtual int GradeId { get; internal set; }
    }
}