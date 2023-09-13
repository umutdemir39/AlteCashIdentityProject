using AlteCashIdentityProject.DtoLayer.Dtos.AppUsersDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlteCashIdentityProject.BusinessLayer.Validationrules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş bırakılamaz!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş bırakılamaz!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş bırakılamaz!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş bırakılamaz!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("En fazla 30 karakter girebilirsiniz!");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("En az 2 karakter girebilirsiniz!");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolanız eşleşmemektedir!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz!");
        }
    }
}
