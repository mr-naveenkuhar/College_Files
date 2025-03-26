let raiseTo exponent value = pown value exponent

let square = raiseTo 2
let cube = raiseTo 3

printfn "Square 3 = %d" (square 3)  
printfn "Square 4 = %d" (square 4)  
printfn "Cube 2 = %d" (cube 2)    
printfn  "Cube 3 = %d" (cube 3)