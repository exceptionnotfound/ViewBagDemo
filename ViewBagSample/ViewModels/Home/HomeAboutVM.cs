using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewBagSample.Models;

namespace ViewBagSample.ViewModels.Home
{
    public class HomeAboutVM
    {
        public User CurrentUser { get; set; }
        public DateTime PageCreateDate { get; set; }
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
    }
}