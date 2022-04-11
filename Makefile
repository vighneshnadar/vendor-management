PROJECT_NAME ?= solarp
ORG_NAME ?= solarp
REPO_NAME ?= vendor-management

.PHONY: migrations db
migrations:
	cd ./solarp.data && dotnet ef --startup-project ../solarp.web/ migrations add $(mname) && cd ..

db:
	cd ./solarp.data && dotnet ef --startup-project ../solarp.web/ database update && cd ..