module Front.Index

open Bolero
open Bolero.Html
open Bolero.Server.Html


let page = doctypeHtml [] [
    head [] [
        meta [attr.charset "UTF-8"]
        meta [attr.name "viewport"; attr.content "width=device-width, initial-scale=1.0"]
        title [] [text "Super Hero Experiment"]
        ``base`` [attr.href "/"]
        link [attr.rel "stylesheet"; attr.href "https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.4/css/bulma.min.css"]
        link [attr.rel "stylesheet"; attr.href "css/index.css"]
    ]
    body [] [
        nav [attr.classes ["navbar"; "is-dark"]; "role" => "navigation"; attr.aria "label" "main navigation"] [
            div [attr.classes ["navbar-brand"]] [
                span [attr.classes ["navbar-item"; "has-text-weight-bold"; "is-size-5"]] [
                    text "The Super Hero Experiment"
                ]
            ]
        ]
        div [attr.id "main"] [rootComp<Client.Main.MyApp>]
        boleroScript
    ]
]
