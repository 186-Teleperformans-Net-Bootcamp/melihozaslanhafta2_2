namespace melihozaslanodev2_2.Pages.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Classroom Classroom { get; set; }

        public virtual Lesson Lesson { get; set; }
    }
}
