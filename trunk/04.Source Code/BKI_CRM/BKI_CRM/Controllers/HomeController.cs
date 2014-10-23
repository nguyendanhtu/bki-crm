using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BKI_CRM.Model;
using BKI_CRM.Models;
using Framework.Extensions;

namespace BKI_CRM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BKI_CRMEntities v_model = new BKI_CRMEntities();
            List<V_GD_KHACH_HANG_CHUYEN_TRANG_THAI> v_lst_khach_hang = v_model.V_GD_KHACH_HANG_CHUYEN_TRANG_THAI.ToList();
            List<KhachHangModel> v_lst_khach_hang_model = new List<KhachHangModel>();
            foreach (var item in v_lst_khach_hang)
            {
                KhachHangModel v_khach_hang_model = item.CopyAs<KhachHangModel>();
                v_khach_hang_model.LstChuyenTrangThai = v_model.V_GD_CHUYEN_TRANG_THAI.Where(x => x.ID_TRANG_THAI_BAN_DAU == item.ID_TRANG_THAI).ToList();
                v_lst_khach_hang_model.Add(v_khach_hang_model);
            }
            ViewBag.khach_hang = v_lst_khach_hang_model;
            LayDanhSachTrangThai();
            return View();
        }

        private void LayDanhSachTrangThai() {
            BKI_CRMEntities v_model = new BKI_CRMEntities();
            Guid v_guid_cty = new Guid("c2a1b448-d15b-4877-a373-2f7ee30c665e");
            List<DM_TRANG_THAI> v_lst_trang_thai = v_model.DM_TRANG_THAI.Where(x => x.ID_CONG_TY == v_guid_cty).OrderBy(x => x.MA_TRANG_THAI).ToList();
            ViewBag.LstTrangThai = v_lst_trang_thai;
        }

        [HttpPost]
        public ActionResult LayThongTinKhachHang(string ip_str_id_khach_hang)
        {
            try
            {
                BKI_CRMEntities v_model = new BKI_CRMEntities();
                DM_KHACH_HANG v_dm_khach_hang = new DM_KHACH_HANG();
                v_dm_khach_hang = v_model.DM_KHACH_HANG.Where(x=>x.ID == new Guid(ip_str_id_khach_hang)).First();
                return Json(v_dm_khach_hang, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception v_e)
            {
                v_e.Log();
                return Json(false);
            }

        }
    }
}
