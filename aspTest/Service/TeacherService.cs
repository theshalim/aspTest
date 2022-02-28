using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspTest.Context;
using aspTest.Models;

namespace aspTest.Service
{
    public class TeacherService : ITeacher
    {
        private readonly databaseContext _context;
        public TeacherService(databaseContext context)
        {
            _context = context;
        }
        public void Add(TeacherModel teacherModel)
        {
            _context.teacherModels.Add(teacherModel);
        }

        public void Delete(TeacherModel teacherModel)
        {
            _context.teacherModels.Remove(teacherModel);
        }

        public List<TeacherModel> GetAll()
        {
           return _context.teacherModels.ToList();
        }

        public TeacherModel GetById(int Id)
        {
            return _context.teacherModels.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Updaet(TeacherModel teacherModel)
        {
            _context.teacherModels.Update(teacherModel);
        }

        public void Update(TeacherModel teacherModel)
        {
            _context.teacherModels.Update(teacherModel);
        }
    }
}
