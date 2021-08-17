module Endpoints

open FsHttp
open Xunit
open FsHttp.DslCE
open FsUnit.Xunit
open FSharp.Data

[<Collection("Endpoints")>]
type ``Hero`` () =

    let askForHero name  = httpLazy {
        GET $"http://localhost:5000/api/hero/{name}"
    }

    let withCorrectToken (request:LazyHttpBuilder<HeaderContext>) = 
        request {Header "token" "ASuperSecuredToken" }

    let getProperty propertyName response = 
        response
        |> Response.toJson
        |> fun json -> json.TryGetProperty(propertyName).Value.AsString()
    
    let requestHero name = askForHero name |> withCorrectToken |> Request.send

    [<Fact>]
    let ``Can find hero with exact name`` () =
        requestHero "Superman"
        |> fun res -> res.statusCode
        |> should equal System.Net.HttpStatusCode.OK

    [<Fact>]
    let ``Can find hero with case insensitive name`` () =
        requestHero "supErman"
        |> fun res -> res.statusCode
        |> should equal System.Net.HttpStatusCode.OK

    [<Fact>]
    let ``Gives 404 if hero does not exists`` () =
        requestHero "cedric"
        |> fun res -> res.statusCode
        |> should equal System.Net.HttpStatusCode.NotFound

    [<Fact>]
    let ``Gives 404 no hero name given`` () =
        httpLazy{
        GET "http://localhost:5000/api/hero"
        }
        |> withCorrectToken
        |> Request.send
        |> fun res -> res.statusCode
        |> should equal System.Net.HttpStatusCode.NotFound

    [<Fact>]
    let ``Can have name about existing hero`` () =
        requestHero "Superman"
        |> getProperty "name"
        |> should equal "Superman"

    [<Fact>]
    let ``Can have eye color about existing hero`` () =
        requestHero "Superman"
        |> getProperty "eyes"
        |> should equal "Blue Eyes"

    [<Fact>]
    let ``Can have status about existing hero`` () =
        requestHero "Superman"
        |> getProperty "status"
        |> should equal "Living Characters"
        
    [<Fact>]
    let ``Can have first appearance about existing hero`` () =
        requestHero "Superman"
        |> getProperty "firstAppearance"
        |> should equal "1986, October"

    [<Fact>]
    let ``Can have hair about existing hero`` () =
        requestHero "Superman"
        |> getProperty "hair"
        |> should equal "Black Hair" 
        
    [<Fact>]
    let ``Can have alignement about existing hero`` () =
        requestHero "Superman"
        |> getProperty "alignment"
        |> should equal "Good Characters"  

    [<Fact>]
    let ``Can have alignement about existing hero`` () =
        requestHero "Superman"
        |> getProperty "secret"
        |> should equal "306d4916-f75e-4af8-a3a9-33ae1c1e2a52"  
        
    
    [<Fact>]
    let ``Can have alignement about existing hero`` () =
        requestHero "Superman"
        |> getProperty "sex"
        |> should equal "Male Characters" 
        
    [<Fact>]
    let ``Can have number of appearances about existing hero`` () =
        requestHero "Superman"
        |> getProperty "numberOfAppearances"
        |> should equal "2496" 
        
    [<Fact>]
    let ``Failing to give the token leads to 401`` () =
        askForHero "Superman"
        |> Request.send
        |> fun res -> res.statusCode
        |> should equal System.Net.HttpStatusCode.Unauthorized
    
    [<Fact>]
    let ``Giving a wrong token leads to 401`` () =
        askForHero "Superman" {Header "token" "glop"}
        |> Request.send
        |> fun res -> res.statusCode
        |> should equal System.Net.HttpStatusCode.Unauthorized

    [<Fact>]
    let ``Giving a wrong token gives a warning text`` () =
        askForHero "Superman" {Header "token" "glop"}
        |> Request.send
        |> Response.toText
        |> should equal "You don't have the token header... Are you a villain?"
   
   [<Collection("Endpoints")>]
   type ``Search`` () =

    let search name  = httpLazy {
        GET $"http://localhost:5000/api/search/{name}"
    }

    let withCorrectToken (request:LazyHttpBuilder<HeaderContext>) = 
        request {Header "token" "ASuperSecuredToken" }

    let getProperty propertyName response = 
        response
        |> Response.toJson
        |> fun json -> json. TryGetProperty(propertyName).Value.AsString()
    
    let doAuthorizedSearch name = search name |> withCorrectToken |> Request.send

    [<Fact>]
    let ``A correct search gives a OK`` () =
        doAuthorizedSearch "Superman"
        |> fun res -> res.statusCode
        |> should equal System.Net.HttpStatusCode.OK


    [<Fact>]
    let ``Making a request with exact name return a least this hero`` () =
        doAuthorizedSearch "Superman"
        |> Response.toJsonArray
        |> Array.map (fun h -> h.GetProperty("name").AsString())
        |> should contain "Superman"

    [<Fact>]
    let ``Making a request with partial name return a least this hero`` () =
        doAuthorizedSearch "perman"
        |> Response.toJsonArray
        |> Array.map (fun h -> h.GetProperty("name").AsString())
        |> should contain "Superman"

    [<Fact>]
    let ``It's case insensitive`` () =
        doAuthorizedSearch "pErMan"
        |> Response.toJsonArray
        |> Array.map (fun h -> h.GetProperty("name").AsString())
        |> should contain "Superman"

    [<Fact>]
    let ``10 responses max`` () =
        doAuthorizedSearch "a"
        |> Response.toJsonArray
        |> Array.length
        |> should  equal 10

    [<Fact>]
    let ``Gives an empty json array if no match`` () =
        doAuthorizedSearch "Cédric Rup"
        |> Response.toJsonArray
        |> Array.length
        |> should  equal 0

    [<Fact>]
    let ``Gives 200 if no match`` () =
        doAuthorizedSearch "Cédric Rup"
        |> fun res -> res.statusCode
        |> should equal System.Net.HttpStatusCode.OK

    [<Fact>]
    let ``Gives 401 if no token provided`` () =
        search "Superman"
        |> Request.send
        |> fun res -> res.statusCode
        |> should equal System.Net.HttpStatusCode.Unauthorized

    [<Fact>]
    let ``Gives 401 if wrong token provided`` () =
        search "Superman"{
            Header "token" "wrong"
        }
        |> Request.send
        |> fun res -> res.statusCode
        |> should equal System.Net.HttpStatusCode.Unauthorized