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
    public class TipTypeController : Controller
    {
        IUOW _uow;
        TipTypeModel _tpmodel;
        public TipTypeController(IUOW uow,TipTypeModel tpmodel)
        {
            _uow = uow;
            _tpmodel = tpmodel;
        }
        public IActionResult List()
        {
            return View(_uow._tiptypeRepository.TipTypeList());
        }
        public IActionResult Recover()
        {
            return View(_uow._tiptypeRepository.TipTypeRecoverList());
        }
        public IActionResult Create()
        {
            _tpmodel.TipTypes = new TipType();
            _tpmodel.Title = "Add New Category";
            _tpmodel.BtnClass = "btn btn-primary";
            _tpmodel.BtnVal = "Add";
            return View("Crud", _tpmodel);
        }
        [HttpPost]
        public IActionResult Create(TipTypeModel tp)
        {
            tp.TipTypes.Deleted = false;
            _uow._tiptypeRepository.Create(tp.TipTypes);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _tpmodel.Title = "Add New Category";
            _tpmodel.BtnClass = "btn btn-danger";
            _tpmodel.BtnVal = "Delete";
            _tpmodel.TipTypes = _uow._tiptypeRepository.Find(id);
            return View("Crud", _tpmodel);


        }
        [HttpPost]
        public IActionResult Delete(TipTypeModel tp)
        {
            tp.TipTypes.Deleted = true;
            _uow._tiptypeRepository.Update(tp.TipTypes);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            _tpmodel.Title = "Update Section";
            _tpmodel.BtnClass = "btn btn-success";
            _tpmodel.BtnVal = "Save";
            _tpmodel.TipTypes = _uow._tiptypeRepository.Find(id);
            return View("Crud", _tpmodel);
        }
        [HttpPost]
        public IActionResult Edit(TipTypeModel tp)
        {
            _uow._tiptypeRepository.Update(tp.TipTypes);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

    }
}
