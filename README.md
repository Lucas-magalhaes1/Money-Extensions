# DecimalToIntegerConverter 🚀

A simple .NET library for converting decimal values to integers with precision handling.

## 📌 Installation

### .NET CLI
```sh
 dotnet add package DecimalToIntegerConverter --version 1.0.1
```

### Package Manager
```sh
Install-Package DecimalToIntegerConverter -Version 1.0.1
```

### PackageReference
Add the following line to your `.csproj` file:

```xml
<PackageReference Include="DecimalToIntegerConverter" Version="1.0.1" />
```

---

## ⚙ Usage

Import the namespace and use the extension method to convert a decimal value to cents (integer representation).

```csharp
using DecimalToIntegerConverter;

decimal value = 12.34m;
int cents = value.ToCents(); // Output: 1234

Console.WriteLine($"Converted: {cents}");
```

---

## 📦 Features

✅ Converts a decimal value to an integer representation.  
✅ Automatically handles precision (2 decimal places).  
✅ Simple and lightweight, ideal for financial calculations.

---

## 🛠 Compatibility

✔ **.NET 9.0+**  
Works with .NET 9.0 or higher frameworks.

---

## 🔗 Repository & Issues

🔗 **[GitHub Repository](https://github.com/Lucas-magalhaes1/Money-Extensions)**  
Feel free to open an issue or contribute to the project! 🚀
