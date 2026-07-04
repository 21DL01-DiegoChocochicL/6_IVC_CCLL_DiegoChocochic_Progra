Algoritmo Act3_Lecc11_inciso2
	Definir num, suma Como Entero
	suma <- 0
	Escribir '*******************************************'
	Escribir '         SUMADOR DE VALORES LIBRES         '
	Escribir '*******************************************'
	Escribir 'Ingrese los números que desea sumar.'
	Escribir '>> (Ingrese el número 9 para terminar y ver el total):'
	Escribir '-------------------------------------------'
	Repetir
		Leer num
		Si num<>9 Entonces
			suma <- suma+num
			Escribir '  + Valor acumulado: ', suma
		FinSi
	Hasta Que num=9
	Escribir '-------------------------------------------'
	Escribir '¡Proceso finalizado!'
	Escribir 'La suma total es: ', suma
	Escribir '*******************************************'
FinAlgoritmo
