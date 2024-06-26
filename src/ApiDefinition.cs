﻿// Developed by Softeq Development Corporation
// http://www.softeq.com

using Foundation;
using UIKit;
using ObjCRuntime;
using System;

namespace ToastBindings
{
    delegate void Completion(bool value);

    [BaseType(typeof(UIView))]
    [Category]
    interface Toast
    {
        [Export("makeToast:")]
        void MakeToast(NSString message);

        [Export("makeToast:duration:position:")]
        void MakeToast(NSString message, nfloat duration, NSString position);

        [Export("makeToast:duration:position:title:image:style:completion:")]
        void MakeToast(
            NSString message,
            nfloat duration,
            NSObject position,
            [NullAllowed] NSString title,
            [NullAllowed] UIImage image,
            [NullAllowed] CSToastStyle style,
            [NullAllowed] CompletionDelegate completion);

        [Export("showToast:")]
        void ShowToast(UIView view);

        [Export("showToast:duration:position:completion:")]
        void ShowToast(
            UIView view,
            double duration,
            NSString position,
            [NullAllowed] CompletionDelegate completion);

        [Export("hideToast:")]
        void HideToast(UIView view);

        [Export("hideAllToasts")]
        void HideAllToasts();

        [Export("hideAllToasts:clearQueue:")]
        void HideAllToasts(bool includeActivity, bool clearQueue);

        [Export("clearToastQueue")]
        void ClearToastQueue();
    }

    [BaseType(typeof(NSObject))]
    interface CSToastManager
    {
        [Static]
        [Export("setQueueEnabled:")]
        void SetQueueEnabled(bool value);

        [Static]
        [Export("isQueueEnabled")]
        bool IsQueueEnabled { get; }

        [Static]
        [Export("setSharedStyle:")]
        void SetSharedStyle(CSToastStyle sharedStyle);

        [Static]
        [Export("setTapToDismissEnabled:")]
        void SetTapToDismissEnabled(bool tapToDismissEnabled);

        [Static]
        [Export("defaultPosition")]
        NSString DefaultPosition { get; }

        [Static]
        [Export("defaultDuration")]
        double DefaultDuration { get; }
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface CSToastStyle
    {
        [Export("initWithDefaultStyle")]
        IntPtr Constructor();

        [Export("verticalPadding", ArgumentSemantic.Assign)]
        nfloat VerticalPadding { get; set; }
    }

    delegate void CompletionDelegate(bool didTap);

    [Static]
    interface CSToastPosition
    {
        // NSString *const CSToastPositionTop;
        [Field("CSToastPositionTop", "__Internal")]
        NSString Top { get; }

        // NSString *const CSToastPositionCenter;
        [Field("CSToastPositionCenter", "__Internal")]
        NSString Center { get; }

        // NSString *const CSToastPositionBottom;
        [Field("CSToastPositionBottom", "__Internal")]
        NSString Bottom { get; }
    }
}
