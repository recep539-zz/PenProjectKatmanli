using Microsoft.AspNetCore.Mvc;
using Pen.Entity.Data;
using Pen.UI.Models;
using Pen.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DolmaKalemProjesi.Controllers
{
    public class PenStatusController : Controller
    {
        IUOW _uow;
        PenStatusModel _psmodel;
        public PenStatusController(IUOW uow,PenStatusModel psmodel)
        {
            _uow = uow;
            _psmodel = psmodel;
        }
        public IActionResult List()
        {
            return View(_uow._penstatusRepository.PenStatusList());
        }
        public IActionResult Recover()
        {
            return View(_uow._penstatusRepository.PenStatusRecoverList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            _psmodel.PenStatus = new PenStatus();
            _psmodel.Title = "Add New Category";
            _psmodel.BtnClass = "btn btn-primary";
            _psmodel.BtnVal = "Add";
            return View("Crud", _psmodel);
        }
        [HttpPost]
        public IActionResult Create(PenStatusModel ps)
        {
            ps.PenStatus.Deleted = false;
            _uow._penstatusRepository.Create(ps.PenStatus);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _psmodel.Title = "Add New Category";
            _psmodel.BtnClass = "btn btn-danger";
            _psmodel.BtnVal = "Delete";
            _psmodel.PenStatus = _uow._penstatusRepository.Find(id);
            return View("Crud", _psmodel);
            
            
        }
        [HttpPost]
        public IActionResult Delete(PenStatusModel ps)
        {
            ps.PenStatus.Deleted = true;
            _uow._penstatusRepository.Update(ps.PenStatus);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            _psmodel.Title = "Update Section";
            _psmodel.BtnClass = "btn btn-success";
            _psmodel.BtnVal = "Save";
            _psmodel.PenStatus = _uow._penstatusRepository.Find(id);
            return View("Crud", _psmodel);
        }
        [HttpPost]
        public IActionResult Edit(PenStatusModel ps)
        {
            _uow._penstatusRepository.Update(ps.PenStatus);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }
    }
}
