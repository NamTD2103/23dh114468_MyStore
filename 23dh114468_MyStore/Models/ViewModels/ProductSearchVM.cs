using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;

namespace _23dh114468_MyStore.Models.ViewModels
{
    public class ProductSearchVM
    {
        //Tiêu chí để search theo tên,mô tả sản hẩm
        public string SearchTerm {  get; set; }
        //Các tiêu chỉ để search theo giá
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        //Thứ tự sắp xếp
        public string SortOrder { get; set; }
        //Các thuộc tính phân trang
        public int PageNumber {  get; set; }
        public int PageSize { get; set; } = 10;
        //Danh sách sản phẩm phân trang
        public PagedList.IPagedList<Product> Products { get; set; }
       // public List<Product> Products { get; set; }
    }
}