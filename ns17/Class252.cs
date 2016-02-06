using GuitarHero.Songlist;
using ns16;
using ns19;
using ns20;
using ns21;
using ns22;
using System;

namespace ns17
{
	public class Class252 : Class245
	{
		private Class318 class318_0;

		private GH3Songlist gh3Songlist_0;

		private bool bool_0;

		public Class252(Class318 class318_1, GH3Songlist gh3Songlist_1, bool bool_1)
		{
			this.class318_0 = class318_1;
			this.gh3Songlist_0 = gh3Songlist_1;
			this.bool_0 = bool_1;
		}

		public override void vmethod_0()
		{
			string text = "scripts\\guitar\\guitar_progression.qb";
			Class308 @class = this.class318_0.method_8(text);
			this.gh3Songlist_0.method_4(text, @class.method_5<Class266>(new Class266("gh3_career_songs")));
			this.gh3Songlist_0.method_4(text, @class.method_5<Class266>(new Class266("gh3_general_songs")));
			if (!this.bool_0)
			{
				this.gh3Songlist_0.method_4(text, @class.method_5<Class266>(new Class266("gh3_generalp2_songs")));
				this.gh3Songlist_0.method_4(text, @class.method_5<Class266>(new Class266("gh3_generalp2_songs_coop")));
			}
			this.gh3Songlist_0.method_5(text, @class.method_5<Class266>(new Class266("p1_career_progression")));
			if (!this.bool_0)
			{
				this.gh3Songlist_0.method_5(text, @class.method_5<Class266>(new Class266("p2_career_progression")));
			}
			this.gh3Songlist_0.method_5(text, @class.method_5<Class266>(new Class266("bonus_progression")));
			this.gh3Songlist_0.method_5(text, @class.method_5<Class266>(new Class266("download_progression")));
			this.gh3Songlist_0.method_5(text, @class.method_5<Class266>(new Class266("general_progression")));
			if (!this.bool_0)
			{
				this.gh3Songlist_0.method_5(text, @class.method_5<Class266>(new Class266("generalp2_progression")));
				this.gh3Songlist_0.method_5(text, @class.method_5<Class266>(new Class266("p2_coop_progression")));
			}
			@class = this.class318_0.method_8(text = "scripts\\guitar\\guitar_download.qb");
			this.gh3Songlist_0.method_4(text, @class.method_5<Class266>(new Class266("gh3_download_songs")));
			if (!this.bool_0)
			{
				@class = this.class318_0.method_8(text = "scripts\\guitar\\guitar_coop.qb");
				this.gh3Songlist_0.method_4(text, @class.method_5<Class266>(new Class266("gh3_coopcareer_songs")));
			}
			@class = this.class318_0.method_8(text = "scripts\\guitar\\store_data.qb");
			this.gh3Songlist_0.method_4(text, @class.method_5<Class266>(new Class266("gh3_bonus_songs")));
			if (this.class318_0.method_6(text = "scripts\\guitar\\custom_menu\\guitar_custom_progression.qb"))
			{
				@class = this.class318_0.method_8(text);
				int num = @class.method_5<Class269>(new Class269("custom_setlist_bitmask")).method_7();
				for (int i = 0; i < 32; i++)
				{
					if (num >> i != 0)
					{
						this.gh3Songlist_0.method_4(text, @class.method_5<Class266>(new Class266("gh3_custom" + (i + 1) + "_songs"))).CustomBit = 1 << i;
						this.gh3Songlist_0.method_5(text, @class.method_5<Class266>(new Class266("custom" + (i + 1) + "_progression")));
					}
				}
				this.gh3Songlist_0.CustomBitMask = num;
			}
			@class = this.class318_0.method_8("scripts\\guitar\\custom_menu\\guitar_custom_menu_setlist_switcher.qb");
			this.gh3Songlist_0.method_6((Class292)@class.method_5<Class267>(new Class267("custom_menu_setlist_switcher_progressions_" + (this.bool_0 ? "gha" : "gh3"))).method_7());
		}

		public override string ToString()
		{
			return "Parse Setlists";
		}

		public override bool Equals(Class245 other)
		{
			return other is Class252;
		}
	}
}