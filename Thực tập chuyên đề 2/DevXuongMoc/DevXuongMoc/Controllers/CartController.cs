using DevXuongMoc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json;
namespace DevXuongMoc.Controllers
{
    public class CartController : Controller, IActionFilter
    {
        private readonly XuongMocContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private List<Cart> carts = new List<Cart>();
        public CartController(XuongMocContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cartInSesion = HttpContext.Session.GetString("My-Cart");
            if (cartInSesion != null)
            {
                //nếu cartInSession ko null thì gán giá trị cho biến carts
                //chuyển sang dữ liệu json
                carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSesion);
            }
            base.OnActionExecuting(context);
        }

        public IActionResult Index()
        {
            // Giả sử có phương thức lấy thông tin người dùng
            //if (HttpContext.Session.GetString("Member") != null)
            //{
            //    // Lấy thông tin từ Session
            //    var member = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("Member"));
            //    ViewBag.Customer = new { Name = member.Name }; // Đặt thông tin vào ViewBag
            //}

            //if (HttpContext.Session.GetString("Member") != null)
            //{
            //    var dataLogin = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("Member"));
            //    ViewBag.Customer = dataLogin;
            //}

            float total = 0;
            foreach (var item in carts)
            {
                total += item.Quantity * item.Price;
            }
            ViewBag.total = total;  //tổng tiền của đơn hàng
            return View(carts);
        }


        /// <summary>
        /// Code cho chức năng thêm sản phẩm vào giỏ hàng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Add(int id)
        {
            if (carts.Any(c => c.Id == id))  //nếu sp này đã có trong giỏ hàng
            {
                carts.Where(c => c.Id == id).First().Quantity += 1; //tăng số lượng
            }
            else //nếu sp chưa có trong giỏ hàng, thêm sản phẩm vào giỏ hàng
            {
                var p = _context.Products.Find(id); //tìm sp cần mua trong bảng sản phẩm
                //tạo mới một sp để thêm vào giỏ hàng
                var item = new Cart()
                {
                    Id = p.Id,
                    Name = p.Title,
                    Price = (float)p.PriceNew.Value,
                    Quantity = 1,
                    Image = p.Image,
                    Total = (float)p.PriceNew.Value * 1
                };
                //thêm sp vào giỏ hàng
                carts.Add(item);
            }
            //lưu carts vào session, cần chuyển sang dữ liệu json
            HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));
            return RedirectToAction("Index");
        }


        /// <summary>
        /// Code cho chức năng xoá sản phẩm vào giỏ hàng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Remove(int id)
        {
            if (carts.Any(c => c.Id == id))
            {
                //tìm sản phẩm trong giỏ hàng
                var item = carts.Where(c => c.Id == id).First();
                //thực hiện xoá
                carts.Remove(item);
                //lưu carts vào session, cần phải chuyển sang dữ liệu json
                HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));
            }

            return RedirectToAction("Index");
        }


        /// <summary>
        /// Code cho chức năng cập nhật dữ liệu trong giỏ hàng
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public IActionResult Update(int id, int quantity)
        {
            if (carts.Any(c => c.Id == id))
            {
                //tìm sản phẩm trong giỏ hàng
                carts.Where(c => c.Id == id).First().Quantity = quantity;
                //lưu carts vào session, cần phải chuyển sang dữ liệu json
                HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));
            }

            return RedirectToAction("Index");
        }


        /// <summary>
        /// Code cho chức xoá hết sp trong giỏ hàng
        /// </summary>
        /// <returns></returns>
        public IActionResult Clear()
        {
            HttpContext.Session.Remove("My-Cart");
            return RedirectToAction("Index");
        }


        /// <summary>
        /// Code logic để hiển thị thông tin giỏ hàng
        /// Dữ liệu giỏ hàng trong session cart
        /// </summary>
        /// <returns></returns>

        //public IActionResult Orders()
        //{
        //    if (HttpContext.Session.GetString("Member") == null)
        //    {
        //        // Chuyển hướng người dùng đến trang đăng nhập nếu chưa đăng nhập
        //        return Redirect("/customermember/login/?url=/cart/orders");
        //    }
        //    else
        //    {

        //    }
        //}// Lấy thông tin người dùng từ session nếu đã đăng nhập
    }
}