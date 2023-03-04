using KMA_lab1_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KMA_lab1_2023.ViewModels
{
	internal class DateViewModel
	{
		private User _user = new User();

		public int Age
		{
			get { return _user.Age; }
			set { _user.Age = value; }
		}
		public DateTime Birthday
		{
			get { return _user.Birthday; }
			set { _user.Birthday = value; CountAge(value); CountWesternZodiac(value); CountChineseZodiac(value); }
		}

		public string WesternZodiac
		{
			get { return _user.WesternZodiac; }
			set { _user.WesternZodiac = value; }
		}

		public string ChineseZodiac
		{
			get { return _user.ChineseZodiac; }
			set { _user.ChineseZodiac = value; }
		}
		private void CountAge(DateTime date)
		{
			if(DateTime.Today.Day == date.Day && DateTime.Today.Month == date.Month)
			{
				MessageBox.Show("Happy Birthday!!!");
			}
			int today = (DateTime.Today.Year*100+DateTime.Today.Month)*100+DateTime.Today.Day;
			int birthday = (date.Year * 100 + date.Month) * 100 + date.Day;
			Age = (today - birthday)/10000;
		}

		private void CountWesternZodiac(DateTime value)
		{
			int month = value.Month;
			int day = value.Day;
				switch (month)
				{
					case 1: 
						if (day < 20) WesternZodiac = "Capricorn";
						else WesternZodiac = "Aquarius";
						break;
					case 2:
						if (day > 18) WesternZodiac = "Pisces";
						else WesternZodiac = "Aquarius";
						break;
					case 3:
						if (day > 20) WesternZodiac = "Aries";
						else WesternZodiac = "Pisces";
						break;
					case 4:
						if (day > 19) WesternZodiac = "Taurus";
						else WesternZodiac = "Aries";
						break;
					case 5:
						if (day < 21) WesternZodiac = "Taurus";
						else WesternZodiac = "Gemini";
						break;
					case 6:
						if (day > 20) WesternZodiac = "Cancer";
						else WesternZodiac = "Gemini";
						break;
					case 7:
						if (day > 22) WesternZodiac = "Leo";
						else WesternZodiac = "Cancer";
						break;
					case 8:
						if (day > 22) WesternZodiac = "Virgo";
						else WesternZodiac = "Leo";
						break;
					case 9:
						if (day < 23) WesternZodiac = "Virgo";
						else WesternZodiac = "Libra";
						break;
					case 10:
						if (day > 22) WesternZodiac = "Scorpio";
						else WesternZodiac = "Libra";
						break;
					case 11:
						if (day < 22) WesternZodiac = "Scorpio";
						else WesternZodiac = "Sagittarius";
						break;
					case 12:
						if (day > 21) WesternZodiac = "Capricorn";
						else WesternZodiac = "Sagittarius";
						break;
			}
		}

		private void CountChineseZodiac(DateTime value)
		{
			int year = value.Year;
				if (year % 12 == 0) { ChineseZodiac = "Monkey"; }
				else if (year % 12 == 1) { ChineseZodiac = "Rooster"; }
				else if (year % 12 == 2) { ChineseZodiac = "Dog"; }
				else if (year % 12 == 3) { ChineseZodiac = "Pig"; }
				else if (year % 12 == 4) { ChineseZodiac = "Rat"; }
				else if (year % 12 == 5) { ChineseZodiac = "Ox"; }
				else if (year % 12 == 6) { ChineseZodiac = "Tiger"; }
				else if (year % 12 == 7) { ChineseZodiac = "Rabbit"; }
				else if (year % 12 == 8) { ChineseZodiac = "Dragon"; }
				else if (year % 12 == 9) { ChineseZodiac = "Snake"; }
				else if (year % 12 == 10) { ChineseZodiac = "Horse"; }
				else { ChineseZodiac = "Sheep"; }
		}
	}
}
