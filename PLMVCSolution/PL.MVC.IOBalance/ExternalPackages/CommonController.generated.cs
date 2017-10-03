// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace PL.MVC.IOBalance.Controllers
{
    public partial class CommonController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CommonController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult GetProductByCategoryId()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetProductByCategoryId);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult GetProductByBranchId()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetProductByBranchId);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CommonController Actions { get { return IOBALANCEMVC.Common; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Common";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Common";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string GetIsActive = "GetIsActive";
            public readonly string GetUnit = "GetUnit";
            public readonly string GetCategory = "GetCategory";
            public readonly string GetModel = "GetModel";
            public readonly string GetSupplier = "GetSupplier";
            public readonly string GetCustomer = "GetCustomer";
            public readonly string GetProduct = "GetProduct";
            public readonly string GetProductByCategoryId = "GetProductByCategoryId";
            public readonly string GetProductByBranchId = "GetProductByBranchId";
            public readonly string GetUserType = "GetUserType";
            public readonly string GetBranch = "GetBranch";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string GetIsActive = "GetIsActive";
            public const string GetUnit = "GetUnit";
            public const string GetCategory = "GetCategory";
            public const string GetModel = "GetModel";
            public const string GetSupplier = "GetSupplier";
            public const string GetCustomer = "GetCustomer";
            public const string GetProduct = "GetProduct";
            public const string GetProductByCategoryId = "GetProductByCategoryId";
            public const string GetProductByBranchId = "GetProductByBranchId";
            public const string GetUserType = "GetUserType";
            public const string GetBranch = "GetBranch";
        }


        static readonly ActionParamsClass_GetProductByCategoryId s_params_GetProductByCategoryId = new ActionParamsClass_GetProductByCategoryId();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetProductByCategoryId GetProductByCategoryIdParams { get { return s_params_GetProductByCategoryId; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetProductByCategoryId
        {
            public readonly string categoryId = "categoryId";
        }
        static readonly ActionParamsClass_GetProductByBranchId s_params_GetProductByBranchId = new ActionParamsClass_GetProductByBranchId();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetProductByBranchId GetProductByBranchIdParams { get { return s_params_GetProductByBranchId; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetProductByBranchId
        {
            public readonly string branchId = "branchId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_CommonController : PL.MVC.IOBalance.Controllers.CommonController
    {
        public T4MVC_CommonController() : base(Dummy.Instance) { }

        [NonAction]
        partial void GetIsActiveOverride(T4MVC_System_Web_Mvc_JsonResult callInfo);

        [NonAction]
        public override System.Web.Mvc.JsonResult GetIsActive()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetIsActive);
            GetIsActiveOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetUnitOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetUnit()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetUnit);
            GetUnitOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetCategoryOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetCategory()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetCategory);
            GetCategoryOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetModelOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetModel()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetModel);
            GetModelOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetSupplierOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetSupplier()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetSupplier);
            GetSupplierOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetCustomerOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetCustomer()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetCustomer);
            GetCustomerOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetProductOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetProduct()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetProduct);
            GetProductOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetProductByCategoryIdOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int categoryId);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetProductByCategoryId(int categoryId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetProductByCategoryId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "categoryId", categoryId);
            GetProductByCategoryIdOverride(callInfo, categoryId);
            return callInfo;
        }

        [NonAction]
        partial void GetProductByBranchIdOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int branchId);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetProductByBranchId(int branchId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetProductByBranchId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "branchId", branchId);
            GetProductByBranchIdOverride(callInfo, branchId);
            return callInfo;
        }

        [NonAction]
        partial void GetUserTypeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetUserType()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetUserType);
            GetUserTypeOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GetBranchOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GetBranch()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GetBranch);
            GetBranchOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
