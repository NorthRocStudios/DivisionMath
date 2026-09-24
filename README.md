<div align="left">

# DivisionMath

[![NuGet](https://img.shields.io/nuget/v/NorthRoc.DivisionMath?label=NuGet&logo=nuget)](https://www.nuget.org/packages/NorthRoc.DivisionMath/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/NorthRoc.DivisionMath?label=Downloads&logo=nuget)](https://www.nuget.org/packages/NorthRoc.DivisionMath/)
[![Sponsor](https://img.shields.io/badge/Sponsor-GitHub%20Sponsors-ea4aaa?style=flat&logo=githubsponsors&logoColor=white)](https://github.com/sponsors/Rex-J-W)

</div>

**A cross-platform math library for CPU and GPU that uses the same code everywhere.**

DivisionMath is part of the [Division Engine](https://github.com/NorthRocStudios/DivisionEngine) ecosystem. It is built for a future library, [DivisionTranslate](https://github.com/NorthRocStudios/DivisionTranslate). Together, these two libraries will replace [ComputeSharp](https://github.com/Sergio0694/ComputeSharp) and enable cross-platform builds of Division Engine.

Unlike ComputeSharp, DivisionMath is designed for 1:1 parity math operations on the CPU and GPU with DivisionTranslate. Write your math once, run it on the CPU for tooling and gameplay, then run the same code on the GPU for compute workloads.

## Why DivisionMath?

Math code often gets duplicated: one version for the CPU, another for the GPU. DivisionMath aims to remove that split. The API is designed to be familiar, portable, and dependency-free, so the same vector and matrix operations can move between CPU and GPU code with minimal friction.

## Features

- **Same API on CPU and GPU** — write once, use everywhere.
- **Full swizzling support** — `.xyz`, `.rgb`, `.xy`, and other familiar swizzles.
- **No external dependencies** — lightweight and easy to drop into any project.
- **Cross-platform** — built for modern .NET.
- **CPU/GPU parity** — designed to pair with DivisionTranslate for consistent results.
- **MIT licensed** — free to use in open-source and commercial projects.

## Installation

DivisionMath is available on NuGet:
https://www.nuget.org/packages/NorthRoc.DivisionMath/

Install via the .NET CLI:

```bash
dotnet add package NorthRoc.DivisionMath
```

Or add it directly to your `.csproj`:

```xml
<PackageReference Include="NorthRoc.DivisionMath" Version="*" />
```

## Project Status

DivisionMath is part of the larger Division Engine toolchain. It is under active development, with the goal of providing a consistent math layer for CPU tooling and GPU compute shaders. Keep an eye on DivisionTranslate for the runtime side of the CPU/GPU story.

## Related Projects

- [Division Engine](https://github.com/DivisionEngine/DivisionEngine)
- [DivisionTranslate](https://github.com/DivisionEngine/DivisionTranslate)
- [ComputeSharp](https://github.com/Sergio0694/ComputeSharp) — inspiration for the C#-to-HLSL workflow.

## License

DivisionMath is licensed under the **MIT License**. See [LICENSE](LICENSE) for details.

## Sponsor

If DivisionMath is useful to you, consider supporting development:

[![Sponsor](https://img.shields.io/badge/Sponsor-GitHub%20Sponsors-ea4aaa?style=flat&logo=githubsponsors&logoColor=white)](https://github.com/sponsors/Rex-J-W)
