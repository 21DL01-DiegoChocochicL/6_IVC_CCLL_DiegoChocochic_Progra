Algoritmo Act2_Lecc15_inciso1
	Definir num, i, divisores, contPrimos, sumaPrimos Como Entero
	contPrimos <- 0
	sumaPrimos <- 0
	Escribir '*******************************************'
	Escribir '      ANÁLISIS DE NÚMEROS PRIMOS (1-100)   '
	Escribir '*******************************************'
	Para num<-1 Hasta 100 Hacer
		divisores <- 0
		Para i<-1 Hasta num Hacer
			Si num MOD i=0 Entonces
				divisores <- divisores+1
			FinSi
		FinPara
		Si divisores=2 Entonces
			contPrimos <- contPrimos+1
			sumaPrimos <- sumaPrimos+num
		FinSi
	FinPara
	Escribir '-------------------------------------------'
	Escribir 'Cantidad de números primos: ', contPrimos
	Escribir 'Suma de los números primos: ', sumaPrimos
	Escribir '*******************************************'
FinAlgoritmo
