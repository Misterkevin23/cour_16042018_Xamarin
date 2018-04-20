// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace hello.iOs
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CallBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PhoneNumberLbl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PhoneNumberText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton translateBtn { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CallBtn != null) {
                CallBtn.Dispose ();
                CallBtn = null;
            }

            if (PhoneNumberLbl != null) {
                PhoneNumberLbl.Dispose ();
                PhoneNumberLbl = null;
            }

            if (PhoneNumberText != null) {
                PhoneNumberText.Dispose ();
                PhoneNumberText = null;
            }

            if (translateBtn != null) {
                translateBtn.Dispose ();
                translateBtn = null;
            }
        }
    }
}