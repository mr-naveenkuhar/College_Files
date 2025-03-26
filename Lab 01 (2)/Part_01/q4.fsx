let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]

let trimmedNames = names |> List.map (fun name -> name.Trim())

trimmedNames |> List.iter (printfn "%s")