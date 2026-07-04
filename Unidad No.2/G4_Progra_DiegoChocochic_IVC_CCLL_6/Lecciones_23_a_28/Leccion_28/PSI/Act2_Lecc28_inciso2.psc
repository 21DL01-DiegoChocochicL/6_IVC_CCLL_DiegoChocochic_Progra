Algoritmo Act2_Lecc15_inciso2
	Definir denominacion, cont100, suma100, i Como Entero
	cont100 <- 0
	suma100 <- 0
	i <- 1
	Escribir '*******************************************'
	Escribir '       CONTADOR DE BILLETES DE $100        '
	Escribir '*******************************************'
	Escribir 'Nota: Ingrese 0 en cualquier momento para terminar.'
	Mientras i<=1000 Hacer
		Escribir '-------------------------------------------'
		Escribir 'Billete #', i, ' (Ingrese 20, 50, 100, o 0 para salir):'
		Leer denominacion
		Si denominacion=0 Entonces
			Escribir '>> [AVISO]: Proceso cancelado por el usuario.'
			i <- 1001
		SiNo
			Si denominacion=100 Entonces
				cont100 <- cont100+1
				suma100 <- suma100+100
				Escribir '>> [ÉXITO]: Billete de $100 registrado.'
			SiNo
				Escribir '>> [INFO]: Billete registrado (distinto a $100).'
			FinSi
			i <- i+1
		FinSi
	FinMientras
	Escribir '*******************************************'
	Escribir '             REPORTE FINAL                 '
	Escribir '*******************************************'
	Escribir 'Total de billetes de $100: ', cont100
	Escribir 'Total de dinero en billetes de $100: $', suma100
	Escribir '*******************************************'
FinAlgoritmo
