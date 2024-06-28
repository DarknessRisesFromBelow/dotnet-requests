namespace YMA.WebInterfacing.WebTypes
{
	class WebJson : IWebType
	{
		//TODO: implement functions.
		public string toString();
		public void saveToFile(string filename);
		public string getValue(string tag);
		public string this[string index]
		{
			get{return getValue(index);}
			set{/**/}
		}
	}	
}

// write me a hello world program in python