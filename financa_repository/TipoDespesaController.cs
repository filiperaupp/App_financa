using financa_domain;
using Microsoft.AspNetCore.Mvc;

namespace financa_repository
{
    public class TipoDespesaController : Controller
    {
        public ITipoDespesaRepository _repositoryTipoDesp;

        public TipoDespesaController (ITipoDespesaRepository repository) 
        {
            _repositoryTipoDesp = repository;
        }

        public IActionResult Index() 
        {
            var tipoDesp = _repositoryTipoDesp.GetAll();
            return View(tipoDesp);
        }

        [HttpGet]

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(TipoDespesa tipoDesp){
            _repositoryTipoDesp.Create(tipoDesp);
            return RedirectToAction("Index");
        }

        public IActionResult Delte (int id) 
        {
            _repositoryTipoDesp.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit (int id) 
        {
            return View(_repositoryTipoDesp.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit (TipoDespesa tipoDesp)
        {
            _repositoryTipoDesp.Update(tipoDesp);
            return RedirectToAction("Index");
        }
    }
}