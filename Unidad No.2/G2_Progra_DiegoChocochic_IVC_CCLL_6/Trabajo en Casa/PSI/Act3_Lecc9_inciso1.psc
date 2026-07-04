Algoritmo Act3_Lecc9_inciso1
	Definir num1,num2 Como Entero
	
	Escribir "Escriba un numero:"
	Leer num1
	num2=20
	
	Si num1>num2 Entonces
		Mientras num1>=num2 Hacer
			si num1%2 <> 0 Entonces
				Escribir num1
			FinSi
			num1=num1-1
			Fin Mientras
		SiNo
			Mientras num1<=num2 Hacer
				si num1%2 <> 0 Entonces
					Escribir num1
				FinSi
				num1=num1+1
			Fin Mientras
		Fin Si
FinAlgoritmo
