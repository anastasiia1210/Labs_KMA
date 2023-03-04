using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KMA_lab1_2023.Models
{
	internal class User
	{
		private int _age;
		private DateTime _birthday;
		private string _westernZodiac;
        private string _chineseZodiac;

		public int Age
		{
			get { return _age; }
			set { 
               _age = value; 
				if(_age>135 || _age < 1)
				{
					MessageBox.Show("Your age is incorrect.");
				}
			}
		}

		public DateTime Birthday
		{
			get { return _birthday; }	
			set { _birthday = value; }
		}

		public string WesternZodiac
		{
			get { return _westernZodiac; }
			set { _westernZodiac = value; }
		}

		public string ChineseZodiac
		{
			get { return _chineseZodiac; }
			set { _chineseZodiac = value; }
		}
	}
}
