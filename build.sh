dotnet restore
dotnet build
dotnet test test/CoreCITest.Data.Test/CoreCITest.Data.Test.csproj
cd src/CoreCITest.Web
npm install
./node_modules/.bin/webpack
dotnet watch run
