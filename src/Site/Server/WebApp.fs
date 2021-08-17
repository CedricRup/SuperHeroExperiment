module WebApp
open Giraffe
open Microsoft.AspNetCore.Http
open Heroes

let generateWebApp heroes = 

    let checkToken : HttpHandler = fun (next : HttpFunc) (ctx : HttpContext) ->
        match ctx.TryGetRequestHeader "token" with 
            | Some "ASuperSecuredToken" -> next ctx
            | _ -> let handler = setStatusCode 401 >=> setBodyFromString "You don't have the token header... Are you a villain?"
                   handler earlyReturn ctx
   

    let getHeroHandler name : HttpHandler =
        findHero heroes name
            |> function
                | Some h -> json h
                | _ -> setStatusCode 404
    
    let searchHeroHandler (name:string) : HttpHandler = 
        searchHeroes heroes name
        |> Seq.truncate 10
        |> json

    routeStartsWith "/api/" >=> 
        checkToken  >=> 
        choose [
            routex "/api/hero(/?)" >=> setStatusCode 404
            routef "/api/hero/%s" getHeroHandler
            routef "/api/search/%s" searchHeroHandler
        ]

    


