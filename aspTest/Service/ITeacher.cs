using aspTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspTest.Service
{
   public interface ITeacher
    {
        List<TeacherModel> GetAll();
        TeacherModel GetById(int Id);
        void Add(TeacherModel teacherModel);
        void Delete(TeacherModel teacherModel);
        void Update(TeacherModel teacherModel);
        void Save();
    }
}
