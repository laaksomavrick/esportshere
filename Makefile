.PHONY: run format up psql

run:
	dotnet run

format:
	dotnet-format -f .

up:
	docker-compose up

psql:
	@psql --host=localhost --port=5432 --user=postgres