.PHONY: test
test:
	dotnet test UrbanPancake.LibraryTests/UrbanPancake.LibraryTests.csproj

.PHONY: test-verbose
test-verbose:
	dotnet test UrbanPancake.LibraryTests/UrbanPancake.LibraryTests.csproj --logger:"console;verbosity=detailed"

.PHONY: run
run:
	dotnet run --project UrbanPancake/UrbanPancake.csproj

.PHONY: restore
restore:
	cd UrbanPancake; dotnet restore
