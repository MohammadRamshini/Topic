using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Application
{
    public static class ApplicationMessages
    {
        public const string SystemFailure = "خطایی رخ داده است لطفا با مدیر سیستم تماس بگیرید";
        public const string OperationSuccess = "عملیات با موفقیت انجام شد";
        public const string DuplicatedRecord = "امکان ثبت رکورد تکراری وجود ندارد. این رکورد قبلا ثبت شده است.";
        public const string EntityNotExists =
            "اطلاعات درخواست شده پیدا نشد. لطفا پس از بروز رسانی صفحه دوباره تلاش کنید";
        public const string DuplicatedSlug = "اسلاگ نمی تواند تکراری باشد";
        public const string EmptyFields = "فیلدهای خالی را پر نمایید";
    }
}
