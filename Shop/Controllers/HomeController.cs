using System.Linq;
using System.Web.Mvc;
using Shop.Dal;
using Shop.Models;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopEntities _context = new ShopEntities();

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 商品分类
        /// </summary>
        /// <returns></returns>
        public ActionResult Catalog()
        {
            var model = new CatalogViewModel();
            var dal = new BrandDal();
            model.BrandList = dal.GetList();
            var pdal = new ProductTypeDal();
            model.ProductTypeList = pdal.GetTypeFList();
            return PartialView(model);
        }

        /// <summary>
        /// 导航
        /// </summary>
        /// <returns></returns>
        public ActionResult Navigation()
        {
            var model = new NavViewModel();
            var dal = new BrandDal();
            model.BrandTypeList = dal.GetListByProduct();
            model.BrandList = dal.GetList();
            var pdal = new ProductTypeDal();
            model.ProductTypeList = pdal.GetTypeFList();
            return PartialView(model);
        }

        public ActionResult Detail(int id)
        {
            var pro = _context.Products.FirstOrDefault(r => r.Id == id);
            return View(pro);
        }

        public ActionResult GetBrandList(int id)
        {
            return View();
        }

        public ActionResult GetProduct(int bid, int tid)
        {
            var list = _context.Products.Where(r => (r.BrandID == bid && bid > 0) || (r.TypeID == tid && tid > 0));
            return View(list);
        }
    }
}
