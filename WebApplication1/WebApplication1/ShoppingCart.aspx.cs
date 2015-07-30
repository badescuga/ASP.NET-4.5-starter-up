using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
using WebApplication1.Logic;

namespace WebApplication1
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public IQueryable<CartItem> GetShoppingCartItems()
        //{
        //    var _db = new ProductContext();
        //    var query = _db.ShoppingCartItems.Where(cartItem => cartItem.CartId == ShoppingCartActions.GetCartId());

        //    return query;
        //}

        public List<CartItem> GetShoppingCartItems()
        {
            ShoppingCartActions actions = new ShoppingCartActions();
            return actions.GetCartItems();
        }



    }
}