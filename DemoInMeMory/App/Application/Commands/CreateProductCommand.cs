using App.Dto;
using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace App.Application.Commands
{
    public class CreateProductCommand : IRequest<ProductDto>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public CreateProductCommand(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
