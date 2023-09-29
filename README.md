# EnvisionStudioPokemonAPI

*Envision Studio Pokemon API Assessment*

## Prerequisites

Before you begin, ensure you have met the following requirements:

- **.NET SDK**: You need to have the .NET SDK installed. You can download it from [dotnet.microsoft.com](https://dotnet.microsoft.com/download).

## Getting Started

To set up and run this project, follow these steps:

1. **Clone the repository**:

```shell
git clone https://github.com/m1771vw/EnvisionStudioPokemonAPI.git
```
2. **Navigate to the project directory:**

```shell
cd EnvisionStudioPokemonAPI
```

3. **Restore dependencies:**
Use the following command to restore the project dependencies:
```
dotnet restore
```
4. **Build the project:**
Build the project using the following command:

```
dotnet build
```

### Entity Framework Core with SQLite

This project uses Entity Framework Core with SQLite as the database provider. Follow these steps to set up and configure the database:

#### Prerequisites

Make sure you have the .NET CLI installed on your system.

#### Database Migration

1. Open a terminal and navigate to the project directory:

```
cd EnvisionStudioPokemonAPI
```
2. Run the following command to apply migrations using the dotnet-ef global tool:

```
dotnet ef database update
```
If the dotnet-ef global tool is not installed on your system, you can install it using the following command:
```
dotnet tool install --global dotnet-ef
```
Another alternative is to open the `EnvisionStudioPokemonAPI.sln` and in the `Package Manager Console` run `Update-Database`

5. **Run the project:**
To run the project, use the dotnet run command:

```
dotnet run
```
This will start your application, and you can access it by opening a web browser and navigating to http://localhost:44360 or https://localhost:7182.

Another alternative is to open the `EnvisionStudioPokemonAPI.sln` and press F5 or press EnvisionStudioPokemonAPI at the top with the green button.

You might have to select IISExpress and run it that way.

6. **Access the application:**
Once the application is running, open your web browser and go to http://localhost:44360 or https://localhost:7182 to access the application.

## Extra Notes

Apologies in advance, I only worked on it for a couple days and probably spent maybe 8 to 12 hours on this. Never used Razor pages before so I had to pick it up as I went.

There's no proper error handling and no loading animations. 

Am open to discussing more about design choices in the future.

Definitely made some shortcut decisions to make it work.

Also not familiar with SQLITE so I don't know if the set up instructions are correct but hopefully the migration works fine.