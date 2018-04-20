using Foundation;
using System;

using UIKit;

namespace hello.iOs
{
    public partial class ViewController : UIViewController
    {
        private string translateNumber = "";

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            
            translateBtn.TouchUpInside += TranslateBtn_TouchUpInside;
            CallBtn.TouchUpInside+=(object sender, EventArgs e)=>{
                NSUrl url = new NSUrl("tel:" + translateNumber);
                if (!UIApplication.SharedApplication.OpenUrl(url))
                {
                    var alert = UIAlertController.Create("Fonctionnalité Non supportée",
                        "Achete toi un IPhone",
                        UIAlertControllerStyle.Alert);
                    alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
                    PresentViewController(alert, true, null);
                }
            };
        }

        private void TranslateBtn_TouchUpInside(object sender, EventArgs e)
        {
            translateNumber = PhoneTranslator.ToNumber(PhoneNumberText.Text);

            PhoneNumberText.ResignFirstResponder();

            if (translateNumber=="")
            {
                CallBtn.SetTitle("Appelr après", UIControlState.Disabled);
                CallBtn.Enabled = false;
            }
            else
            {
                CallBtn.SetTitle("Appeler maintenant", UIControlState.Normal);
                CallBtn.Enabled = true;
                PhoneNumberLbl.Text = translateNumber;
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}