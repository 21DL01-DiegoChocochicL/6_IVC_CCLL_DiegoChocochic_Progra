Algoritmo Act3_Lecc15_inciso2
	Definir num, i, divisores, contPrimos, sumaPares, j Como Entero
	contPrimos <- 0
	sumaPares <- 0
	Escribir '*******************************************'
	Escribir '   ANÁLISIS MATEMÁTICO: PRIMOS Y PARES     '
	Escribir '*******************************************'
	Para num<-300 Hasta 1 Con Paso -1 Hacer
		divisores <- 0
		Para i<-1 Hasta num Hacer
			Si num MOD i=0 Entonces
				divisores <- divisores+1
			FinSi
		FinPara
		Si divisores=2 Entonces
			contPrimos <- contPrimos+1
		FinSi
	FinPara
	Para j<-1 Hasta 300 Hacer
		Si j MOD 2=0 Entonces
			sumaPares <- sumaPares+j
		FinSi
	FinPara
	Escribir '-------------------------------------------'
	Escribir 'Cantidad de números primos (300 a 1): ', contPrimos
	Escribir 'Suma de los números pares (1 a 300): ', sumaPares
	Escribir '-------------------------------------------'
	Escribir '*******************************************'
FinAlgoritmo
