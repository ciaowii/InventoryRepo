﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.MVC.IOBalanceV2.Infrastructure
{
    public class Alert
    {
        public const string TempDataKey = "TempDataAlerts";
        public const string TempDataDisplay = "AlertsDisplayFirstOnly";
        public const string TempDataCreateDate = "TempDataCreateDate";

        public AlertTypes AlertStyle { get; set; }
        public List<string> Messages { get; set; }
        public bool Dismissable { get; set; }
    }

    public enum AlertTypes
    {
        Success,
        Information,
        Warning,
        Danger
    }
}