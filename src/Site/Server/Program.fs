module SuperHeroExperiment
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting

open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open Giraffe
open Bolero.Server
open Bolero.Templating.Server
open WebApp


let heroes = HeroesCSVLoader.loadFromFile "collection.csv"
  
let configureApp (app : IApplicationBuilder) =
    app.UseGiraffe (generateWebApp heroes)
    app
        .UseStaticFiles()
        .UseRouting()
        .UseBlazorFrameworkFiles()
        .UseEndpoints(fun endpoints ->
            endpoints.MapBlazorHub() |> ignore
            endpoints.MapFallbackToBolero(Front.Index.page) |>ignore)
        |> ignore

let configureServices (services : IServiceCollection) =
    services.AddMvc() |> ignore
    services.AddGiraffe().AddServerSideBlazor() |> ignore
    services.AddBoleroHost() |> ignore
#if DEBUG
    services.AddHotReload(templateDir = __SOURCE_DIRECTORY__ + "/../Front.Client") |> ignore
#endif



let buildHost() = 
    Host.CreateDefaultBuilder()
        .ConfigureWebHostDefaults(
            fun webHostBuilder ->
                webHostBuilder
                    .Configure(configureApp)
                    .ConfigureServices(configureServices)
                |> ignore
            )
        
        .Build()
        
[<EntryPoint>]
let main _ =
    buildHost().Run()
    0