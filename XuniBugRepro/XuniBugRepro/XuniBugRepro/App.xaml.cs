using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XuniBugRepro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Xuni LicenseKey
            Xuni.Forms.Core.LicenseManager.Key = License.Key;

            MainPage = new XuniBugRepro.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }


    public static class License
    {
        public const string Key =
            "ACABIAIgB4hYAHUAbgBpAEIAdQBnAFIAZQBwAHIAbwCRmIUPs2UdfdGxHhwAoF2u" +
            "XrHzqsyY/T8EYK9kLesHpkhFC8XhjqyfHhA9VoBzab9w077grHgwDrudohNArCgD" +
            "THWxktj4pK02AJBRg/+wmLkPfq4IabcRlns879P+e68ierapXbo5iveb9c6od6QH" +
            "bdfDLrQtN7gaLLIb0e9GkzcQV12hwcG2hXlMzrXc2xdsMmiEUXqd6WjyWD+y5YX0" +
            "31W6wM6/e18dmUUkD4ekn8bF6Z/KwTpo0rm84i2y5mhuy5HXKDfMGEiFDp45S0yY" +
            "mTwJ6AmBq4JhRNNSXNUCJuyU9jIFXimhNr4wTBQQ5GcctC76WH1r8PfOAOR0cXcM" +
            "PAndW86YfP6SdFIURuIIWzcRLt2jVUr/RAOLmP1xlJIYA1TCbrquCjdT+3BTsA6C" +
            "8kU2//suilodZHXWhpR3E3AoY6gEnUcEJs784ClyIrwqjpyrsjr6ovA6zW51xkmJ" +
            "4hKbO8euaAPE8/XmL/Y+FlrJvHeJaYrj/IxKms+/UTL/2ggDGf+jtk24Pu/baXb4" +
            "7SvzZ9Qq+kwdnj8nPumw50QnmMBqHMOEZKk4O6sAPHf7AtBEPXYqTWwXbRX3XVLk" +
            "f1g3WNxaeJ2lqwRPdtP12KL8i77mYqHlVE6HwxbTxZGTZ8dIYZoIrx7CVpF1Rn43" +
            "tfZQgFE2Mubbyc+qH62x2TCCBWQwggRMoAMCAQICECIQshdLCxJ/uygFLhGzJQow" +
            "DQYJKoZIhvcNAQEFBQAwgbQxCzAJBgNVBAYTAlVTMRcwFQYDVQQKEw5WZXJpU2ln" +
            "biwgSW5jLjEfMB0GA1UECxMWVmVyaVNpZ24gVHJ1c3QgTmV0d29yazE7MDkGA1UE" +
            "CxMyVGVybXMgb2YgdXNlIGF0IGh0dHBzOi8vd3d3LnZlcmlzaWduLmNvbS9ycGEg" +
            "KGMpMTAxLjAsBgNVBAMTJVZlcmlTaWduIENsYXNzIDMgQ29kZSBTaWduaW5nIDIw" +
            "MTAgQ0EwHhcNMTMwOTI0MDAwMDAwWhcNMTYxMDIzMjM1OTU5WjCBpzELMAkGA1UE" +
            "BhMCVVMxFTATBgNVBAgTDFBlbm5zeWx2YW5pYTETMBEGA1UEBxMKUGl0dHNidXJn" +
            "aDEVMBMGA1UEChQMQ29tcG9uZW50T25lMT4wPAYDVQQLEzVEaWdpdGFsIElEIENs" +
            "YXNzIDMgLSBNaWNyb3NvZnQgU29mdHdhcmUgVmFsaWRhdGlvbiB2MjEVMBMGA1UE" +
            "AxQMQ29tcG9uZW50T25lMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA" +
            "ucugmqlJVWqckvNrTmVMhxqRy/KXt3EHFn5zCTgKqTr5RoLp/lnku9EPX4CGIBG6" +
            "UiAju8+CQJ/5zzeI5WJBbIm5cUkycZq9rcBnpf+jQNpSrNjMU5bP8ysDM4m9gy2u" +
            "P81P2bwFZ6L5SRjU1ZTK2JJrQkg1i3nmL8XO3Fe0/srbsuPdljDBSQ0s4onh/6qR" +
            "HRBKfKBhRBDIwM4uDm99iQMt1RCQ2t60FPYlnrHp2Q1wKmJ/l1tnTUw4UQSNkmUZ" +
            "2e+t6e45h/DkI2WgNIJHO21Inz0m0k6NDHKsFB/XKU5eiJcI+nMBcJTZIX91hdKK" +
            "ZUzylPQ1nulQ0bUf4DPacwIDAQABo4IBezCCAXcwCQYDVR0TBAIwADAOBgNVHQ8B" +
            "Af8EBAMCB4AwQAYDVR0fBDkwNzA1oDOgMYYvaHR0cDovL2NzYzMtMjAxMC1jcmwu" +
            "dmVyaXNpZ24uY29tL0NTQzMtMjAxMC5jcmwwRAYDVR0gBD0wOzA5BgtghkgBhvhF" +
            "AQcXAzAqMCgGCCsGAQUFBwIBFhxodHRwczovL3d3dy52ZXJpc2lnbi5jb20vcnBh" +
            "MBMGA1UdJQQMMAoGCCsGAQUFBwMDMHEGCCsGAQUFBwEBBGUwYzAkBggrBgEFBQcw" +
            "AYYYaHR0cDovL29jc3AudmVyaXNpZ24uY29tMDsGCCsGAQUFBzAChi9odHRwOi8v" +
            "Y3NjMy0yMDEwLWFpYS52ZXJpc2lnbi5jb20vQ1NDMy0yMDEwLmNlcjAfBgNVHSME" +
            "GDAWgBTPmanqeyb0S8mOj9fwBSbv49KnnTARBglghkgBhvhCAQEEBAMCBBAwFgYK" +
            "KwYBBAGCNwIBGwQIMAYBAQABAf8wDQYJKoZIhvcNAQEFBQADggEBAGHNVjnOPBgA" +
            "WOYhrYlJZup5dDWOt/ajkOhFhaAj/7gsSkn5Taj5UAjmQhhI0anliOrte9CiyOz8" +
            "Lqp3Cl9N3duHaUQRHhcJHOmj7gcr1bHCPQPw/VShSfjcuOVswH8bNFGE2rQE34RO" +
            "UPT4F6OymhSyx3kZGEYs05ea0NX739ruPuH23kkQyT74luXKxV7pSlyC2hj1eC5k" +
            "uybkM6FBPRAiWA4grVBKX/CGIoZ08F8PmM3j9IewZVRs+kL4/GOHnJP8tKb342qT" +
            "63MxBByltN94sqz2QuCwbhSj1+yDnA6XgU3gIEejYItcSq2uLLf/+ulQw661Uqab" +
            "VrAeGAaqy4UwggLGMIIBrqADAgECAgQP////MA0GCSqGSIb3DQEBBQUAMCUxIzAh" +
            "BgNVBAMMGkdDLVh1bmkgRXZhbHVhdGUgRGV2ZWxvcGVyMB4XDTE3MDIwMTAwMDAw" +
            "MFoXDTE3MDMwMzAwMDAwMFowJTEjMCEGA1UEAwwaR0MtWHVuaSBFdmFsdWF0ZSBE" +
            "ZXZlbG9wZXIwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQCov19p5eSZ" +
            "I7fCh1aSkfckfFCtnrR3gppOkeEvaQrdPArndvd5noXcZueEXxiDvH2Odo2Jk7kr" +
            "6uQp+VIeJyJSZBhUss2cGYJG8MAtuUvq/DHP7Tr0qfBgcTO1x+vxH2RGFCFwXbbv" +
            "pAjXkE318W488UwKRM2T44a6WbgZbg/LYA7bPMRR3cHfVUjG0vzt71Q3EzwnLDzS" +
            "NCpOVTj7yLH6sT/czc0zBn1NFw0PWApGiJ3cZdh4O+fiHkaqhJpq4TLjffpN7VWf" +
            "0WdwY3ObFKcS57jZPSbD3KAYo2SHxZSNnSEoVv5RfQQ8/Oj8TLgEvcZWWvOpMiAL" +
            "YF83cvzd/OjBAgMBAAEwDQYJKoZIhvcNAQEFBQADggEBAIQ1jYoSEutlWc+BwIEk" +
            "UyefSq5qBLhCZZAaY8qxKmf30LgZtlEcUjI7p4FWKOacD+5DMHunAPhH5mj515sY" +
            "vTEyIvoLZicFBrAqhH35PNX1C4LN8+oCszf9hd1CjBb2sMaVb5nDEu+RKIcKTY/Q" +
            "9CijxcBsRedtcJB836wWrSmu6wApOX9j+7GWlRGTnmgUeFpeNVkw7nw2JUSWnqYm" +
            "L3A1ImEEcx9zqlFxcFhzPt1yeF1EognrQg8q4CUK+jl4yyHtaFRATgR8Uxj2XjaU" +
            "N5hvfSLJB1zN9IYT6s0KWSg1B6t1YWB+MJYaIqbmh/FoeDd+wNo5X3f0OyNIzChE" +
            "APE=";
    }
}
