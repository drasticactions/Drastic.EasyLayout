using System;
using Drastic.EasyLayout;

namespace Sample.Mac
{
    public class AnchorsExample : UIViewController
    {
        UILabel label = new UILabel { Text = "Hello, world!" };

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.AddSubview(label);
            View.AddLayoutConstraints(() =>
                   label.TopAnchor == View.SafeAreaLayoutGuide.TopAnchor
                && label.Frame.GetCenterX() == View.Frame.GetCenterX()
                );
        }
    }
}

