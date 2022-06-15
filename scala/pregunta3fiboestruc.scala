object fibonacci {

	def fibonacci_estruc(funcion:(Int)=>Int,m: Int):Unit = {
	for (i <-0 to (m-1)){
	System.out.print(funcion(i)+" ")
	}
	}

	def fiboestru(n: Int):Int = {
	var a = -1
	var b = 1
	var c = 0
	var d = 0
	var i = 0
	while( i < n ) {
	a = b
	b = c
	c = d
	i = i + 1
	d = a + b + c
	}
	return d
	}
  

	def main(args:Array[String]):Unit = {
	println("ingrese el numero de fibonaccis a imprimir : ")
	val a = scala.io.StdIn.readInt()
	fibonacci_estruc(fiboestru, a)
	}
	
	
}