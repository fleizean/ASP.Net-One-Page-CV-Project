using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRule
{
	public class PortfolioValidator : AbstractValidator<Portfolio>
	{
		public PortfolioValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez.");
			RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel kısmı boş geçilemez.");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel kısmı boş geçilemez.");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Proje Url kısmı boş geçilemez.");
            RuleFor(x => x.Platform).NotEmpty().WithMessage("Platform kısmı boş geçilemez.");
			RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adı en az 5 karakterden oluşmak zorundadır.");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje adı en fazla 100 karakterden oluşmak zorundadır.");
        }
	}
}

