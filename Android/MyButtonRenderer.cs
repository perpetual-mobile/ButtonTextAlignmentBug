using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using BugButtonAllignment;
using BugButtonAllignment.Android;

[assembly:ExportRenderer(typeof(MyButton), typeof(MyButtonRenderer))]

namespace BugButtonAllignment.Android
{
    public class MyButtonRenderer: ButtonRenderer
    {
        public override void ChildDrawableStateChanged(global::Android.Views.View child)
        { 
            base.ChildDrawableStateChanged(child); 
            Control.Text = Control.Text; 
        }
    }
}

