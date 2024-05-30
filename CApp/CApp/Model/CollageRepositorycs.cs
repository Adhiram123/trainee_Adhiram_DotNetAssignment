namespace CApp.Model
{
    public class CollageRepositorycs
    {
        public static List<Student> Student
        {
            get; set;
        }= new List<Student>(){
                new Student
                {

                    Id  =1,
                    StudentName ="Student 1",
                    Email ="Student@1",
                    Adress="2222211"
                },
                new Student ()
                 {

                    Id = 1,
                    StudentName = "Stduent",
                    Email = "2@@",
                    Adress = "222"



                }



            };
    }
}
