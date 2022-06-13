using Microsoft.AspNetCore.Mvc;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pen.UnitOfWork;
using Pen.Entity.Data;
using Pen.UI.Models;

namespace Pen.UI.Controllers
{
    public class PenInformationController : Controller
    {
        IUOW _uow;
        PenInformationModel _pimodel;
        public PenInformationController(IUOW uow, PenInformationModel pimodel)
        {
            _uow = uow;
            _pimodel = pimodel;
        }
        public IActionResult List()
        {
            return View(_uow._peninformationRepository.PenInformationList());
        }
        public IActionResult Recover()
        {
            return View(_uow._peninformationRepository.PenInformationRecoverList());
        }
        public IActionResult Details(int id)
        {
            return View(_uow._peninformationRepository.PenInformationDetailList(id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            _pimodel.PenInformation = new PenInformation();
            _pimodel.Title = "Add New PenInformation";
            _pimodel.BtnClass = "btn btn-primary";
            _pimodel.BtnVal = "Add";
            _pimodel.BodyMaterialList = _uow._bodyRepository.BodyList();
            _pimodel.PenStatusList = _uow._penstatusRepository.PenStatusList();
            _pimodel.CoverTypeList = _uow._coverRepository.CoverTypeList();
            _pimodel.FillingMechanismList = _uow._fillingRepository.FillingMechanismList();
            _pimodel.TipTypeList = _uow._tiptypeRepository.TipTypeList();          
            return View("Crud", _pimodel);
        }
        [HttpPost]
        public IActionResult Create(PenInformationModel pi)
        {
            pi.PenInformation.Deleted = false;
            _uow._peninformationRepository.Create(pi.PenInformation);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _pimodel.Title = "Delete PenInformation";
            _pimodel.BtnClass = "btn btn-danger";
            _pimodel.BtnVal = "Delete";
            _pimodel.BodyMaterialList = _uow._bodyRepository.BodyList();
            _pimodel.PenStatusList = _uow._penstatusRepository.PenStatusList();
            _pimodel.CoverTypeList = _uow._coverRepository.CoverTypeList();
            _pimodel.FillingMechanismList = _uow._fillingRepository.FillingMechanismList();
            _pimodel.TipTypeList = _uow._tiptypeRepository.TipTypeList();
            _pimodel.PenInformation = _uow._peninformationRepository.Find(id);
            return View("Crud", _pimodel);


        }
        [HttpPost]
        public IActionResult Delete(PenInformationModel pi)
        {
            pi.PenInformation.Deleted = true;
            _uow._peninformationRepository.Update(pi.PenInformation);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            _pimodel.Title = "Update Section";
            _pimodel.BtnClass = "btn btn-success";
            _pimodel.BtnVal = "Save";
            _pimodel.BodyMaterialList = _uow._bodyRepository.BodyList();
            _pimodel.PenStatusList = _uow._penstatusRepository.PenStatusList();
            _pimodel.CoverTypeList = _uow._coverRepository.CoverTypeList();
            _pimodel.FillingMechanismList = _uow._fillingRepository.FillingMechanismList();
            _pimodel.TipTypeList = _uow._tiptypeRepository.TipTypeList();
            _pimodel.PenInformation = _uow._peninformationRepository.Find(id);
            return View("Crud", _pimodel);
        }
        [HttpPost]
        public IActionResult Edit(PenInformationModel pi)
        {
            _uow._peninformationRepository.Update(pi.PenInformation);
            _uow.Commit();
            _uow.Dispose();
            return RedirectToAction("List");
        }
    }
}
