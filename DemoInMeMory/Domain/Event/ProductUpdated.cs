using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Event
{
    public class ProductUpdated : DomainEvent
    {
        public int ProductId { get; }
        public string UpdatedName { get; }
        public decimal UpdatedPrice { get; }

        public ProductUpdated(int productId, string updatedName, decimal updatedPrice)
        {
            ProductId = productId;
            UpdatedName = updatedName;
            UpdatedPrice = updatedPrice;
        }
    }
}
