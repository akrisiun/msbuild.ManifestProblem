

# GetNativeManifest MSB4057 errror 

```
D:\Beta\Visual\ManifestProblem\src\netexe>"C:\Program Files (x86)\Microsoft Visual Studio\Preview\Community\MSBuild\15.0\Bin\MSBuild.exe" ""   /verbosity:m
Microsoft (R) Build Engine version 15.5.179.9764 for .NET FrameworkCopyright (C) Microsoft Corporation. All rights reserved.

  core -> D:\Beta\Visual\ManifestProblem\src\core\bin\Debug\net46\core.dll
  core -> D:\Beta\Visual\ManifestProblem\src\core\bin\Debug\netstandard1.3\core.dll
D:\Beta\Visual\ManifestProblem\src\core\core.csproj : error MSB4057: The target "GetNativeManifest" does not exist in the project.
D:\Beta\Visual\ManifestProblem\src\core\core.csproj : error MSB4057: The target "GetNativeManifest" does not exist in the project.
PS D:\Beta\Visual\ManifestProblem\src\netexe>
```

# dotnet build  fails

```
PS D:\Beta\Visual\ManifestProblem\src\netexe> dotnet build
Microsoft (R) Build Engine version 15.5.180.51428 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Restore completed in 31.57 ms for D:\Beta\Visual\ManifestProblem\src\core\core.csproj.
  core -> D:\Beta\Visual\ManifestProblem\src\core\bin\Debug\net46\core.dll
  core -> D:\Beta\Visual\ManifestProblem\src\core\bin\Debug\netstandard1.3\core.dll
D:\Beta\Visual\ManifestProblem\src\core\core.csproj : error MSB4057: The target "GetNativeManifest" does not exist in the project.
D:\Beta\Visual\ManifestProblem\src\core\core.csproj : error MSB4057: The target "GetNativeManifest" does not exist in the project.

Build FAILED.

PS D:\Beta\Visual\ManifestProblem\src\netexe> dotnet build     --no-dependencies
Microsoft (R) Build Engine version 15.5.180.51428 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Restore completed in 27.36 ms for D:\Beta\Visual\ManifestProblem\src\core\core.csproj.
D:\Beta\Visual\ManifestProblem\src\core\core.csproj : error MSB4057: The target "GetTargetPath" does not exist in the project.
D:\Beta\Visual\ManifestProblem\src\core\core.csproj : error MSB4057: The target "GetTargetPath" does not exist in the project.

Build FAILED.

D:\Beta\Visual\ManifestProblem\src\core\core.csproj : error MSB4057: The target "GetTargetPath" does not exist in the project.
D:\Beta\Visual\ManifestProblem\src\core\core.csproj : error MSB4057: The target "GetTargetPath" does not exist in the project.
    0 Warning(s)
    2 Error(s)
```