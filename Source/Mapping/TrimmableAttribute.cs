using System;
using System.Diagnostics.CodeAnalysis;

namespace BLToolkit.Mapping
{
	[AttributeUsage(
		AttributeTargets.Property | AttributeTargets.Field |
		AttributeTargets.Class | AttributeTargets.Interface)]
	public sealed class TrimmableAttribute : Attribute
	{
		public TrimmableAttribute()
		{
			_isTrimmable = true;
		}

		public TrimmableAttribute(bool isTrimmable)
		{
			_isTrimmable = isTrimmable;
		}

		private bool _isTrimmable;
		public  bool  IsTrimmable
		{
			get { return _isTrimmable;  }
		}

		[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly TrimmableAttribute Yes     = new TrimmableAttribute(true);
		[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly TrimmableAttribute No      = new TrimmableAttribute(false);
		[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
		public static readonly TrimmableAttribute Default = No;
	}
}
