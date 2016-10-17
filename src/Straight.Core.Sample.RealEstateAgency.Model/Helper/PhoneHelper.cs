﻿using System.Text.RegularExpressions;
using Straight.Core.Extensions.Guard;

namespace Straight.Core.Sample.RealEstateAgency.Model.Helper
{
    public static class PhoneHelper
    {
        private static readonly Regex PhoneRegex = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");

        public static void CheckMandatory(string phone, string countryCode)
        {
            phone.CheckIfArgumentIsNullOrEmpty("Phone");
            countryCode.CheckIfArgumentIsNullOrEmpty("CountryCode");
            PhoneRegex.CheckRegexValidity(phone, "Phone");
        }
    }
}