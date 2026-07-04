Algoritmo Act4_Lecc9_inciso1
	Definir n, i, resultado Como Entero
	Escribir '*******************************************'
	Escribir '      GENERADOR DE TABLAS DE MULTIPLICAR   '
	Escribir '*******************************************'
	Escribir 'Ingrese el número para la tabla de multiplicar:'
	Leer n
	i <- 1
	Escribir '-------------------------------------------'
	Escribir 'Tabla del ', n, ':'
	Mientras i<=10 Hacer
		resultado <- n*i
		Escribir n, ' x ', i, ' = ', resultado
		i <- i+1
	FinMientras
	Escribir '-------------------------------------------'
	Escribir 'Proceso finalizado.'
	Escribir '*******************************************'
FinAlgoritmo
