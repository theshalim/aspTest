using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspTest.Models;
using aspTest.Service;
using Microsoft.AspNetCore.Mvc;

namespace aspTest.Controllers
{
    public class studentController : Controller
    {
        private readonly IStudent _student;
        public studentController(IStudent student)
        {
            _student = student;
        }
        public IActionResult Index()
        {
            var student = _student.GetAll();
            return View(student);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(studentModel studentModel)
        {
            _student.Add(studentModel);
            _student.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var student = _student.GetById(Id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Delete(studentModel studentModel)
        {
            _student.Delete(studentModel);
            _student.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var student = _student.GetById(Id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(studentModel studentModel)
        {
            _student.Update(studentModel);
            _student.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var student = _student.GetById(Id);
            return View(student);
        }
        

    }
}