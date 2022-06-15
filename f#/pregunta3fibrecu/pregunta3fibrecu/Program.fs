// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

let rec fibrec(n: int):int = 
    match n with
    | 0 -> 0
    | 1 -> 0
    | 2 -> 1
    | n -> fibrec (n-1) + fibrec (n-2) + fibrec(n-3)

let fibonacci_rec(funcion,x:int) =
    for i in 1 .. x do
     printfn "%d" (funcion i)


[<EntryPoint>]
let main argv = 
    Console.WriteLine("ingrese el numero de fibonaccis a imprimir : ");
    let numero=int(Console.ReadLine());
    Console.WriteLine("los numeros fibonacci son ");
    fibonacci_rec(fibrec, numero)
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero