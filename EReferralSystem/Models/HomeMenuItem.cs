using System;
using System.Collections.Generic;
using System.Text;

namespace EReferralSystem.Models
{
    public enum MenuItemType
    {
        Home,
        Manage,
        Report
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
