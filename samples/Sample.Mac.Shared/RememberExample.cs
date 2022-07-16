using System;
using Drastic.EasyLayout;

namespace Sample.Mac
{
    public class RememberExample : UIViewController
    {
        UILabel label = new UILabel { Text = "Enter your name, please." };
        UITextField textbox = new UITextField { Placeholder = "Your name" };

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.AddSubview(label);
            View.AddSubview(textbox);

            View.AddLayoutConstraints(() =>
                   label.Frame.Top == View.Frame.Top + 100
                && label.Frame.Left == View.Frame.Left + 50
                && textbox.Frame.Top == label.Frame.Bottom + 10
                && textbox.Frame.Left == label.Frame.Left
                );
        }
    }
}