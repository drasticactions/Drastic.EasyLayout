namespace Sample.MacCatalyst;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		// create a new window instance based on the screen size
		Window = new UIWindow (UIScreen.MainScreen.Bounds);

		// create a UIViewController with a single UILabel
		var vc = new Sample.Mac.PersonViewController(new Mac.Person() { FirstName = "Test", LastName = "Testing" });
		Window.RootViewController = new UINavigationController(vc);

		// make the window visible
		Window.MakeKeyAndVisible ();

		return true;
	}
}
