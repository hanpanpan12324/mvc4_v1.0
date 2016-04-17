using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shop.Models;

namespace Shop.Dal
{
    public class ProductTypeDal
    {
        private readonly Models.ShopEntities _context = new ShopEntities();

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public List<ProductTypeF> GetTypeFList()
        {
            return _context.ProductTypeF.ToList();
        }
    }
}