﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using AshShop.DAL.GetWay;
using AshShop.DAL.Model;

namespace AshShop.BLL
{
   
    public class OrderDetailsManager
    {
        OrderDetailsGetWay aOrderDetailsGetWay=new OrderDetailsGetWay();
        public int InsertOrderDetails(Product aProduct)
        {
            int InsertOrderDetailsresult;
            InsertOrderDetailsresult=aOrderDetailsGetWay.InsertOrderDetails(aProduct);
            return InsertOrderDetailsresult;
        }
        public List<OrderDetails> GetAllOrderDetails(int id)
        {
            List<OrderDetails> aOrderDetailList = aOrderDetailsGetWay.GetAllOrderDetails(id);
            return aOrderDetailList;
        }
    }
}