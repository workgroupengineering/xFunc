packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -register:user -output:coverage.xml -target:"packages\xunit.runner.console.2.1.0\tools\xunit.console.exe" -targetargs:"xFunc.Tests\bin\Release\xFunc.Tests.dll -nologo -noshadow" -filter:"+[xFunc.*]* -[xFunc.Tests*]* -[xFunc.*]*.Resource"
packages\ReportGenerator.2.4.5.0\tools\ReportGenerator.exe coverage.xml .\coverage
pause