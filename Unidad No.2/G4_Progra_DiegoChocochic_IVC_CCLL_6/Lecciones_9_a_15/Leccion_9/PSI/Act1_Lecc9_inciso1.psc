Algoritmo Act1_Lecc9_inciso1
	Definir pesoMan, pesoTt, contadorManzanas Como Entero
	pesoTt <- 0
	contadorManzanas <- 0
	Escribir '*******************************************'
	Escribir '      CONTROL DE PESO DE MANZANAS          '
	Escribir '*******************************************'
	Mientras pesoTt<1000 Hacer
		Escribir 'Ingrese el peso de la manzana (en gramos): '
		Leer pesoMan
		Si pesoMan>=180 Entonces
			pesoTt <- pesoTt+pesoMan
			Escribir 'Peso total actual: ', pesoTt, 'g'
			contadorManzanas <- contadorManzanas+1
		SiNo
			Escribir 'Error: La manzana es muy pequeña (mínimo 180g).'
		FinSi
	FinMientras
	Escribir '-------------------------------------------'
	Escribir 'Se ha alcanzado o superado el límite de 1000g.'
	Escribir 'Peso final: ', pesoTt, 'g. Total de manzanas: ', contadorManzanas, '.'
	Escribir '*******************************************'
FinAlgoritmo
