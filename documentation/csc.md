The C# compiler (`csc.dll`) accepts a wide range of command-line parameters to control compilation. Below is a categorized list of common parameters. For a complete, up-to-date list, refer to the [official Microsoft documentation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/).

---

### **Basic Input/Output**
| Parameter | Description |
|-----------|-------------|
| `/target:<type>` | Specify output type (`exe`, `winexe`, `library`, `module`, `appcontainerexe`, `winmdobj`). |
| `/out:<file>` | Output filename. |
| `/recurse:<wildcard>` | Include all files matching the wildcard in the directory. |
| `/reference:<file>` (or `/r`) | Reference metadata from an assembly. |
| `/doc:<file>` | Generate XML documentation file. |

---

### **Code Generation**
| Parameter | Description |
|-----------|-------------|
| `/debug` | Emit debugging information (`full`, `portable`, `embedded`). |
| `/optimize` (or `/o`) | Enable code optimizations. |
| `/nullable` | Enable nullable context (`enable`, `disable`, `warnings`, `annotations`). |
| `/unsafe` | Allow unsafe code. |
| `/checked` | Enable overflow checking. |
| `/langversion:<version>` | Specify C# language version (e.g., `latest`, `preview`, `9.0`, `10.0`). |

---

### **Errors and Warnings**
| Parameter | Description |
|-----------|-------------|
| `/warn:<n>` | Set warning level (0–4). |
| `/warnaserror` | Treat warnings as errors. |
| `/nowarn:<list>` | Suppress specific warnings (e.g., `CS0168`). |
| `/errorreport:<mode>` | Error reporting mode (`none`, `prompt`, `queue`, `send`). |

---

### **Resources**
| Parameter | Description |
|-----------|-------------|
| `/resource:<res>` (or `/res`) | Embed a resource file. |
| `/linkresource:<res>` | Link a resource file without embedding. |
| `/win32icon:<file>` | Specify a `.ico` file for the output. |
| `/win32res:<file>` | Specify a Win32 resource file. |
| `/win32manifest:<file>` | Specify a Win32 manifest file. |

---

### **Signing**
| Parameter | Description |
|-----------|-------------|
| `/keyfile:<file>` | Specify a strong-name key file. |
| `/delaysign` | Delay-sign the assembly. |
| `/publicsign` | Public-sign the assembly (Open Source scenarios). |

---

### **Advanced**
| Parameter | Description |
|-----------|-------------|
| `/moduleassemblyname:<name>` | Specify the assembly name for modules. |
| `/noconfig` | Ignore `csc.rsp` file. |
| `/nostdlib` | Do not reference standard libraries (e.g., `mscorlib.dll`). |
| `/sdkpath:<path>` | Override path to `mscorlib.dll`. |
| `/deterministic` | Produce deterministic outputs (for reproducibility). |
| `/pathmap:<list>` | Replace source path names in outputs. |
| `/refout:<file>` | Generate a reference assembly. |
| `/refonly` | Generate only a reference assembly. |
| `/parallel` | Enable parallel build. |

---

### **Analyzer and Tools**
| Parameter | Description |
|-----------|-------------|
| `/analyzer:<file>` | Run a custom analyzer. |
| `/additionalfile:<file>` | Include non-source files (e.g., for analyzers). |
| `/analyzerconfig:<file>` | Specify analyzer configuration. |

---

### **Miscellaneous**
| Parameter | Description |
|-----------|-------------|
| `/help` (or `/?`) | Display compiler help. |
| `/version` | Display compiler version. |
| `/nologo` | Suppress compiler banner. |
| `/utf8output` | Output messages in UTF-8 encoding. |
| `/preferreduilang:<lang>` | Set the compiler's UI language (e.g., `en-US`). |

---

### **Examples**
1. **Basic Compilation**  
   ```bash
   csc /target:exe /out:Program.exe Program.cs
   ```

2. **Enable Nullable Context**  
   ```bash
   csc /nullable:enable Program.cs
   ```

3. **Generate Debug Symbols**  
   ```bash
   csc /debug:portable /optimize- Program.cs
   ```

---

### **Notes**
- Parameters are **case-insensitive** (e.g., `/target` = `/TARGET`).
- Use `+`/`-` to enable/disable flags (e.g., `/checked+`).
- Many parameters have short forms (e.g., `/t:exe` = `/target:exe`).

For the full list, run `csc -help` or check the [C# Compiler Options](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/).
