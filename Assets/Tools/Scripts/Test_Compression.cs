using System;
using SevenZip;
using UnityEngine;

namespace LazyJedi.SevenZip
{
    public enum CompressType
    {
        Archive,
        Extract,
        SFX
    }

    public class Test_Compression : MonoBehaviour
    {
        #region FIELDS

        public bool Button;
        public string archivePath = @"Assets/files.7z";
        public CompressType CompressType = CompressType.Archive;
        public string[] FoldersToCompress;

        #endregion

        #region UNITY METHODS

        private async void OnValidate()
        {
            if (Button)
            {
                Button = false;
                switch (CompressType)
                {
                    case CompressType.Archive:
                        await LazyArchiver.ArchiveAsync(archivePath, FoldersToCompress, OutArchiveFormat.SevenZip);
                        break;
                    case CompressType.Extract:
                        await LazyExtractor.ExtractAsync("", archivePath);
                        break;
                    case CompressType.SFX:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

#if UNITY_EDITOR
                UnityEditor.AssetDatabase.Refresh();
#endif
            }
        }

        #endregion

        #region METHODS

        #endregion
    }
}