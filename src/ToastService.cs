// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using UIKit;
using Foundation;
using System.ComponentModel;

namespace ToastBindings;

public static class ToastService
{
    public static void HideToast(UIView view, UIView toast)
    {
        view.HideToast(toast);
    }

    public static void HideAllToasts(UIView view)
    {
        view.HideAllToasts();
    }

    public static void HideAllToasts(UIView view, bool clearQueue)
    {
        view.HideAllToasts(false, clearQueue);
    }

    public static void ClearToastQueue(UIView view)
    {
        view.ClearToastQueue();
    }

    public static void ShowToast(UIView parentView,
                                 UIView toastView,
                                 ToastPosition? toastPosition = null,
                                 double? duration = null,
                                 Action completion = null)
    {
        if (toastPosition == null && duration == null && completion == null)
        {
            parentView.ShowToast(toastView);
        }
        else
        {
            parentView.ShowToast(
                toastView,
                duration ?? CSToastManager.DefaultDuration,
                ToCSToastPosition(toastPosition),
                x => completion?.Invoke());
        }
    }

    private static NSString ToCSToastPosition(ToastPosition? position)
    {
        if (!position.HasValue)
        {
            return CSToastManager.DefaultPosition;
        }
        switch (position)
        {
            case ToastPosition.Bottom:
                return CSToastPosition.Bottom;
            case ToastPosition.Center:
                return CSToastPosition.Center;
            case ToastPosition.Top:
                return CSToastPosition.Top;
            default:
                throw new InvalidEnumArgumentException(nameof(position), (int)position, typeof(ToastPosition));
        }
    }
}