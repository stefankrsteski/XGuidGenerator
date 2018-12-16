//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Windows.ApplicationModel.DataTransfer;
//using XGuidGenerator.Interfaces;
//using XGuidGenerator.UWP.Implementations;

//[assembly: Xamarin.Forms.Dependency(typeof(ClipboardUWP))]
//namespace XGuidGenerator.UWP.Implementations
//{
//    class ClipboardUWP : IClipboard
//    {
//        public void CopyToClipboard(string data)
//        {
//            var dataPackage = new DataPackage();
//            dataPackage.SetText(data);
//            Clipboard.SetContent(dataPackage);
//        }
//    }
//}
