module Heroes
open System

type Hero = {
    name : string
    eyes : string
    status : string
    firstAppearance : string
    hair : string
    alignment : string
    secret : string
    sex: string
    numberOfAppearances : string
}

let findHero heroes (name:string) = 
    heroes
    |>  Seq.tryFind (fun h -> name.Equals(h.name,StringComparison.InvariantCultureIgnoreCase))

let searchHeroes heroes (name:string) =
    heroes
    |> Seq.filter (fun h -> h.name.Contains(name,StringComparison.InvariantCultureIgnoreCase))