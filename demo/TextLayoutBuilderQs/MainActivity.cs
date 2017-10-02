using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;
using Android.Util;
using Android.Text;
using Android.Runtime;
using Com.Facebook.Fbui.Textlayoutbuilder;
using Naxam.Textlayoutbuilder.Droid;

namespace TextLayoutBuilderQs
{
    [Activity(Label = "TextLayoutBuilderQs", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var myView = FindViewById<CustomView>(Resource.Id.myView);

            var builder = new TextLayoutBuilder()
                            .SetTextAppearance(this, Android.Resource.Style.TextAppearanceLarge)
                            .SetText("TextLayoutBuilder makes life easy")
                            .SetWidth(400, TextLayoutBuilder.MeasureModeAtMost);    
            
            var layout = builder.Build();
            myView.Layout = builder.Build();
            myView.ForceLayout();
        }
    }

    [Register("net.naxam.CustomView")]
    public class CustomView : View
    {
        public Layout Layout { get; set; }

        public CustomView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        protected override void OnDraw(Android.Graphics.Canvas canvas)
        {
            base.OnDraw(canvas);

            Layout?.Draw(canvas);
        }
    }
}

