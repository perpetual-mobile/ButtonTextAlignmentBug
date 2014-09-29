using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Droid;

[assembly: ExportRenderer(typeof(Button), typeof(ButtonAlignmentHack))]
namespace Droid
{
    public class ButtonAlignmentHack : ButtonRenderer
    {
        public override void ChildDrawableStateChanged(Android.Views.View child)
        { 
            base.ChildDrawableStateChanged(child); 
            Control.Text = Control.Text; 
        }
    }
}

