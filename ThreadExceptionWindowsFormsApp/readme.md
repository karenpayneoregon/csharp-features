# About

Simple code sample for application-wide exception handler to write unhandled exceptions to a log file.

# Prerequisites

To run this project *as is* in this repository.

- VS2019
- .NET Core 5


# Get source without all projects 

With Git installed, create a batch file with the following contents, save, run and add the cloned projects to your solution.
```batch
mkdir code
cd code
git init
git remote add -f origin https://github.com/karenpayneoregon/csharp-features
git sparse-checkout init --cone
git sparse-checkout add ExceptionHandling
git sparse-checkout add ThreadExceptionWindowsFormsApp
git pull origin master
:clean-up
del .gitattributes
del .gitignore
del .yml
del .editorconfig
del *.md
del *.sln
```
