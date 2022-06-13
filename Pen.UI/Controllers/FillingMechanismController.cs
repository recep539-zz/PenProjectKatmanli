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
    public class FillingMechanismController : Controller
    {
        IUOW _uow;
        FillingMechanismModel _fmmodel;
        public FillingMechanismController(IUOW uow, FillingMechanismModel fmmodel)
        {
            _uow = uow;
            _fmmodel = fmmodel;
        }
        public IActionResult List()
        {
            return View(_uow._fillingRepository.FillingMechanismList());
        }
        public IActionResult Recover()
        {
            return View(_uow._fillingRepository.FillingMechanismRecoverList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            _fmmodel.FillingMechanism = new FillingMechanism();
            _fmmodel.Title = "Add New Category";
            _fmmodel.BtnClass = "btn btn-primary";
            _fmmodel.BtnVal = "Create";
            return View("Crud", _fmmodel);
        }
        [HttpPost]
        public IActionResult Create(FillingMechanismModel fm)
        {
            fm.FillingMechanism.Deleted = false;
            _uow._fillingRepository.Create(fm.FillingMechanism);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _fmmodel.Title = "Add New Category";
            _fmmodel.BtnClass = "btn btn-danger";
            _fmmodel.BtnVal = "Delete";
            _fmmodel.FillingMechanism = _uow._fillingRepository.Find(id);
            return View("Crud", _fmmodel);


        }
        [HttpPost]
        public IActionResult Delete(FillingMechanismModel fm)
        {
            fm.FillingMechanism.Deleted = true;
            _uow._fillingRepository.Update(fm.FillingMechanism);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            _fmmodel.Title = "Update Section";
            _fmmodel.BtnClass = "btn btn-success";
            _fmmodel.BtnVal = "Save";
            _fmmodel.FillingMechanism = _uow._fillingRepository.Find(id);
            return View("Crud", _fmmodel);
        }
        [HttpPost]
        public IActionResult Edit(FillingMechanismModel fm)
        {
            _uow._fillingRepository.Update(fm.FillingMechanism);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }
    }
}
