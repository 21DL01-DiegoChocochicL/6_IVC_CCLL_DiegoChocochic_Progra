Algoritmo Act1_Lecc21_INC1
	// Inicio
	Definir n Como Entero
	Escribir 'Escribe un numero (1-7)'
	Leer n
	// Proceso ,Salida y Evaluar
	Si n=1 Entonces
		Escribir 'Hoy es Lunes.'
	SiNo
		Si n=2 Entonces
			Escribir 'Hoy es Martes'
		SiNo
			Si n=3 Entonces
				Escribir 'Hoy es Miercoles'
			SiNo
				Si n=4 Entonces
					Escribir 'Hoy es Jueves'
				SiNo
					Si n=5 Entonces
						Escribir 'Hoy es Viernes'
					SiNo
						Si n=6 Entonces
							Escribir 'Hoy es Sabado'
						SiNo
							Si n=7 Entonces
								Escribir 'Hoy es Domingo'
							SiNo
								Escribir 'Numero no valido'
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo
