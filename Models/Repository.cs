namespace aspnetcore_basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
            new Course() {
                Id = 1, 
                Title = "aspnet kursu", 
                Description = "güzel bir kurs", 
                Image = "1.jpeg",
                Tags = new string[] {"aspnet", "web geliştirme"},
                isActive = true,
                isHome = true
                },

            new Course() {
                Id = 2, 
                Title = "php kursu", 
                Description = "güzel bir kurs", 
                Image = "2.jpeg",
                Tags = new string[] {"php", "web geliştirme"},
                isActive = false,
                isHome = true
                },

            new Course() {
                Id = 3, 
                Title = "django kursu",
                Description = "Django, Python programlama dili ile yazılmış yüksek seviyeli bir web framework'üdür. Django, hızlı ve kolay bir şekilde güçlü ve ölçeklenebilir web uygulamaları geliştirmek için tasarlanmıştır. İşte Django hakkında bazı temel bilgiler:", 
                Image = "3.jpeg",
                isActive = true,
                isHome = false
                },

            new Course() {
                Id = 4, 
                Title = "python-kursu", 
                Description = "güzel-bir kurs", 
                Image = "4.jpeg",
                isActive = true,
                isHome = true
                }
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

    }
}