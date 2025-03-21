let names = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]

let filteredNames = names |> List.filter (fun name -> name.Contains("i") || name.Contains("I"))

let concatenatedNames = filteredNames |> List.reduce (+)

printfn "%s" concatenatedNames