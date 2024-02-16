﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamdad.Framework.core.Enums;
public enum ApiResponseStatusCode
{
    [Display(Name = "عملیات با موفقیت انجام شد")]
    Success = 0,

    [Display(Name = "خطایی در سرور رخ داده است")]
    ServerError = 1,

    [Display(Name = "پارامتر های ارسالی معتبر نیستند")]
    BadRequest = 2,

    [Display(Name = "یافت نشد")]
    NotFound = 3,

    [Display(Name = "لیست خالی است")]
    ListEmpty = 4,

    [Display(Name = "خطایی در پردازش رخ داد")]
    LogicError = 5,

    [Display(Name = "خطای احراز هویت")]
    UnAuthorized = 6,

    [Display(Name = "غیر مجاز")]
    Forbidden = 7,

    [Display(Name = "مقدار پوچ")]
    NullValue = 8,

    [Display(Name = "خطایی در ارتباطات داخلی رخ داده است")]
    ApiCallError = 9,
}
