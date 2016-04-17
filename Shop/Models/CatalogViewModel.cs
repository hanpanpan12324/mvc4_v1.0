using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    /// <summary>
    /// 商品分类视图
    /// </summary>
    public class CatalogViewModel
    {
        public List<Brand> BrandList;
        public List<ProductTypeF> ProductTypeList;
    }
}