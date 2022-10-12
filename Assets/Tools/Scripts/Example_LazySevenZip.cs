using System;
using SevenZip;
using UnityEngine;

namespace LazyJedi.SevenZip
{
    public enum ActionType
    {
        Archive,
        Extract
    }

    public class Example_LazySevenZip : MonoBehaviour
    {
        #region FIELDS

        public bool Button;
        public string archivePath = @"Assets/files.7z";
        public ActionType ActionType = ActionType.Archive;
        public string[] FilesAndFolders;

        #endregion

        #region UNITY METHODS

        private async void OnValidate()
        {
            if (Button)
            {
                Button = false;
                switch (ActionType)
                {
                    case ActionType.Archive:
                        await LazyArchiver.ArchiveAsync(archivePath, FilesAndFolders, OutArchiveFormat.SevenZip);
                        break;
                    case ActionType.Extract:
                        await LazyExtractor.ExtractAsync("", archivePath);
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
    }
}