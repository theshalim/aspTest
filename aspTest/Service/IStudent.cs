using aspTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspTest.Service
{
    public interface IStudent
    {
        List<studentModel> GetAll();
        studentModel GetById(int Id);
        void Add(studentModel studentModel);
        void Delete(studentModel studentModel);
        void Update(studentModel studentModel);
        void Save();
    }
}
