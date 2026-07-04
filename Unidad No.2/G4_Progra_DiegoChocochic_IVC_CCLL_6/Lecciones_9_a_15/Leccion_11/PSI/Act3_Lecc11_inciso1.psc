Algoritmo Act3_Lecc11_inciso1
	Definir n1, n2, menor, mayor, i, suma Como Entero
	suma <- 0
	Escribir '*******************************************'
	Escribir '      SUMATORIA DE RANGO NUMÉRICO          '
	Escribir '*******************************************'
	Escribir 'Ingrese el primer número:'
	Leer n1
	Escribir 'Ingrese el segundo número:'
	Leer n2
	Si n1<n2 Entonces
		menor <- n1
		mayor <- n2
	SiNo
		menor <- n2
		mayor <- n1
	FinSi
	i <- menor
	Repetir
		suma <- suma+i
		i <- i+1
	Hasta Que i>mayor
	Escribir '-------------------------------------------'
	Escribir 'La suma de los números entre ', menor, ' y ', mayor, ' es: ', suma
	Escribir '*******************************************'
FinAlgoritmo
