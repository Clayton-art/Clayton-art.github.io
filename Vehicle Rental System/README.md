# Vehicle Rental System (C++)

This workspace contains a simple object-oriented Vehicle Rental System demo in C++, now organized into headers and source files.

Structure:
- `include/` — public headers (Vehicle, Car, Motorcycle, Truck, Customer, Rental, RentalSystem)
- `src/` — implementation files
- `main.cpp` — small entrypoint that demonstrates loading sample data
- `CMakeLists.txt` — simple build configuration

Build (recommended: MSYS2/MinGW or WSL):

Using CMake + g++ (PowerShell example):
```powershell
mkdir build; cd build
cmake .. -G "MinGW Makefiles"
mingw32-make
```

Or with MSVC (Developer x64 Native Tools Command Prompt):
```powershell
mkdir build; cd build
cmake ..
cmake --build . --config Release
```

If you want, I can also add a `.vscode/c_cpp_properties.json` and a debug task next.
