using System.IO;

namespace tinySun.Interfaces
{
	public interface IAssetLoader
	{
		Stream OpenAsset(string assetName);
	}
}
