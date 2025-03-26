let rec productTailRec lst acc =
    match lst with
    | [] -> acc
    | head :: tail -> productTailRec tail (acc * head)

let product lst = productTailRec lst 1

// Example usage
let numbers = [1; 2; 3; 4; 5]
let result = product numbers
printfn "The product of the list is %d" result