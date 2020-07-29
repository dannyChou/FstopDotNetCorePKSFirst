﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.MVC.Helper
{
    public interface IServiceHelper
    {
        /// <summary>
        /// 获取产品数据
        /// </summary>
        /// <returns></returns>
        Task<string> GetProduct();

        /// <summary>
        /// 获取订单数据
        /// </summary>
        /// <returns></returns>
        Task<string> GetOrder();

        /// <summary>
        /// 取得服務清單
        /// </summary>
        void GetServices();
    }
}
