# Lazy Seven Zip
Lazy Seven Zip is a wrapper for the popular [SevenZipSharp](https://github.com/squid-box/SevenZipSharp) library.<br>
It provides an easy to use set of methods to easily create and extract archives in Unity within the Editor or at
Runtime.

For the benefit of the user, the source code is easy to follow and can be modified without must difficulty.

Please note!<br>
This library does not include creating or extracting archives via Stream.

## Lazy Archive Class

The Lazy Archive Wrapper Class consists of 4 Archive methods, 2 Synchronous and 2 Asynchronous methods.<br>
This allows you to create standard or encrypted archives easily.

The methods in the class are shown below.

### Synchronous

```csharp

public static void Archive(string outArchive, 
                           string[] inFiles, 
                           OutArchiveFormat archiveFormat, 
                           CompressionLevel compressionLevel = CompressionLevel.Normal)
{
...
}

public static void Archive(string outArchive,
                           string[] inFiles,
                           string password,
                           OutArchiveFormat archiveFormat,
                           bool encryptHeaders = false,
                           ZipEncryptionMethod encryptionMethod = ZipEncryptionMethod.Aes128,
                           CompressionLevel compressionLevel = CompressionLevel.Normal)
{
...
}

```

## Lazy Extractor Class



### Asynchronous

```csharp

public static async Task ArchiveAsync(string outArchive, 
                           string[] inFiles, 
                           OutArchiveFormat archiveFormat, 
                           CompressionLevel compressionLevel = CompressionLevel.Normal)
{
...
}

public static async Task ArchiveAsync(string outArchive,
                           string[] inFiles,
                           string password,
                           OutArchiveFormat archiveFormat,
                           bool encryptHeaders = false,
                           ZipEncryptionMethod encryptionMethod = ZipEncryptionMethod.Aes128,
                           CompressionLevel compressionLevel = CompressionLevel.Normal)
{
...
}

```

## Examples - Creating an Archive
### Method 1 - Archive no Password

```csharp

public void ArchiveTest(string[] filesToArchive)
{
    LazyArchiver.ArchiveAsync("Assets/test.7z", filesToArchive , OutArchiveFormat.SevenZip);
}

public async Task ArchiveTestAsync(string[] filesToArchive)
{
    await LazyArchiver.ArchiveAsync(archivePath, FoldersToCompress, OutArchiveFormat.SevenZip);
}

```

### Method 2 - Archive with Password

```csharp

public void ArchiveTest(string password, string[] filesToArchive)
{
    LazyArchiver.ArchiveAsync("Assets/test.7z", filesToArchive , password, OutArchiveFormat.SevenZip);
}

public async Task ArchiveTestAsync(string password, string[] filesToArchive)
{
    await LazyArchiver.ArchiveAsync(archivePath, FoldersToCompress, password, OutArchiveFormat.SevenZip);
}

```

## Extracting an Archive

# Credits

+ [SevenZipSharp](https://github.com/squid-box/SevenZipSharp) created by [ToMap](https://github.com/tomap) and currently
  maintained by [Squid-Box](https://github.com/squid-box)
+ [7Zip Library](https://www.7-zip.org/) by [Igor Pavlov](https://sourceforge.net/u/ipavlov/profile/)