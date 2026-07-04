Algoritmo Act3_Lecc9_inciso2
	Definir n, i Como Entero
	Definir esPrimo Como Lógico
	Escribir '*******************************************'
	Escribir '        VERIFICADOR DE NÚMEROS PRIMOS      '
	Escribir '*******************************************'
	Escribir 'Ingrese un número entero:'
	Leer n
	esPrimo <- Verdadero
	i <- 2
	Si n<=1 Entonces
		esPrimo <- Falso
	SiNo
		Mientras i<=rc(n) Y esPrimo=Verdadero Hacer
			Si n MOD i=0 Entonces
				esPrimo <- Falso
			FinSi
			i <- i+1
		FinMientras
	FinSi
	Escribir '-------------------------------------------'
	Si esPrimo Entonces
		Escribir 'Resultado: ', n, ' ES un número primo.'
	SiNo
		Escribir 'Resultado: ', n, ' NO es un número primo.'
	FinSi
	Escribir '*******************************************'
FinAlgoritmo
