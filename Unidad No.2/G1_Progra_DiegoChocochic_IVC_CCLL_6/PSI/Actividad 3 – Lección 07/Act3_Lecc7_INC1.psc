Algoritmo Act3_Lecc7_INC1
	// Inicio
	Definir dia, mes Como Entero
	Definir estacion Como Cadena
	Escribir 'Ingrese el número del día (1-31):'
	Leer dia
	Escribir 'Ingrese el número del mes (1-12):'
	Leer mes
	// Proceso, Salida y evaluar
	Si (mes=1 O mes=2) Entonces
		estacion <- 'Invierno'
	SiNo
		Si (mes=3) Entonces
			Si (dia<21) Entonces
				estacion <- 'Invierno'
			SiNo
				estacion <- 'Primavera'
			FinSi
		SiNo
			Si (mes=4 O mes=5) Entonces
				estacion <- 'Primavera'
			SiNo
				Si (mes=6) Entonces
					Si (dia<21) Entonces
						estacion <- 'Primavera'
					SiNo
						estacion <- 'Verano'
					FinSi
				SiNo
					Si (mes=7 O mes=8) Entonces
						estacion <- 'Verano'
					SiNo
						Si (mes=9) Entonces
							Si (dia<21) Entonces
								estacion <- 'Verano'
							SiNo
								estacion <- 'Otoño'
							FinSi
						SiNo
							Si (mes=10 O mes=11) Entonces
								estacion <- 'Otoño'
							SiNo
								Si (mes=12) Entonces
									Si (dia<21) Entonces
										estacion <- 'Otoño'
									SiNo
										estacion <- 'Invierno'
									FinSi
								SiNo
									Escribir 'La estación no es válido'
								FinSi
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo
