using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw5.DTOs;
using Cw5.Models;
using Cw5.Services;

namespace Cw5.Services
{
    public interface IDbStudentService
    {
        public IEnumerable<Student> GetAllStudents();
        public GetSingleStudentResponse GetStudent(string indexNumber);
        public EnrollmentResult EnrollStudent(EnrollStudentRequest newStudent);
        public Enrolled PromoteStudents(PromoteStudentsRequest promoteStudentsRequest);
    }
}