using System.Collections.Generic;
using System.Linq;
using Web_953502_Strelets.Entities;

namespace Web_953502_Strelets.Models
{
    public class Cart
    {
        public Dictionary<int, CartItem> Items { get; set; }

        public Cart() => this.Items = new Dictionary<int, CartItem>();

        public int Count => Items.Sum(item => item.Value.Quantity);

        public virtual void AddToCart(Car car)
        {
            if (Items.ContainsKey(car.CarId))
            {
                Items[car.CarId].Quantity++;
            }
            else
            {
                Items.Add(car.CarId, new CartItem
                {
                    Car = car,
                    Quantity = 1,
                });
            }
        }

        public virtual void RemoveFromCart(int id) => Items.Remove(id);

        public virtual void ClearAll() => Items.Clear();
    }
}
