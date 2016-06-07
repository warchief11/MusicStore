using MusicStore.Models;
using System.Collections.Generic;

namespace MusicStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal Total { get; set; }
    }
}