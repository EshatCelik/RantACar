using Entity.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ValidationRoles.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(c => c.Price).LessThanOrEqualTo(10).When(c => c.BrandID == 1);
            RuleFor(c => c.CarName).Must(StartWithA).WithMessage("ürünler A harfi ile başlamalı");//A ile başlamalı
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
