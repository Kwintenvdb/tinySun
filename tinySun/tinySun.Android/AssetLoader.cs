using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using tinySun.Interfaces;

namespace tinySun.Droid
{
	public class AssetLoader : IAssetLoader
	{
		private readonly AssetManager _assetManager;

		public AssetLoader(AssetManager assetManager)
		{
			_assetManager = assetManager;
		}

		public Stream OpenAsset(string assetName)
		{
			return _assetManager.Open(assetName);
		}
	}
}