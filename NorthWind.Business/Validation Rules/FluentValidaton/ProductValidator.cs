using FluentValidation;
using NorthWind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Business.Validation_Rules.FluentValidaton
{
    public class ProductValidator:AbstractValidator<Products>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Urun ismi boş olamaz");
            RuleFor(p => p.CategoryID).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p=>p.UnitPrice==2);

            RuleFor(p => p.ProductName).Must(StartsWithE).WithMessage("ürün e ile başlamalı");
        }

        private bool StartsWithE(string arg)
        {
            return arg.StartsWith("E");
        }
    }
}
