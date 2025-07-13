# Create the DLL

1. Clone [astc-encoder](https://github.com/ARM-software/astc-encoder)

2. In Visual Studio, enable Workload 'Desktop development with C++'.

3. In Visual Studio, download Window SDK and note its version.

4. Replace 'CMakeLists.txt' under `astc-encoder` with [this](./CMakeLists.txt). Make modification if you need to.

5. Add 'astc_wrapper.cpp' under `Source`. If you want to add new functions you should implement them in this class. 

6. Follow these steps to build DLL.
``` Cmd
===== Open terminal =====
In Start, type 'x64 Native Tools Command Prompt for VS 2022' and open it.

===== Build =====
cd to folder astc-encoder,

> rmdir /s /q build
> mkdir build
> cd build
> cmake .. -G "Visual Studio 17 2022" -A x64 -DCMAKE_SYSTEM_VERSION=10.0.26100.0
> cmake --build . --config Release

*note*: replace with your VS and Windows SDK version.

===== Check functions in DLL =====
cd to folder build/Release,

> dumpbin /EXPORTS astc_decoder.dll

Make sure you see something like:
ordinal hint RVA      name
      1    0 00001010 DecodeASTC
```
