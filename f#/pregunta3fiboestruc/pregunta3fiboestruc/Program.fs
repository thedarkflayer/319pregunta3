// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

let fiboestr (n:int) = 
    let mutable a=(-1)
    let mutable b=1
    let mutable c=0
    let mutable d=0
    for i in 1..(n-1) do
        a<-b
        b<-c
        c<-d
        d<-a+b+c
    d

let fibonacci_estru(funcion,n:int) =
    for i in 1..n do
     printfn "%A" (funcion i)


[<EntryPoint>]
let main argv = 
    Console.WriteLine("ingrese el numero de fibonaccis a imprimir : ");
    let numero=int(Console.ReadLine());
    Console.WriteLine("los numeros fibonacci son ");
    fibonacci_estru(fiboestr, numero)

    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
