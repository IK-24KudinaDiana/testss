


using System.Xml.Linq;

namespace laba_3_1
{
	public class Person
	{
		private string _name ;

		public string Name
		{
			get { return _name; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("Name no can be null");
				}
				_name = value;
			}
		}
		
	}
}
