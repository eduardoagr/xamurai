﻿using Android.App;
using Android.Views;

using Xamarin.Forms;

using Xamurai.Droid;
using Xamurai.Interfaces;

[assembly: Dependency(typeof(StatusBar))]
namespace Xamurai.Droid
{
    public class StatusBar : IStatusBar
    {
        WindowManagerFlags _originalFlags;
        public StatusBar()
        {

        }

        public void HideStatusBar()
        {
            var activity = (Activity)Forms.Context;
            var attrs = activity.Window.Attributes;
            _originalFlags = attrs.Flags;
            attrs.Flags |= Android.Views.WindowManagerFlags.Fullscreen;
            activity.Window.Attributes = attrs;
        }
        public void ShowStatusBar()
        {
            var activity = (Activity)Forms.Context;
            var attrs = activity.Window.Attributes;
            attrs.Flags = _originalFlags;
            activity.Window.Attributes = attrs;
        }
    }
}