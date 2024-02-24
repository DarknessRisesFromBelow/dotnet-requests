using System.Drawing;

namespace YMA.WebInterfacing.WebTypes
{
	class WebImage : IWebType
	{
		//TODO: implement functions.
		public string toString();
		public void saveToFile(string filename);
		public Bitmap ToBitmap();
		public Image toSysDrawingImage();
	}	
}

