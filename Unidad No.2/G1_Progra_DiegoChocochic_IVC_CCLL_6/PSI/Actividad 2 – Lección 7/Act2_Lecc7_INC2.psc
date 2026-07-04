Algoritmo Act2_Lecc7_INC2
	// Inicio
	Definir N Como Cadena
	Definir cali Como Real
	Escribir 'Digame el nombre de la clase:'
	Leer N
	Escribir 'Digame la calificacion de esta: '
	Leer cali
	// Proceso, Salida y evaluar
	Si cali<=69 Entonces
		Escribir N, ' su calificacion indica que su calificacion es deficiente.'
	SiNo
		Si cali<=79 Entonces
			Escribir N, ' su calificacion indica que su calificacion es regular.'
		SiNo
			Si cali<=89 Entonces
				Escribir N, ' su calificacion indica que su calificacion es Buena.'
			SiNo
				Si cali<=95 Entonces
					Escribir N, ' su calificacion indica que su calificacion es muy buena.'
				SiNo
					Escribir N, ' su calificacion indica que su calificacion es Excelente.'
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo
