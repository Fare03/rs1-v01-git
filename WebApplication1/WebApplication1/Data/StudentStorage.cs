using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class StudentStorage
    {
        private readonly List<Student> _students = [];

        private int _sljedeciID = 1;
        public StudentStorage()
        {
            Dodaj(new Student()
            {
                Ime = "Faris",
                Prezime = "Hujic",
                BrojIndeksa = "IB230096",
                DatumRodjenja = new DateOnly(2003, 12, 27)
            });

            Dodaj(new Student()
            {
                Ime = "Faris",
                Prezime = "Hujic",
                BrojIndeksa = "IB230067",
                DatumRodjenja = new DateOnly(2003, 12, 27)
            });
        }

        public Student Dodaj(Student student)
        {
            student.Id = _sljedeciID++;
            student.DatumKreiranja = DateTime.UtcNow;
            _students.Add(student);
            return student;
        }
        public List<Student> GetAll()
        {
            return _students;
        }
    }
}
