
fibore :: [Integer]
fibore = aux 0 1 1
 where aux a b c = a: aux b c (a+b+c)

main = do
  putStrLn "ingrese el numero de fibonaccis a imprimir : "
  numero <- getLine
  let nn = read numero :: Int
  let fib = print(take nn fibore)
  fib