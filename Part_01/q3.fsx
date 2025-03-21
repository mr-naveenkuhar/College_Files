let rec productOddTailRec n acc =
        if n <= 1 then acc
        else productOddTailRec (n - 2) (acc * n)

let productOdd n = productOddTailRec n 1

printfn "Product of odd numbers from 12 to 1: %d" (productOdd 12)