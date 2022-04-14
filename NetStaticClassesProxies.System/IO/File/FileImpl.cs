using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public class FileImpl : IFile
    {
        /// <inheritdoc/>
        public void AppendAllLines(string path, IEnumerable<string> contents) => File.AppendAllLines(path, contents);

        /// <inheritdoc/>
        public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding) => File.AppendAllLines(path, contents, encoding);

        /// <inheritdoc/>
        public Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default)
            => File.AppendAllLinesAsync(path, contents, cancellationToken);

        /// <inheritdoc/>
        public Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default)
            => File.AppendAllLinesAsync(path, contents, cancellationToken);

        /// <inheritdoc/>
        public void AppendAllText(string path, string contents) => File.AppendAllText(path, contents);

        /// <inheritdoc/>
        public void AppendAllText(string path, string contents, Encoding encoding) => File.AppendAllText(path, contents, encoding);

        /// <inheritdoc/>
        public Task AppendAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default)
             => File.AppendAllTextAsync(path, contents, encoding, cancellationToken);

        /// <inheritdoc/>
        public Task AppendAllTextAsync(string path, string contents, CancellationToken cancellationToken = default)
             => File.AppendAllTextAsync(path, contents, cancellationToken);

        /// <inheritdoc/>
        public StreamWriter AppendText(string path) => File.AppendText(path);

        /// <inheritdoc/>
        public void Copy(string sourceFileName, string destFileName) => File.Copy(sourceFileName, destFileName);

        /// <inheritdoc/>
        public void Copy(string sourceFileName, string destFileName, bool overwrite) => File.Copy(sourceFileName, destFileName, overwrite);

        /// <inheritdoc/>
        public FileStream Create(string path) => File.Create(path);

        /// <inheritdoc/>
        public FileStream Create(string path, int bufferSize) => File.Create(path, bufferSize);

        /// <inheritdoc/>
        public FileStream Create(string path, int bufferSize, FileOptions options) => File.Create(path, bufferSize, options);

        /// <inheritdoc/>
        public StreamWriter CreateText(string path) => File.CreateText(path);

        /// <inheritdoc/>
        public void Decrypt(string path) => File.Decrypt(path);

        /// <inheritdoc/>
        public void Delete(string path) => File.Delete(path);

        /// <inheritdoc/>
        public byte[] ReadAllBytes(string path) => File.ReadAllBytes(path);

        /// <inheritdoc/>
        public Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = default) => File.ReadAllBytesAsync(path, cancellationToken);

        /// <inheritdoc/>
        public string[] ReadAllLines(string path) => File.ReadAllLines(path);

        /// <inheritdoc/>
        public string[] ReadAllLines(string path, Encoding encoding) => File.ReadAllLines(path, encoding);

        /// <inheritdoc/>
        public Task<string[]> ReadAllLinesAsync(string path, Encoding encoding, CancellationToken cancellationToken = default)
             => File.ReadAllLinesAsync(path, encoding, cancellationToken);

        /// <inheritdoc/>
        public Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken = default)
             => File.ReadAllLinesAsync(path, cancellationToken);

        /// <inheritdoc/>
        public string ReadAllText(string path) => File.ReadAllText(path);

        /// <inheritdoc/>
        public string ReadAllText(string path, Encoding encoding) => File.ReadAllText(path, encoding);

        /// <inheritdoc/>
        public Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = default)
             => File.ReadAllTextAsync(path, encoding, cancellationToken);

        /// <inheritdoc/>
        public Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken = default)
            => File.ReadAllTextAsync(path, cancellationToken);

        /// <inheritdoc/>
        public IEnumerable<string> ReadLines(string path) => File.ReadLines(path);

        /// <inheritdoc/>
        public IEnumerable<string> ReadLines(string path, Encoding encoding) => File.ReadLines(path, encoding);

        /// <inheritdoc/>
        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName) 
            => File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);

        /// <inheritdoc/>
        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
             => File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);

        /// <inheritdoc/>
        public void SetAttributes(string path, FileAttributes fileAttributes)
             => File.SetAttributes(path, fileAttributes);

        /// <inheritdoc/>
        public void SetCreationTime(string path, DateTime creationTime)
             => File.SetCreationTime(path, creationTime);

        /// <inheritdoc/>
        public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
             => File.SetCreationTimeUtc(path, creationTimeUtc);

        /// <inheritdoc/>
        public void SetLastAccessTime(string path, DateTime lastAccessTime)
             => File.SetLastAccessTime(path, lastAccessTime);

        /// <inheritdoc/>
        public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
             => File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);

        /// <inheritdoc/>
        public void SetLastWriteTime(string path, DateTime lastWriteTime) => File.SetLastWriteTime(path, lastWriteTime);

        /// <inheritdoc/>
        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) => File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);

        /// <inheritdoc/>
        public void WriteAllBytes(string path, byte[] bytes) => File.WriteAllBytes(path, bytes);

        /// <inheritdoc/>
        public Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken = default)
             => File.WriteAllBytesAsync(path, bytes, cancellationToken);

        /// <inheritdoc/>
        public void WriteAllLines(string path, IEnumerable<string> contents)
             => File.WriteAllLines(path, contents);

        /// <inheritdoc/>
        public void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
             => File.WriteAllLines(path, contents, encoding);

        /// <inheritdoc/>
        public void WriteAllLines(string path, string[] contents) => File.WriteAllLines(path, contents);

        /// <inheritdoc/>
        public void WriteAllLines(string path, string[] contents, Encoding encoding) => File.WriteAllLines(path, contents, encoding);

        /// <inheritdoc/>
        public Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default)
             => File.AppendAllLinesAsync(path, contents, encoding, cancellationToken);

        /// <inheritdoc/>
        public void WriteAllText(string path, string contents) => File.WriteAllText(path, contents);

        /// <inheritdoc/>
        public void WriteAllText(string path, string contents, Encoding encoding) => File.WriteAllText(path, contents, encoding);

        /// <inheritdoc/>
        public Task WriteAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default)
             => File.WriteAllTextAsync(path, contents, encoding, cancellationToken);

        /// <inheritdoc/>
        public Task WriteAllTextAsync(string path, string contents, CancellationToken cancellationToken = default)
             => File.WriteAllTextAsync(path, contents, cancellationToken);
    }
}
