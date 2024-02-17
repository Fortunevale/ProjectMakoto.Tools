using System.IO.Compression;

var env = Environment.GetCommandLineArgs();

if (env.Length < 3)
{
    Console.WriteLine("Arguments required: [Directory] [OutputFile]");
    return 1;
}

if (!new DirectoryInfo(env[1]).Exists)
{
    Console.WriteLine($"'{env[1]}' does not exist.");
    return 1;
}

if (new FileInfo(env[2]).Exists)
{
    Console.WriteLine($"'{env[2]}' already exists.");
    return 1;
}

ZipFile.CreateFromDirectory(env[1], env[2]);
return 0;
