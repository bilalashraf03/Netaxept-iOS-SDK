﻿using System;
using Contacts;
using Foundation;
using ObjCRuntime;
using PassKit;
using UIKit;

namespace XamarinPia
{
    // @interface NPIMerchantInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface NPIMerchantInfo
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull identifier;
        [Export("identifier", ArgumentSemantic.Strong)]
        string Identifier { get; }

        // @property (readonly, nonatomic) BOOL testMode;
        [Export("testMode")]
        bool TestMode { get; }

        // @property (readonly, nonatomic) BOOL cvcRequired;
        [Export("cvcRequired")]
        bool CvcRequired { get; }

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier;
        [Export("initWithIdentifier:")]
        IntPtr Constructor(string identifier);

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier testMode:(BOOL)testMode;
        [Export("initWithIdentifier:testMode:")]
        IntPtr Constructor(string identifier, bool testMode);

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier testMode:(BOOL)testMode cvcRequired:(BOOL)cvcRequired;
        [Export("initWithIdentifier:testMode:cvcRequired:")]
        IntPtr Constructor(string identifier, bool testMode, bool cvcRequired);
    }

    // @interface NPIOrderInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface NPIOrderInfo
    {
        // @property (readonly, nonatomic, strong) NSNumber * _Nonnull amount;
        [Export("amount", ArgumentSemantic.Strong)]
        NSNumber Amount { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull currencyCode;
        [Export("currencyCode", ArgumentSemantic.Strong)]
        string CurrencyCode { get; }

        // -(instancetype _Nonnull)initWithAmount:(NSNumber * _Nonnull)amount currencyCode:(NSString * _Nonnull)currencyCode;
        [Export("initWithAmount:currencyCode:")]
        IntPtr Constructor(NSNumber amount, string currencyCode);
    }

    // @interface NPITransactionInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface NPITransactionInfo
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull transactionID;
        [Export("transactionID", ArgumentSemantic.Strong)]
        string TransactionID { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull okRedirectUrl;
        [Export("okRedirectUrl", ArgumentSemantic.Strong)]
        string OkRedirectUrl { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull cancelRedirectUrl;
        [Export("cancelRedirectUrl", ArgumentSemantic.Strong)]
        string CancelRedirectUrl { get; }

        // -(instancetype _Nonnull)initWithTransactionID:(NSString * _Nonnull)transactionId okRedirectUrl:(NSString * _Nonnull)okRedirectUrl cancelRedirectUrl:(NSString * _Nonnull)cancelRedirectUrl;
        [Export("initWithTransactionID:okRedirectUrl:cancelRedirectUrl:")]
        IntPtr Constructor(string transactionId, string okRedirectUrl, string cancelRedirectUrl);
    }

    // @interface NPITokenCardInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface NPITokenCardInfo
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull tokenId;
        [Export("tokenId", ArgumentSemantic.Strong)]
        string TokenId { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull expiryDate;
        [Export("expiryDate", ArgumentSemantic.Strong)]
        string ExpiryDate { get; }

        // @property (assign, nonatomic) BOOL cvcRequired;
        [Export("cvcRequired")]
        bool CvcRequired { get; set; }

        // @property (assign, nonatomic) BOOL systemAuthenticationRequired;
        [Export("systemAuthenticationRequired")]
        bool SystemAuthenticationRequired { get; set; }

        // @property (nonatomic) SchemeType schemeType;
        [Export("schemeType", ArgumentSemantic.Assign)]
        SchemeType SchemeType { get; set; }

        // -(instancetype _Nonnull)initWithTokenId:(NSString * _Nonnull)tokenId schemeType:(SchemeType)schemeType expiryDate:(NSString * _Nonnull)expiryDate cvcRequired:(BOOL)cvcRequired systemAuthenticationRequired:(BOOL)systemAuthenticationRequired;
        [Export("initWithTokenId:schemeType:expiryDate:cvcRequired:systemAuthenticationRequired:")]
        IntPtr Constructor(string tokenId, SchemeType schemeType, string expiryDate, bool cvcRequired, bool systemAuthenticationRequired);
    }

    // @interface NPIError : NSObject
    [BaseType(typeof(NSObject))]
    interface NPIError
    {
        // @property (readonly, copy) NSString * _Nonnull localizedDescription;
        [Export("localizedDescription")]
        string LocalizedDescription { get; }

        // -(instancetype _Nonnull)initWithCode:(NSString *)code;
        [Export("initWithCode:")]
        IntPtr Constructor(string code);

        // -(instancetype _Nonnull)initWithCode:(NSString *)code userInfo:(NSDictionary<NSErrorUserInfoKey,id> * _Nonnull)info __attribute__((objc_designated_initializer));
        [Export("initWithCode:userInfo:")]
        [DesignatedInitializer]
        IntPtr Constructor(string code, NSDictionary<NSString, NSObject> info);

        // -(NPIErrorCode)code;
        [Export("code")]
        NPIErrorCode Code { get; }
    }

    // @interface NPIApplePayShippingInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface NPIApplePayShippingInfo
    {
        // @property (readonly, nonatomic, strong) NSPersonNameComponents * _Nonnull fullName;
        [Export("fullName", ArgumentSemantic.Strong)]
        NSPersonNameComponents FullName { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull email;
        [Export("email", ArgumentSemantic.Strong)]
        string Email { get; }

        // @property (readonly, nonatomic, strong) CNPhoneNumber * _Nonnull phoneNumber;
        [Export("phoneNumber", ArgumentSemantic.Strong)]
        CNPhoneNumber PhoneNumber { get; }

        // @property (readonly, nonatomic, strong) CNPostalAddress * _Nonnull shippingAddress;
        [Export("shippingAddress", ArgumentSemantic.Strong)]
        CNPostalAddress ShippingAddress { get; }

        // -(instancetype _Nonnull)initWithShippingAddress:(CNPostalAddress * _Nonnull)shippingAddress fullName:(NSPersonNameComponents * _Nonnull)fullName email:(NSString * _Nonnull)email phoneNumber:(CNPhoneNumber * _Nonnull)phoneNumber;
        [Export("initWithShippingAddress:fullName:email:phoneNumber:")]
        IntPtr Constructor(CNPostalAddress shippingAddress, NSPersonNameComponents fullName, string email, CNPhoneNumber phoneNumber);
    }

    // @interface NPIApplePayInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface NPIApplePayInfo
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull currencyCode;
        [Export("currencyCode", ArgumentSemantic.Strong)]
        string CurrencyCode { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull applePayMerchantID;
        [Export("applePayMerchantID", ArgumentSemantic.Strong)]
        string ApplePayMerchantID { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull applePayItemDisplayName;
        [Export("applePayItemDisplayName", ArgumentSemantic.Strong)]
        string ApplePayItemDisplayName { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull applePayMerchantDisplayName;
        [Export("applePayMerchantDisplayName", ArgumentSemantic.Strong)]
        string ApplePayMerchantDisplayName { get; }

        // @property (readonly, nonatomic, strong) NSDecimalNumber * _Nonnull applePayItemCost;
        [Export("applePayItemCost", ArgumentSemantic.Strong)]
        NSDecimalNumber ApplePayItemCost { get; }

        // @property (readonly, nonatomic, strong) NSDecimalNumber * _Nonnull applePayItemShippingCost;
        [Export("applePayItemShippingCost", ArgumentSemantic.Strong)]
        NSDecimalNumber ApplePayItemShippingCost { get; }

        // @property (readonly, nonatomic, strong) NPIApplePayShippingInfo * _Nullable applePayShippingInfo;
        [NullAllowed, Export("applePayShippingInfo", ArgumentSemantic.Strong)]
        NPIApplePayShippingInfo ApplePayShippingInfo { get; }

        // @property (assign, nonatomic) BOOL usingExpressCheckout;
        [Export("usingExpressCheckout")]
        bool UsingExpressCheckout { get; set; }

        // -(instancetype _Nonnull)initWithApplePayMerchantID:(NSString * _Nonnull)applePayMerchantID applePayItemDisplayName:(NSString * _Nonnull)applePayItemDisplayName applePayMerchantDisplayName:(NSString * _Nonnull)applePayMerchantDisplayName applePayItemCost:(NSDecimalNumber * _Nonnull)applePayItemCost applePayItemShippingCost:(NSDecimalNumber * _Nonnull)applePayItemShippingCost currencyCode:(NSString * _Nonnull)currencyCode applePayShippingInfo:(NPIApplePayShippingInfo * _Nullable)applePayShippingInfo usingExpressCheckout:(BOOL)usingExpressCheckout;
        [Export("initWithApplePayMerchantID:applePayItemDisplayName:applePayMerchantDisplayName:applePayItemCost:applePayItemShippingCost:currencyCode:applePayShippingInfo:usingExpressCheckout:")]
        IntPtr Constructor(string applePayMerchantID, string applePayItemDisplayName, string applePayMerchantDisplayName, NSDecimalNumber applePayItemCost, NSDecimalNumber applePayItemShippingCost, string currencyCode, [NullAllowed] NPIApplePayShippingInfo applePayShippingInfo, bool usingExpressCheckout);
    }

    // @protocol PiaSDKDelegate <UINavigationControllerDelegate>
    [BaseType(typeof(NSObject))]
    [Model]
    interface PiaSDKDelegate : IUINavigationControllerDelegate
    {
        // @required -(void)doInitialAPICall:(PiaSDKController * _Nonnull)PiaSDKController storeCard:(BOOL)storeCard withCompletion:(void (^ _Nonnull)(NPITransactionInfo * _Nullable))completionHandler;
        [Abstract]
        [Export("doInitialAPICall:storeCard:withCompletion:")]
        void DoInitialAPICall(PiaSDKController PiaSDKController, bool storeCard, Action<NPITransactionInfo> completionHandler);

        // @required -(void)registerPaymentWithApplePayData:(PiaSDKController * _Nonnull)PiaSDKController paymentData:(PKPaymentToken * _Nonnull)paymentData newShippingContact:(PKContact * _Nullable)newShippingContact withCompletion:(void (^ _Nonnull)(NPITransactionInfo * _Nullable))completionHandler;
        [Abstract]
        [Export("registerPaymentWithApplePayData:paymentData:newShippingContact:withCompletion:")]
        void RegisterPaymentWithApplePayData(PiaSDKController PiaSDKController, PKPaymentToken paymentData, [NullAllowed] PKContact newShippingContact, Action<NPITransactionInfo> completionHandler);

        // @required -(void)registerPaymentWithPayPal:(PiaSDKController * _Nonnull)PiaSDKController withCompletion:(void (^ _Nonnull)(NPITransactionInfo * _Nullable))completionHandler;
        [Abstract]
        [Export("registerPaymentWithPayPal:withCompletion:")]
        void RegisterPaymentWithPayPal(PiaSDKController PiaSDKController, Action<NPITransactionInfo> completionHandler);

        // @required -(void)PiaSDK:(PiaSDKController * _Nonnull)PiaSDKController didFailWithError:(NPIError * _Nonnull)error;
        [Abstract]
        [Export("PiaSDK:didFailWithError:")]
        void PiaSDK(PiaSDKController PiaSDKController, NPIError error);

        // @required -(void)PiaSDKDidCompleteWithSuccess:(PiaSDKController * _Nonnull)PiaSDKController;
        [Abstract]
        [Export("PiaSDKDidCompleteWithSuccess:")]
        void PiaSDKDidCompleteWithSuccess(PiaSDKController PiaSDKController);

        // @required -(void)PiaSDKDidCompleteSaveCardWithSuccess:(PiaSDKController * _Nonnull)PiaSDKController;
        [Abstract]
        [Export("PiaSDKDidCompleteSaveCardWithSuccess:")]
        void PiaSDKDidCompleteSaveCardWithSuccess(PiaSDKController PiaSDKController);

        // @required -(void)PiaSDKDidCancel:(PiaSDKController * _Nonnull)PiaSDKController;
        [Abstract]
        [Export("PiaSDKDidCancel:")]
        void PiaSDKDidCancel(PiaSDKController PiaSDKController);

        // @optional -(void)PiaSDK:(PiaSDKController * _Nonnull)PiaSDKController didChangeApplePayShippingContact:(PKContact * _Nonnull)contact withCompletion:(void (^ _Nonnull)(BOOL, NSDecimalNumber * _Nullable))completionHandler;
        [Export("PiaSDK:didChangeApplePayShippingContact:withCompletion:")]
        void PiaSDK(PiaSDKController PiaSDKController, PKContact contact, Action<bool, NSDecimalNumber> completionHandler);
    }

    // @interface PiaSDKController : UINavigationController
    [BaseType(typeof(UINavigationController))]
    interface PiaSDKController
    {
        [Wrap("WeakPiaDelegate")]
        [NullAllowed]
        PiaSDKDelegate PiaDelegate { get; set; }

        // @property (nonatomic, weak) id<PiaSDKDelegate> _Nullable PiaDelegate;
        [NullAllowed, Export("PiaDelegate", ArgumentSemantic.Weak)]
        NSObject WeakPiaDelegate { get; set; }

        // -(instancetype _Nonnull)init:(NPIMerchantInfo * _Nullable)merchantInfo orderInfo:(NPIOrderInfo * _Nullable)orderInfo tokenCardInfo:(NPITokenCardInfo * _Nullable)tokenCardInfo applePayInfo:(NPIApplePayInfo * _Nullable)applePayInfo performingPayPalPurchase:(BOOL)performingPayPalPurchase;
        [Export("init:orderInfo:tokenCardInfo:applePayInfo:performingPayPalPurchase:")]
        IntPtr Constructor([NullAllowed] NPIMerchantInfo merchantInfo, [NullAllowed] NPIOrderInfo orderInfo, [NullAllowed] NPITokenCardInfo tokenCardInfo, [NullAllowed] NPIApplePayInfo applePayInfo, bool performingPayPalPurchase);

        // -(instancetype _Nonnull)initWithMerchantInfo:(NPIMerchantInfo * _Nullable)merchantInfo orderInfo:(NPIOrderInfo * _Nullable)orderInfo tokenCardInfo:(NPITokenCardInfo * _Nullable)tokenCardInfo;
        [Export("initWithMerchantInfo:orderInfo:tokenCardInfo:")]
        IntPtr Constructor([NullAllowed] NPIMerchantInfo merchantInfo, [NullAllowed] NPIOrderInfo orderInfo, [NullAllowed] NPITokenCardInfo tokenCardInfo);

        // -(instancetype _Nonnull)initWithTokenCardInfo:(NPITokenCardInfo * _Nonnull)tokenCardInfo merchantInfo:(NPIMerchantInfo * _Nonnull)merchantInfo orderInfo:(NPIOrderInfo * _Nonnull)orderInfo;
        [Export("initWithTokenCardInfo:merchantInfo:orderInfo:")]
        IntPtr Constructor(NPITokenCardInfo tokenCardInfo, NPIMerchantInfo merchantInfo, NPIOrderInfo orderInfo);

        // -(instancetype _Nonnull)initWithOrderInfo:(NPIOrderInfo * _Nonnull)orderInfo merchantInfo:(NPIMerchantInfo * _Nonnull)merchantInfo;
        [Export("initWithOrderInfo:merchantInfo:")]
        IntPtr Constructor(NPIOrderInfo orderInfo, NPIMerchantInfo merchantInfo);

        // -(instancetype _Nonnull)initWithMerchantInfo:(NPIMerchantInfo * _Nonnull)merchantInfo payWithPayPal:(BOOL)payWithPayPal;
        [Export("initWithMerchantInfo:payWithPayPal:")]
        IntPtr Constructor(NPIMerchantInfo merchantInfo, bool payWithPayPal);

        // -(instancetype _Nonnull)initWithApplePayInfo:(NPIApplePayInfo * _Nonnull)applePayInfo;
        [Export("initWithApplePayInfo:")]
        IntPtr Constructor(NPIApplePayInfo applePayInfo);

        // -(instancetype _Nonnull)initWithMerchantInfo:(NPIMerchantInfo * _Nonnull)merchantInfo;
        [Export("initWithMerchantInfo:")]
        IntPtr Constructor(NPIMerchantInfo merchantInfo);
    }

    // @interface NPIInterfaceConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface NPIInterfaceConfiguration
    {
        // @property (nonatomic, strong) UIColor * barColor;
        [Export("barColor", ArgumentSemantic.Strong)]
        UIColor BarColor { get; set; }

        // @property (nonatomic, strong) UIColor * barTitleColor;
        [Export("barTitleColor", ArgumentSemantic.Strong)]
        UIColor BarTitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * barItemsColor;
        [Export("barItemsColor", ArgumentSemantic.Strong)]
        UIColor BarItemsColor { get; set; }

        // @property (nonatomic, strong) UIColor * backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIFont * buttonFont;
        [Export("buttonFont", ArgumentSemantic.Strong)]
        UIFont ButtonFont { get; set; }

        // @property (nonatomic, strong) UIColor * buttonTextColor;
        [Export("buttonTextColor", ArgumentSemantic.Strong)]
        UIColor ButtonTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * mainButtonBackgroundColor;
        [Export("mainButtonBackgroundColor", ArgumentSemantic.Strong)]
        UIColor MainButtonBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * switchThumbColor;
        [Export("switchThumbColor", ArgumentSemantic.Strong)]
        UIColor SwitchThumbColor { get; set; }

        // @property (nonatomic, strong) UIColor * switchOnTintColor;
        [Export("switchOnTintColor", ArgumentSemantic.Strong)]
        UIColor SwitchOnTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * fieldTextColor;
        [Export("fieldTextColor", ArgumentSemantic.Strong)]
        UIColor FieldTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * fieldFont;
        [Export("fieldFont", ArgumentSemantic.Strong)]
        UIFont FieldFont { get; set; }

        // @property (nonatomic, strong) UIColor * labelTextColor;
        [Export("labelTextColor", ArgumentSemantic.Strong)]
        UIColor LabelTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * errorFieldColor;
        [Export("errorFieldColor", ArgumentSemantic.Strong)]
        UIColor ErrorFieldColor { get; set; }

        // @property (nonatomic, strong) UIColor * successFieldColor;
        [Export("successFieldColor", ArgumentSemantic.Strong)]
        UIColor SuccessFieldColor { get; set; }

        // @property (nonatomic, strong) UIColor * tokenCardCVCViewBackgroundColor;
        [Export("tokenCardCVCViewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TokenCardCVCViewBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIFont * labelFont;
        [Export("labelFont", ArgumentSemantic.Strong)]
        UIFont LabelFont { get; set; }

        // @property (nonatomic, strong) UIImage * logoImage;
        [Export("logoImage", ArgumentSemantic.Strong)]
        UIImage LogoImage { get; set; }

        // @property (readwrite, nonatomic) BOOL saveCardOn;
        [Export("saveCardOn")]
        bool SaveCardOn { get; set; }

        // @property (nonatomic, strong) UIColor * cardIOBackgroundColor;
        [Export("cardIOBackgroundColor", ArgumentSemantic.Strong)]
        UIColor CardIOBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * cardIOButtonTextColor;
        [Export("cardIOButtonTextColor", ArgumentSemantic.Strong)]
        UIColor CardIOButtonTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * cardIOButtonTextFont;
        [Export("cardIOButtonTextFont", ArgumentSemantic.Strong)]
        UIFont CardIOButtonTextFont { get; set; }

        // @property (nonatomic, strong) UIColor * cardIOButtonBackgroundColor;
        [Export("cardIOButtonBackgroundColor", ArgumentSemantic.Strong)]
        UIColor CardIOButtonBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * cardIOPreviewFrameColor;
        [Export("cardIOPreviewFrameColor", ArgumentSemantic.Strong)]
        UIColor CardIOPreviewFrameColor { get; set; }

        // @property (nonatomic, strong) UIColor * cardIOTextColor;
        [Export("cardIOTextColor", ArgumentSemantic.Strong)]
        UIColor CardIOTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * cardIOTextFont;
        [Export("cardIOTextFont", ArgumentSemantic.Strong)]
        UIFont CardIOTextFont { get; set; }

        // @property (readwrite, nonatomic) BOOL disableCardIO;
        [Export("disableCardIO")]
        bool DisableCardIO { get; set; }

        // @property (nonatomic, strong) UIColor *statusBarColor;
        [Export("statusBarColor", ArgumentSemantic.Strong)]
        UIColor StatusBarColor { get; set; }

        // @property (nonatomic, readwrite) BOOL useStatusBarLightContent;
        [Export("useStatusBarLightContent")]
        bool UseStatusBarLightContent { get; set; }

        // +(instancetype)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        NPIInterfaceConfiguration SharedInstance();
    }
}