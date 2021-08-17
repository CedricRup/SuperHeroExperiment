module Front.Client.Main

open Elmish
open Bolero
open Bolero.Html
open Bolero.Remoting.Client
open Bolero.Templating.Client
open System.Net.Http
open System.Text.Json
open System.Text.Json.Serialization
open System.Net
open Heroes

type Page =
    | [<EndPoint "/">] Home
    | [<EndPoint "/heroDatabase">] HeroDatabase
    | [<EndPoint "/hero">] HeroResult of string
    
 

let http = new HttpClient()
let serOptions = JsonSerializerOptions()
serOptions.Converters.Add(JsonFSharpConverter())

let getSuperhero baseURI name =
    let request = new HttpRequestMessage(HttpMethod.Get, baseURI +  $"api/hero/{name}")
    request.Headers.Add("token","ASuperSecuredToken")
    async {
        let! response = 
            request
            |> http.SendAsync
            |> Async.AwaitTask
        match response.StatusCode with
            | HttpStatusCode.OK -> 
                let! respBody = response.Content.ReadAsStreamAsync() |> Async.AwaitTask
                let! hero =  JsonSerializer.DeserializeAsync<Hero>(respBody, serOptions).AsTask() |> Async.AwaitTask
                return Some hero
            | HttpStatusCode.NotFound -> return None
            | _ -> 
                failwith "An error occured"
                return None
    }

let searchHeroes baseURI request =
    let request = new HttpRequestMessage(HttpMethod.Get, baseURI +  $"api/search/{request}")
    request.Headers.Add("token","ASuperSecuredToken")
    async {
        let! response = 
            request
            |> http.SendAsync
            |> Async.AwaitTask
        match response.StatusCode with
            | HttpStatusCode.OK -> 
                let! respBody = response.Content.ReadAsStreamAsync() |> Async.AwaitTask
                let! heroes =  JsonSerializer.DeserializeAsync<Hero array>(respBody, serOptions).AsTask() |> Async.AwaitTask
                return heroes
            | _ -> 
                failwith "An error occured"
                return [||]
    }
       
type Model =
    {
        page: Page
        hero : Hero option
        error : string option
        request : string
        heroesFound : Hero array
    }

let initModel =
    {
        page = Home
        hero = None
        error = None
        request = ""
        heroesFound = [||]
    }

type Message =
    | SetPage of Page
    | GetHero of name:string
    | GotHero of Hero option
    | SetRequest of string
    | SearchHeroes
    | HeroesFound of Hero array
    | Error of exn
    | ClearError

let update getHero searchHeroes message model =
    match message with
    | SetPage page ->
        let command =
            match page with
            | HeroResult name -> GetHero name |> Cmd.ofMsg 
            | _ -> Cmd.none
        { model with page = page }, command
    | GetHero name ->
        let cmd = Cmd.OfAsync.either getHero name GotHero Error
        { model with hero = None}, cmd
    | GotHero hero ->
        {model with hero = hero}, Cmd.none
    | SetRequest r ->
        {model with request = r}, Cmd.none
    | SearchHeroes ->
        let cmd = Cmd.OfAsync.either searchHeroes model.request HeroesFound Error
        {model with heroesFound = [||]}, cmd
    | HeroesFound heroes ->
        {model with heroesFound = heroes}, Cmd.none
    | Error ex ->
        {model with error = Some ex.Message}, Cmd.none
    | ClearError ->
        {model with error = None}, Cmd.none

/// Connects the routing system to the Elmish application.
let router = Router.infer SetPage (fun model -> model.page)

type Main = Template<"wwwroot/main.html">

let homePage model dispatch =
    Main.Home().Elt()


let menuItem (model: Model) (page: Page) (text: string) =
    Main.MenuItem()
        .Active(if model.page = page then "is-active" else "")
        .Url(router.Link page)
        .Text(text)
        .Elt()



let heroDatabase model dispatch =
    Main.HeroDatabase()
        .Request(model.request, fun v -> dispatch (SetRequest v))
        .Search(fun _ -> dispatch SearchHeroes)
        .Result(match model.heroesFound with
                | [||] -> text "No heroes corresponding to this request"
                | heroes ->
                    table [][
                        th [] [text "Name"]
                        forEach heroes <| fun hero ->
                            tr [] [
                                td [] [a [hero.name |> HeroResult |> router.Link |> attr.href] [text hero.name]]
                            ]
                    ])
        .Elt()

        
let heroResult model dispatch =
    match model.hero with 
    | None -> text "This hero does not exist" 
    | Some hero ->
        Main.HeroResult()
            .Name(hero.name)
            .Status(hero.status)
            .Sex(hero.sex)
            .Eyes(hero.eyes)
            .Hair(hero.hair)
            .FirstAppearance(hero.firstAppearance)
            .NumberOfAppearances(hero.numberOfAppearances)
            .Alignment(hero.alignment)
            .Elt()

let view model dispatch =
    Main()
        .Menu(concat [
            menuItem model Home "Home"
            menuItem model HeroDatabase "Hero Database"
        ])
        .Body(
            cond model.page <| function
            | Home -> homePage model dispatch
            | HeroDatabase -> heroDatabase model dispatch
            | HeroResult _ -> heroResult model dispatch
        )
        .Error(
            cond model.error <| function
            | None -> empty
            | Some err ->
                Main.ErrorNotification()
                    .Text(err)
                    .Hide(fun _ -> dispatch ClearError)
                    .Elt()
        )
        .Elt()
        
type MyApp() =
    inherit ProgramComponent<Model, Message>()

    override this.Program =
        let update = update (getSuperhero this.NavigationManager.BaseUri) (searchHeroes this.NavigationManager.BaseUri)
        Program.mkProgram (fun _ -> initModel, Cmd.none) update view
        |> Program.withRouter router
#if DEBUG
        |> Program.withHotReload
#endif
