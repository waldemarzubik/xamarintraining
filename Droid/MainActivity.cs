using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace xamarintraining.Droid
{
    [Activity(Label = "xamarin training", MainLauncher = true, Icon = "@mipmap/icon", Exported = true)]
    public class MainActivity : Activity
    {
        public const string PARAM = "param";
        private Button _button;
        private TextView _text;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _button = FindViewById<Button>(Resource.Id.searchButton);
            _text = FindViewById<TextView>(Resource.Id.searchEditText);
        }

        protected override void OnStart()
        {
            base.OnStart();
            _button.Click += _button_Click;
        }

        protected override void OnStop()
        {
            _button.Click -= _button_Click;
            base.OnStop();
        }

        void _button_Click(object sender, System.EventArgs e)
        {
            using (var intent = new Intent(this, typeof(SecondActivity)))
            {
                intent.PutExtra(PARAM, _text.Text);
                StartActivity(intent);
            }
        }
    }
}

