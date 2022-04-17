using System.Collections.Generic;

namespace System.IO
{
    /// <summary>
    /// Exposes static methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.
    /// </summary>
    public sealed class DirectoryImpl : IDirectory
    {
        /// <inheritdoc/>
        public DirectoryInfo CreateDirectory(string path) => Directory.CreateDirectory(path);

        /// <inheritdoc/>
        public void Delete(string path) => Directory.Delete(path);

        /// <inheritdoc/>
        public void Delete(string path, bool recursive) => Directory.Delete(path, recursive);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateDirectories(string path) => Directory.EnumerateDirectories(path);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern) => Directory.EnumerateDirectories(path, searchPattern);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
            => Directory.EnumerateDirectories(path, searchPattern, enumerationOptions);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
             => Directory.EnumerateDirectories(path, searchPattern, searchOption);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateFiles(string path) => Directory.EnumerateFiles(path);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern) => Directory.EnumerateFiles(path, searchPattern);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
             => Directory.EnumerateFiles(path, searchPattern, enumerationOptions);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
             => Directory.EnumerateFiles(path, searchPattern, searchOption);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateFileSystemEntries(string path) => Directory.EnumerateFileSystemEntries(path);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
             => Directory.EnumerateFileSystemEntries(path, searchPattern);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
             => Directory.EnumerateFileSystemEntries(path, searchPattern, enumerationOptions);

        /// <inheritdoc/>
        public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
             => Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);

        /// <inheritdoc/>
        public bool Exists(string path) => Directory.Exists(path);

        /// <inheritdoc/>
        public DateTime GetCreationTime(string path) => Directory.GetCreationTime(path);

        /// <inheritdoc/>
        public DateTime GetCreationTimeUtc(string path) => Directory.GetLastWriteTimeUtc(path);

        /// <inheritdoc/>
        public string GetCurrentDirectory() => Directory.GetCurrentDirectory();

        /// <inheritdoc/>
        public string[] GetDirectories(string path) => Directory.GetDirectories(path);

        /// <inheritdoc/>
        public string[] GetDirectories(string path, string searchPattern) => Directory.GetDirectories(path, searchPattern);

        /// <inheritdoc/>
        public string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
             => Directory.GetDirectories(path, searchPattern, enumerationOptions);

        /// <inheritdoc/>
        public string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
             => Directory.GetDirectories(path, searchPattern, searchOption);

        /// <inheritdoc/>
        public string GetDirectoryRoot(string path) => Directory.GetDirectoryRoot(path);

        /// <inheritdoc/>
        public string[] GetFiles(string path) => Directory.GetFiles(path);

        /// <inheritdoc/>
        public string[] GetFiles(string path, string searchPattern) => Directory.GetFiles(path, searchPattern);

        /// <inheritdoc/>
        public string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
             => Directory.GetFiles(path, searchPattern, enumerationOptions);

        /// <inheritdoc/>
        public string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
             => Directory.GetFiles(path, searchPattern, searchOption);

        /// <inheritdoc/>
        public string[] GetFileSystemEntries(string path) => Directory.GetFileSystemEntries(path);

        /// <inheritdoc/>
        public string[] GetFileSystemEntries(string path, string searchPattern) => Directory.GetFileSystemEntries(path, searchPattern);

        /// <inheritdoc/>
        public string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
             => Directory.GetFileSystemEntries(path, searchPattern, enumerationOptions);

        /// <inheritdoc/>
        public string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
             => Directory.GetFileSystemEntries(path, searchPattern, searchOption);

        /// <inheritdoc/>
        public DateTime GetLastAccessTime(string path) => Directory.GetLastAccessTime(path);

        /// <inheritdoc/>
        public DateTime GetLastAccessTimeUtc(string path) => Directory.GetLastAccessTimeUtc(path);

        /// <inheritdoc/>
        public DateTime GetLastWriteTime(string path) => Directory.GetLastWriteTime(path);

        /// <inheritdoc/>
        public DateTime GetLastWriteTimeUtc(string path) => Directory.GetLastWriteTimeUtc(path);

        /// <inheritdoc/>
        public string[] GetLogicalDrives() => Directory.GetLogicalDrives();

        /// <inheritdoc/>
        public DirectoryInfo GetParent(string path) => Directory.GetParent(path);

        /// <inheritdoc/>
        public void Move(string sourceDirName, string destDirName) => Directory.Move(sourceDirName, destDirName);

        /// <inheritdoc/>
        public void SetCreationTime(string path, DateTime creationTime) => Directory.SetCreationTime(path, creationTime);

        /// <inheritdoc/>
        public void SetCreationTimeUtc(string path, DateTime creationTimeUtc) => Directory.SetCreationTimeUtc(path, creationTimeUtc);

        /// <inheritdoc/>
        public void SetCurrentDirectory(string path) => Directory.SetCurrentDirectory(path);

        /// <inheritdoc/>
        public void SetLastAccessTime(string path, DateTime lastAccessTime) => Directory.SetLastAccessTime(path, lastAccessTime);

        /// <inheritdoc/>
        public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) => Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);

        /// <inheritdoc/>
        public void SetLastWriteTime(string path, DateTime lastWriteTime) => Directory.SetLastWriteTime(path, lastWriteTime);

        /// <inheritdoc/>
        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) => Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
    }
}
