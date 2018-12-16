﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XGuidGenerator.Droid.Implementations;
using XGuidGenerator.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(ToastAndroid))]
namespace XGuidGenerator.Droid.Implementations
{
    class ToastAndroid : IToast
    {
        public void Show(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
    }
}