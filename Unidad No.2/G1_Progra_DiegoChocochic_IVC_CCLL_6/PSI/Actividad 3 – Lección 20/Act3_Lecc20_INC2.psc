Algoritmo Act3_Lecc20_INC2
	// Inicio
	Definir n Como Real
	Definir C Como Cadena
	Escribir 'Digame la clase que quiere ver si ha aprovado: '
	Leer C
	Escribir 'Digame su nota: '
	Leer n
	// Proceso, Salida y Evaluar
	Si n>=70 Y n<=100 Entonces
		Escribir C, ', esta clase esta aprovada.'
	SiNo
		Escribir C, ', Esta clase esta reprovada'
	FinSi
FinAlgoritmo
