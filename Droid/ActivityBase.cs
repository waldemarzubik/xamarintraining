﻿using System;
using System.ComponentModel;
using Android.App;
using GalaSoft.MvvmLight.Ioc;

namespace xamarintraining.Droid
{
    public abstract class ActivityBase<T> : Activity where T : INotifyPropertyChanged
    {
        protected T ViewModel { get; private set; }

        public override void SetContentView(int layoutResID)
        {
            base.SetContentView(layoutResID);

            ViewModel = SimpleIoc.Default.GetInstance<T>();
        }

        protected override void OnStart()
        {
            OnCreateBindings();
            base.OnStart();
        }

        protected virtual void OnCreateBindings()
        {

        }
    }
}
