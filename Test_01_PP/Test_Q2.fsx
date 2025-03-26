let sumMultiplesOf3 n =
    let rec loop current acc =
        if current > n then acc
        else loop (current + 3) (acc + current)
    loop 3 0
printf "Enter a number: "
let userInput = System.Console.ReadLine() |> int
printfn "%d" (sumMultiplesOf3 userInput)