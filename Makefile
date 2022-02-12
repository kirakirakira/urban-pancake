test:
	dotnet test UrbanPancake.LibraryTests/UrbanPancake.LibraryTests.csproj

test-verbose:
	dotnet test UrbanPancake.LibraryTests/UrbanPancake.LibraryTests.csproj --logger:"console;verbosity=detailed"

run:
	dotnet run --project UrbanPancake/UrbanPancake.csproj
