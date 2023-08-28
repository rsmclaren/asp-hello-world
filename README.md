## Running locally
To start the kestral server use the following command

```
dotnet watch
```

to run with https enabled

```
dotnet watch --launch-profile https
```

## Trusting dev certs
To trust the dev certs run the following command

```
dotnet dev-certs https --trust
```