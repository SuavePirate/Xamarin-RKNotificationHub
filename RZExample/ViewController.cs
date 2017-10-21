using System;
using RKNotificationHub;
using UIKit;

namespace RZExample
{
    public partial class ViewController : UIViewController
    {
        private RKNotificationHub.RKNotificationHub _hub;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            _hub = new RKNotificationHub.RKNotificationHub(NotificationButton);
            NotificationButton.TouchUpInside += (sender, e) =>
            {
                _hub.Increment();
                _hub.Bump();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
