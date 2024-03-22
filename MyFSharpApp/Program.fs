// For more information see https://aka.ms/fsharp-console-apps
//Bipana Jirel
//22071147
printfn " Bipana Jirel"
[1..100] |> List.sum |> printfn "sum=%d"
// automatic equality and comparison
type Person = { First:string; Last:string }
let person1 = { First = "John"; Last = "Doe" }
let person2 = { First = "Alex"; Last = "Lan" }
printfn "Equal? %A" (person1 = person2)
// strict type checking
printfn "print string %s" 123
//compile error // all values immutable by default
person1.First <- "new name" //assignment error
// impure code(ability to assign) when needed
let mutable counter = 0