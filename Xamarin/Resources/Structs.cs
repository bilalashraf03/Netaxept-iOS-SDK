﻿//
//  MIT License
//
//  Copyright (c) 2019 Nets Denmark A/S
//
//  Permission is hereby granted, free of charge, to any person obtaining a
//  copy of this software and associated documentation files (the "Software"),
//  to deal in the Software without restriction, including without limitation
//  the rights to use, copy, modify, merge, publish, distribute, sublicense,
//  and/or sell copies of the Software, and to permit persons to whom the
//  Software is furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be
//  included in all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
//  OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//  ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//  OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using ObjCRuntime;

namespace XamarinPia
{
    public enum SchemeType : uint
    {
        Visa = 0,
        MasterCard,
        Amex,
        DinersClubInternational,
        Dankort,
        Jcb,
        Maestro,
        Other
    }

    [Native]
    public enum NPIErrorCode : long
    {
        GenericError = 300,
        TerminalValidationError = 301,
        RequestFailed = 101,
        ThreeDSecureError = 102,
        ThreeDSecureNavigationError = 103,
        InvalidCardNumber = 14,
        TransactionNotFound = 25,
        KidInvalid = 30,
        OriginalTransactionRejected = 84,
        TransactionAlreadyReversed = 86,
        InternalFailure = 96,
        NoTransaction = 97,
        TransactionAlreadyProcessed = 98,
        UnknownError = 99,
        DeniedBy3DS = 900,
        MerchantTimeout = 901,
        WalletAppNotInstalled = 303,
        WalletURLInvalid = 304,
        WalletRedirectURLUnknown = 305,
        VippsErrorStatusCode = 302
    }

    public enum PiALanguage
    {
        Unassigned = -1,
        English = 0,
        Swedish,
        Danish,
        Norwegian,
        Finnish
    }
}
