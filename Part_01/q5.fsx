// Create a sequence of the first 700 positive integers
let numbers = seq { 1 .. 700 }

// Convert the sequence into a list
let numberList = Seq.toList numbers

// Filter out elements that are multiples of both 7 and 5
let filteredNumbers = List.filter (fun x -> x % 7 = 0 && x % 5 = 0) numberList

// Sum all the filtered numbers
let sumOfFilteredNumbers = List.reduce (+) filteredNumbers

// Print the result
printfn "The sum of all numbers that are multiples of both 7 and 5 is: %d" sumOfFilteredNumbers