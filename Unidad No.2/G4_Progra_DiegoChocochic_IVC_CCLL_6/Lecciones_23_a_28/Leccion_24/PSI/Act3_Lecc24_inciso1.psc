Algoritmo Act3_Lecc10_inciso1
	Definir num, i, divisores, suma Como Entero
	suma <- 0
	Escribir '*******************************************'
	Escribir '    SUMATORIA DE NÚMEROS PRIMOS (1-22)     '
	Escribir '*******************************************'
	Para num<-1 Hasta 22 Hacer
		divisores <- 0
		Para i<-1 Hasta num Hacer
			Si num MOD i==0 Entonces
				divisores <- divisores+1
			FinSi
		FinPara
		Si divisores==2 Entonces
			suma <- suma+num
			Escribir num, ' (Primo)'
		FinSi
	FinPara
	Escribir '-------------------------------------------'
	Escribir 'La suma total de los números primos es: ', suma
	Escribir '*******************************************'
FinAlgoritmo
