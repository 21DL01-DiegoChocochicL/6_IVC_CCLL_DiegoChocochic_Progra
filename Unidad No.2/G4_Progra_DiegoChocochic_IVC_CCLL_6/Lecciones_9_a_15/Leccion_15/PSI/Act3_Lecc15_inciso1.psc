Algoritmo Act3_Lecc15_inciso1
	Definir i, multiplo, suma, contPares Como Entero
	suma <- 0
	contPares <- 0
	Escribir '*******************************************'
	Escribir '      ANÁLISIS DE MÚLTIPLOS DE 7           '
	Escribir '*******************************************'
	Escribir 'Calculando los primeros 20 múltiplos de 7:'
	Escribir '-------------------------------------------'
	Para i<-1 Hasta 20 Hacer
		multiplo <- i*7
		Escribir '#', i, ': ', multiplo
		suma <- suma+multiplo
		Si multiplo MOD 2=0 Entonces
			contPares <- contPares+1
		FinSi
	FinPara
	Escribir '-------------------------------------------'
	Escribir 'RESULTADOS DEL PROCESO:'
	Escribir 'La suma total es: ', suma
	Escribir 'Cantidad de múltiplos pares: ', contPares
	Escribir '*******************************************'
FinAlgoritmo
