using System;
using System.Xml;

namespace SharpVectors.Dom.Css
{

	public class CssAbsValue : CssValue
	{
		public CssAbsValue(CssValue cssValue, string propertyName, XmlElement element) : base()
		{
			_cssValue = cssValue;
			_propertyName = propertyName;
			_element = element;
		}

		private CssValue _cssValue;
		private string _propertyName;
		private XmlElement _element;
		
		public override string CssText
		{
			get
			{
				return _cssValue.CssText;
			}
		}

		public override CssValueType CssValueType
		{
			get
			{
				return _cssValue.CssValueType;
			}
		}
	}
}
