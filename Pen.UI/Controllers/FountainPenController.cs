using Microsoft.AspNetCore.Mvc;
using Pen.Entity.Data;
using Pen.UI.Models;
using Pen.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.UI.Controllers
{
    public class FountainPenController : Controller
    {
        IUOW _uow;
        FountainPenModel _fpmodel;
        public FountainPenController(IUOW uow,FountainPenModel fpmodel)
        {
            _uow = uow;
            _fpmodel = fpmodel;
        }
        public IActionResult List()
        {
            return View(_uow._fountenRepository.FountainPenList());
        }
        public IActionResult Recover()
        {
            return View(_uow._fountenRepository.FountainPenRecoverList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            _fpmodel.FountainPen = new FountainPen();
            _fpmodel.Title = "Add New Category";
            _fpmodel.BtnClass = "btn btn-danger";
            _fpmodel.BtnVal = "Delete";
            return View("Crud", _fpmodel);
        }
        [HttpPost]
        public IActionResult Create(FountainPenModel fp)
        {
            fp.FountainPen.Deleted = false;
            _uow._fountenRepository.Create(fp.FountainPen);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _fpmodel.Title = "Add New Category";
            _fpmodel.BtnClass = "btn btn-primary";
            _fpmodel.BtnVal = "Add";
            _fpmodel.FountainPen = _uow._fountenRepository.Find(id);
            return View("Crud", _fpmodel);


        }
        [HttpPost]
        public IActionResult Delete(FountainPenModel fp)
        {
            fp.FountainPen.Deleted = true;
            _uow._fountenRepository.Update(fp.FountainPen);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            _fpmodel.Title = "Update Section";
            _fpmodel.BtnClass = "btn btn-success";
            _fpmodel.BtnVal = "Save";
            _fpmodel.FountainPen = _uow._fountenRepository.Find(id);
            return View("Crud", _fpmodel);
        }
        [HttpPost]
        public IActionResult Edit(FountainPenModel fp)
        {
            _uow._fountenRepository.Update(fp.FountainPen);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }
    }
}
