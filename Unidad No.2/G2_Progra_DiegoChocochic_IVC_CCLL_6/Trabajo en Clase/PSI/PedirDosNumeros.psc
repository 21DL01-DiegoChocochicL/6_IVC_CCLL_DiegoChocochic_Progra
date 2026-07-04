Algoritmo PedirDosNumeros
	// Pide dos números y una opción: 1 = Sumar, 2 = Restar, 3 = Multiplicar, 4 = Dividir - Muestra el
	// resultado según la opción elegida.
	// Inicio
	Definir num, num2, sum, rest, multi, divi Como Real
	Definir c Como Cadena
	Escribir 'Diguite dos numeros: '
	Leer num
	Leer num2
	Escribir 'Digame un caracter: '
	Leer c
	// Proceso , Sentencia de Seleccion y Salida
	Según c Hacer
		'Sumar', 'suma', '+':
			Escribir 'La suma es, ', (num+num2)
		'Restar', 'resta', '-':
			Escribir 'La resta es, ', (num-num2)
		'Multiplicacion', 'Multi', 'multi', '*':
			Escribir 'La multi es, ', (num*num2)
		'Dividir', 'dividir', 'divi', '/':
			Escribir 'La multi es, ', (num/num2)
		De Otro Modo:
			Escribir 'Caracter no encontrado'
	FinSegún
FinAlgoritmo
