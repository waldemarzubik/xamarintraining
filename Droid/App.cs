using System;
using Android.App;
using Android.Runtime;

namespace xamarintraining.Droid
{
    [Application]
    public class App : Application
    {
        private AndroidLocator _locator;
        private object _lock = new object();

        public App()
        {
        }

        public App(IntPtr handle, JniHandleOwnership transfer)
            : base(handle, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            SafeCreateLocator();
        }

        private void SafeCreateLocator()
        {
            if (_locator == null)
            {
                lock (_lock)
                {
                    if (_locator == null)
                    {
                        _locator = new AndroidLocator();
                    }
                }
            }
        }
    }
}
