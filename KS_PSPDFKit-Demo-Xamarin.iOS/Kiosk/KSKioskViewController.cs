using System;
using KS_PSPDFKitBindings;

namespace PSPDFKitDemoXamarin.iOS
{
	public class KSKioskViewController : PSPDFViewController
	{
		public KSKioskViewController (PSPDFDocument doc) : base(doc)
		{
		}

		// If this constructor is missing, we're crashing!
		public KSKioskViewController(IntPtr handle) : base(handle)
		{
			Console.WriteLine("IntPtr c'tor");
		}


		~KSKioskViewController()
		{
			Console.WriteLine("Finalized!");
		}

		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
		}


	}
}

