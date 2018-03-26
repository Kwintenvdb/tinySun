using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Text;

namespace tinySun.ViewModels
{
	public class ViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression)
		{
			var memberExpr = propertyExpression.Body as MemberExpression;
			if (memberExpr == null) throw new ArgumentException("propertyExpression should represent access to a member.");
			string memberName = memberExpr.Member.Name;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
		}
	}
}
