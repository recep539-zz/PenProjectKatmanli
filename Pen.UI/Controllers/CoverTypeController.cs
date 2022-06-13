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
    public class CoverTypeController : Controller
    {
        IUOW _uow;
        CoverTypeModel _cvmodel;
        public CoverTypeController(IUOW uow,CoverTypeModel cvmodel)
        {
            _cvmodel = cvmodel;
            _uow = uow;
        }
        public IActionResult List()
        {
            return View(_uow._coverRepository.CoverTypeList());
        }
        public IActionResult Recover()
        {
            return View(_uow._coverRepository.CoverTypeRecoverList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            _cvmodel.covertype = new Covertype();
            _cvmodel.Title = "Add New Category";
            _cvmodel.BtnClass = "btn btn-primary";
            _cvmodel.BtnVal = "Add";
            return View("Crud", _cvmodel);
        }
        [HttpPost]
        public IActionResult Create(CoverTypeModel cv)
        {
            cv.covertype.Deleted = false;
            _uow._coverRepository.Create(cv.covertype);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _cvmodel.Title = "Add New Category";
            _cvmodel.BtnClass = "btn btn-danger";
            _cvmodel.BtnVal = "Delete";
            _cvmodel.covertype = _uow._coverRepository.Find(id);
            return View("Crud", _cvmodel);


        }
        [HttpPost]
        public IActionResult Delete(CoverTypeModel cv)
        {
            cv.covertype.Deleted = true;
            _uow._coverRepository.Update(cv.covertype);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            _cvmodel.Title = "Update Section";
            _cvmodel.BtnClass = "btn btn-success";
            _cvmodel.BtnVal = "Save";
            _cvmodel.covertype = _uow._coverRepository.Find(id);
            return View("Crud", _cvmodel);
        }
        [HttpPost]
        public IActionResult Edit(CoverTypeModel cv)
        {
            _uow._coverRepository.Update(cv.covertype);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }
    }
}
