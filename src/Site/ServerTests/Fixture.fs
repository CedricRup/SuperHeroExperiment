namespace BackTests
open System
open SuperHeroExperiment
open Xunit

module Fixtures =
    type WebFixture() =
        let host = buildHost()
        do
            host.StartAsync() |> ignore
        interface IDisposable with
            member this.Dispose() =
                host.Dispose()

    [<CollectionDefinition("Endpoints")>]
    type EndPointCollection () =
     interface ICollectionFixture<WebFixture>
