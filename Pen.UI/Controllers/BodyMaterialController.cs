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
    public class BodyMaterialController : Controller
    {
        IUOW _uow;
        BodyMaterialModel _bmmodel;
        public BodyMaterialController(IUOW uow, BodyMaterialModel bmmodel)
        {
            _uow = uow;
            _bmmodel = bmmodel;
        }
        public IActionResult List()
        {
            return View(_uow._bodyRepository.BodyList());
        }
        public IActionResult Recover()
        {
            return View(_uow._bodyRepository.BodyRecoverList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            _bmmodel.BodyMaterial = new BodyMaterial();
            _bmmodel.Title = "Add New Category";
            _bmmodel.BtnClass = "btn btn-primary";
            _bmmodel.BtnVal = "Add";
            return View("Crud", _bmmodel);
        }
        [HttpPost]
        public IActionResult Create(BodyMaterialModel bm)
        {
            bm.BodyMaterial.Deleted = false;
            _uow._bodyRepository.Create(bm.BodyMaterial);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _bmmodel.Title = "Add New Category";
            _bmmodel.BtnClass = "btn btn-danger";
            _bmmodel.BtnVal = "Delete";
            _bmmodel.BodyMaterial = _uow._bodyRepository.Find(id);
            return View("Crud", _bmmodel);


        }
        [HttpPost]
        public IActionResult Delete(BodyMaterialModel bm)
        {
            bm.BodyMaterial.Deleted = true;
            _uow._bodyRepository.Update(bm.BodyMaterial);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            _bmmodel.Title = "Update Section";
            _bmmodel.BtnClass = "btn btn-success";
            _bmmodel.BtnVal = "Save";
            _bmmodel.BodyMaterial = _uow._bodyRepository.Find(id);
            return View("Crud", _bmmodel);
        }
        [HttpPost]
        public IActionResult Edit(BodyMaterialModel bm)
        {
            _uow._bodyRepository.Update(bm.BodyMaterial);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

    }
}
