namespace RiceAndBeans.UI.Controllers
{
    using RiceAndBeans.Service.Interface;
    using RiceAndBeans.UI.ViewModel;
    using System.Linq;
    using System.Web.Mvc;

    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var allCategories = _categoryService.GetAll()?.ToList().Select(m => new QuickDetailsCategoryViewModel { Id = m.Id, Name = m.Name }); ;
            return View(allCategories);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult QuickCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult QuickCreate(QuickCategoryViewModel model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _categoryService.QuickInsert(new DTO.QuickCreationDTO { CategoryName = model.CategoryName, Enabled = true });
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch (System.Exception ex)
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
