using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspTest.Context;
using aspTest.Models;

namespace aspTest.Service
{
    public class studentService : IStudent
    {
        databaseContext _context;
        public studentService(databaseContext context)
        {
            _context = context;
        }
        public void Add(studentModel studentModel)
        {
            _context.studentModels.Add(studentModel);
          
        }

        public void Delete(studentModel studentModel)
        {
            _context.studentModels.Remove(studentModel);
        }

        public List<studentModel> GetAll()
        {
          return  _context.studentModels.ToList();
        }

        public studentModel GetById(int Id)
        {
            return _context.studentModels.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(studentModel studentModel)
        {
            _context.studentModels.Update(studentModel);
        }
    }
}
