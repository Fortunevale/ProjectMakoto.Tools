try
{
    if (!new FileInfo(".git").Exists)
        return 1;

    var content = File.ReadAllLines(".git");

    if (!content.Any(x => x.StartsWith("gitdir: ")))
        return 1;

    var gitDirLine = content.First(x => x.StartsWith("gitdir: "));

    Console.WriteLine(gitDirLine[8..]);
    return 0;

}
catch (Exception)
{
    return 1;
}