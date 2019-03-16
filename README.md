
## OutputType 'WinExe' problem
```
2.1.505 [C:\Program Files\dotnet\sdk]
Microsoft.NETCore.App 2.1.9 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft (R) Build Engine version 15.9.20+g88f5fadfbe for .NET Core

SKD 2.1.505 runs but fails

Unable to run your project.
Please ensure you have a runnable project type and ensure 'dotnet run' supports this project.
A runnable project should target a runnable TFM (for instance, netcoreapp2.0) and have OutputType 'Exe'.
The current OutputType is 'WinExe'.
```

# osx


```
pwsh
$env:FrameworkPathOverride="/Library/Frameworks/Mono.framework/Versions/Current/lib/mono/4.5/"
```

# Ubuntu (16.04) or Debian

```
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb http://download.mono-project.com/repo/ubuntu stable-xenial main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
sudo apt-get update
sudo apt-get install mono-devel
export FrameworkPathOverride=/usr/lib/mono/4.5/
mono --version
#Mono JIT compiler version 5.10.1.4 (tarball Wed Mar 21 10:51:27 UTC 2018)
#Copyright (C) 2002-2014 Novell, Inc, Xamarin Inc and Contributors. www.mono-project.com

```

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
