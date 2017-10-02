using System;
namespace Naxam.Textlayoutbuilder.Droid
{
    using Android.Content;
    using Com.Facebook.Fbui.Textlayoutbuilder;

    public static class TextLayoutBuilderExtensions
    {
        public static TextLayoutBuilder SetTextAppearance(this TextLayoutBuilder builder, Context context, int resId){
            ResourceTextLayoutHelper.SetTextAppearance(builder, context, resId);

            return builder;
        }
    }
}
