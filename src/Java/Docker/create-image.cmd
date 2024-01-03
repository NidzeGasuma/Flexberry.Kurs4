docker build --no-cache -f SQL\Dockerfile.PostgreSql -t kurs4-java/postgre-sql ../../SQL

docker build --no-cache -f Dockerfile -t kurs4-java/app ../../..
