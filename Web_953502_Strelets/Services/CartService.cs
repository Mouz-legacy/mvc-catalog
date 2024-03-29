﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using Web_953502_Strelets.Entities;
using Web_953502_Strelets.Extensions;
using Web_953502_Strelets.Models;

namespace Web_953502_Strelets.Services
{
    public class CartService : Cart
    {
        private string sessionKey = "cart";

        [JsonIgnore]
        ISession Session { get; set; }

        public static Cart GetCart(IServiceProvider sp)
        {
            var session = sp
                .GetRequiredService<IHttpContextAccessor>()
                .HttpContext
                .Session;

            var cart = session?.Get<CartService>("cart")
                       ?? new CartService();
            cart.Session = session;
            return cart;
        }

        public override void AddToCart(Car car)
        {
            base.AddToCart(car);
            Session?.Set<CartService>(sessionKey, this);
        }
        public override void RemoveFromCart(int id)
        {
            base.RemoveFromCart(id);
            Session?.Set<CartService>(sessionKey, this);
        }
        public override void ClearAll()
        {
            base.ClearAll();
            Session?.Set<CartService>(sessionKey, this);
        }
    }
}
