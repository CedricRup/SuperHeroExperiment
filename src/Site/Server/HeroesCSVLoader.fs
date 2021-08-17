module HeroesCSVLoader
open FSharp.Data
open FSharp.Data.CsvExtensions
open Heroes

let loadFromFile (filename:string) =
    let toHero h : Hero = {
        name = h?NAME;
        eyes = h?EYE;
        status = h?ALIVE;
        firstAppearance = h.Item "FIRST APPEARANCE";
        hair = h?HAIR;
        alignment = h?ALIGN;
        secret = h?SECRET;
        sex = h?SEX;
        numberOfAppearances = h?APPEARANCES
    }

    CsvFile.Load(filename).Rows |> Seq.map toHero

