using CApp.Model;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CApp.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentController
    {

        [HttpGet]
        public IEnumerable<Student> GetStudent()
        {
            return CollageRepositorycs.Student;
        }
        [HttpGet("{id }")]
        //[Route("All",Name ="Id")]
        public Student GetStudentById(int id)
        {
            return CollageRepositorycs.Student.Where(n =>n.Id == id).FirstOrDefault();
        }
       
        
        
        

    }
}
