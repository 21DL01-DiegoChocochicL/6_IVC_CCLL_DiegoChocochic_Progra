Algoritmo Act3_Lecc20_INC1
	//Inicio
	Definir num Como Entero
	Escribir 'Escribe un numero (1-7): '
	Leer num
	//Proceso, Salida y Evaluar
	Si num=1 O num=2 O num=3 O num=4 O num=5 Entonces
		Escribir 'Es Entre Semana'
	SiNo
		Si num=6 O num=7 Entonces
			Escribir 'Es Fin de Semana'
		SiNo
			Escribir 'Numero no reconocible'
		FinSi
	FinSi
FinAlgoritmo
