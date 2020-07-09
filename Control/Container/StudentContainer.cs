using Model;



namespace Control
{
    public class StudentContainer : SQLRepository<Student>, IStudentRepository
    {
        public StudentContainer(AppDbContext context) : base(context)
        {
        }


    }
}