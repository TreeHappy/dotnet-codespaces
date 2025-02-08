using System.Diagnostics;

File.WriteAllLines("cscparameters", args);
File.WriteAllText("rspfile", File.ReadAllText(args[1][1..]));

static int CompileWithRspFile(string[] args)
{
    // Configure process
    var startInfo = new ProcessStartInfo
    {
        FileName = "dotnet",
        Arguments = "csc " + string.Join(" ", args),
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false,
        CreateNoWindow = true
    };

    // Execute compiler
    using var process = new Process { StartInfo = startInfo };
    process.Start();
    process.WaitForExit();

    var output = process.StandardOutput.ReadToEnd();
    var error = process.StandardError.ReadToEnd();

    File.WriteAllText("std_output", output);
    File.WriteAllText("std_error", error);

    if (string.IsNullOrWhiteSpace(error) is false)
        Console.Error.WriteLine(error);

    if (string.IsNullOrWhiteSpace(output) is false) 
        Console.WriteLine(output);

    return process.ExitCode;
}

CompileWithRspFile(args);
