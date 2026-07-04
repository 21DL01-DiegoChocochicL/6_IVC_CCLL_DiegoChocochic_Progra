Algoritmo Act3_Lecc7_INC2
	// Inicio
	Definir L1, L2, L3 Como Real
	Escribir 'Digame los 3 lados del Trangulo: '
	Leer L1
	Leer L2
	Leer L3
	// Proceso, Salida y Evaluar
	Si (L1=L2 Y L1=L3) Entonces
		Escribir 'Los tres lados son Iguales, eso dice que es Equilatero.'
	SiNo
		Si (L1<>L2 Y L1=L3 O L1=L2 Y L1<>L3 O L2=L3) Entonces
			Escribir 'Los dos lados son Iguales, eso dice que es Isosceles.'
		SiNo
			Escribir 'Los tres lados son diferentes, eso dice que es Escaleno.'
		FinSi
	FinSi
FinAlgoritmo
