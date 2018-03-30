dotnet restore
dotnet build
dotnet test test/CoreCITest.Data.Test/CoreCITest.Data.Test.csproj
cd src/CoreCITest.Web
yarn install
./node_modules/.bin/webpack
dotnet watch run
