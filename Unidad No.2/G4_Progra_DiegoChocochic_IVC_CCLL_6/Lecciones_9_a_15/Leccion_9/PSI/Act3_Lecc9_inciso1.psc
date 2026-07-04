Algoritmo Act3_Lecc9_inciso1
	Definir n, i Como Entero
	Escribir '*******************************************'
	Escribir '      GENERADOR DE SECUENCIA NUMÉRICA      '
	Escribir '*******************************************'
	Escribir 'Ingrese un número mayor a 20:'
	Leer n
	Si n<20 Entonces
		Escribir '>> [ERROR]: El número debe ser mayor a 20.'
	SiNo
		i <- 21
		Escribir '-------------------------------------------'
		Escribir 'Secuencia generada:'
		Mientras i<=n Hacer
			Escribir i
			i <- i+2
		FinMientras
		Escribir '-------------------------------------------'
		Escribir 'Proceso finalizado.'
	FinSi
FinAlgoritmo
