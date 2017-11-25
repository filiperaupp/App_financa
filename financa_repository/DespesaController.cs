using financa_domain;
using Microsoft.AspNetCore.Mvc;

namespace financa_repository
{
    public class DespesaController : Controller
    {
        
        private IDespesaRepository _repository;
        private ITipoDespesaRepository _repositoryTipoDesp;

        public DespesaController(IDespesaRepository repository, ITipoDespesaRepository repositoryTipoDesp){
            _repository = repository;
            _repositoryTipoDesp = repositoryTipoDesp;
        }

        public IActionResult Index()
        {
            var despesas = _repository.GetAll();
            return View(despesas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categoria = _repositoryTipoDesp.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Despesa despesa)
        {
            _repository.Create(despesa);
            return RedirectToAction("Index");
        }

        public IActionResult Delete (int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit (int id)
        {
            ViewBag.Categoria = _repositoryTipoDesp.GetAll();
            return View (_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit (Despesa despesa) 
        {
            _repository.Update(despesa);
            return RedirectToAction("Index");
        }
    }
}