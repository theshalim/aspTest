using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspTest.Models;
using aspTest.Service;
using Microsoft.AspNetCore.Mvc;

namespace aspTest.Controllers
{
    
    public class TeacherController : Controller
    {
        private readonly ITeacher _teacher;
        public TeacherController(ITeacher teacher)
        {
            _teacher = teacher;
        }
        public IActionResult Index()
        {
            var teacher = _teacher.GetAll();
            return View(teacher);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TeacherModel teacherModel)
        {
            _teacher.Add(teacherModel);
            _teacher.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var Teacher = _teacher.GetById(Id);
            return View(Teacher);
        }
        [HttpPost]
        public IActionResult Delete(TeacherModel teacherModel)
        {
            _teacher.Delete(teacherModel);
            _teacher.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var Teacher = _teacher.GetById(Id);
            return View(Teacher);
        }
        [HttpPost]
        public IActionResult Edit(TeacherModel teacherModel)
        {
            _teacher.Update(teacherModel);
            _teacher.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var teacher = _teacher.GetById(Id);
            return View(teacher);
        }
    }
}