using GuitarHero.Songlist;
using GuitarHero.Tier;
using ns13;
using ns16;
using ns20;
using ns21;
using System;
using System.Collections.Generic;
using System.IO;

namespace ns17
{
	public class TGHManager
	{
		private GH3Songlist gh3Songlist_0;

		public GH3Tier gh3Tier_0;

		private string string_0;

		private string string_1;

		public TGHManager(GH3Songlist gh3Songlist_1, GH3Tier gh3Tier_1, string string_2) : this(gh3Songlist_1, gh3Tier_1, string_2, null)
		{
		}

		public TGHManager(GH3Songlist gh3Songlist_1, GH3Tier gh3Tier_1, string string_2, string string_3)
		{
			this.gh3Songlist_0 = gh3Songlist_1;
			this.gh3Tier_0 = gh3Tier_1;
			this.string_0 = string_3;
			this.string_1 = string_2;
		}

		public void method_0()
		{
			byte[] byte_;
			ZIPManager.smethod_3(this.string_1, out byte_, "songs.info", "TGH9ZIP2PASS4MXKR");
			zzGenericNode1 @class = new zzGenericNode1("songs", KeyGenerator.smethod_8(byte_, "SNG4AES4KEY9MXKR"));
			foreach (StructurePointerNode class302_ in @class.Nodes)
			{
				GH3Song gH3Song = new GH3Song(class302_);
				gH3Song.editable = true;
				this.gh3Songlist_0.method_0(gH3Song, this.string_0 != null);
			}
			ZIPManager.smethod_3(this.string_1, out byte_, "tier.info", "TGH9ZIP2PASS4MXKR");
			this.gh3Tier_0.method_1(new GH3Tier((StructureHeaderNode)new zzGenericNode1("tier", KeyGenerator.smethod_8(byte_, "TIR4AES4KEY9MXKR")).Nodes[0], this.gh3Songlist_0));
			if (this.string_0 != null)
			{
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				foreach (GH3Song current in this.gh3Tier_0.songs)
				{
					if (current.editable)
					{
						list.Add(current.name + "_song.pak.xen");
						list2.Add(this.string_0 + "songs\\" + current.name + "_song.pak.xen");
						list.Add(current.name + ".dat.xen");
						list2.Add(this.string_0 + "music\\" + current.name + ".dat.xen");
						list.Add(current.name + ".fsb.xen");
						list2.Add(this.string_0 + "music\\" + current.name + ".fsb.xen");
					}
				}
				ZIPManager.smethod_11(this.string_1, list2, list, "TGH9ZIP2PASS4MXKR");
			}
		}

		public void method_1()
		{
			List<Stream> list = new List<Stream>();
			Stream stream = new MemoryStream();
			KeyGenerator.smethod_1(new zzGenericNode1("tier", this.gh3Tier_0.method_3()).method_8(), stream, "TIR4AES4KEY9MXKR");
			List<string> list2 = new List<string>();
			List<StructurePointerNode> list3 = new List<StructurePointerNode>();
			foreach (GH3Song current in this.gh3Tier_0.songs)
			{
				if (current.editable)
				{
					list3.Add(current.vmethod_5());
					if (this.string_0 != null && File.Exists(this.string_0 + "songs\\" + current.name + "_song.pak.xen") && File.Exists(this.string_0 + "music\\" + current.name + ".dat.xen") && File.Exists(this.string_0 + "music\\" + current.name + ".fsb.xen"))
					{
						list2.Add(current.name + "_song.pak.xen");
						list.Add(File.OpenRead(this.string_0 + "songs\\" + current.name + "_song.pak.xen"));
						list2.Add(current.name + ".dat.xen");
						list.Add(File.OpenRead(this.string_0 + "music\\" + current.name + ".dat.xen"));
						list2.Add(current.name + ".fsb.xen");
						list.Add(File.OpenRead(this.string_0 + "music\\" + current.name + ".fsb.xen"));
					}
				}
			}
			Stream stream2 = new MemoryStream();
			KeyGenerator.smethod_1(new zzGenericNode1("songs", list3.ToArray()).method_8(), stream2, "SNG4AES4KEY9MXKR");
			list2.Add("tier.info");
			list.Add(stream);
			list2.Add("songs.info");
			list.Add(stream2);
			ZIPManager.smethod_0(list2, this.string_1, "TGH9ZIP2PASS4MXKR", list.ToArray());
		}
	}
}
