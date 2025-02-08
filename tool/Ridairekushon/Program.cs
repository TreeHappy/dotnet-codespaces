File.WriteAllLines("cscparameters", args);
File.WriteAllText("rspfile", File.ReadAllText(args[1][1..]));
