# sqlserver_docker_sample

Sample for running SQLServer on Docker using docker-compose. The docker-compose file contains two Docker images:
SQL Server and a web application. The web application connects to the database.

## running:

1] Run Docker-compose build

```
$ docker-compose build
```

2] Run docker-compose up

```
$ docker-compose up
```

Note: It takes a few seconds to startup SQLServer

3] Request /db on port 81

```
$ curl http://localhost:81/db
```

Expected result: connection succeeded

4] Connect to database using SqlCmd

```
$ sqlcmd -S 127.0.0.1 -U sa -P "Yoyoyo800"
1> select DB_NAME()
2> GO
                                                                                                                       
--------------------------------------------------------------------------------------------------------------------------------
master
```

## Remarks


- Memory usage

Memory usage can be inspected using:

```
$ docker stats
b4d74b936eac   sqlserver_docker_sample_database_1   0.85%     762.3MiB / 12.31GiB   6.05%     948B / 42B   0B / 0B     180
2334f11915e9   sqlserver_docker_sample_service_1    0.04%     33.97MiB / 12.31GiB   0.27%     858B / 0B    0B / 0B     29
```

Database is taking about 760MB memory

## todo

Describe how to initialize database with schema











