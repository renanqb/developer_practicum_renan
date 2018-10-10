nuget.exe restore "developer_practicum_renan.sln"

"C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" /t:Rebuild "developer_practicum_renan\developer_practicum_renan.csproj"

"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\MSTest.exe" /testcontainer:developer_practicum_renan\developer_practicum_renan_unit_tests\bin\Debug\developer_practicum_renan_unit_tests.dll