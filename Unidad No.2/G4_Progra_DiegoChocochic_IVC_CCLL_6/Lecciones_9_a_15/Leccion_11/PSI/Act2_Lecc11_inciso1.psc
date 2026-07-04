Algoritmo Act2_Lecc11_inciso1
	Definir n, factorial, temp Como Entero
	Escribir '*******************************************'
	Escribir '         CALCULADORA DE FACTORIAL          '
	Escribir '*******************************************'
	Escribir 'Ingrese un número para calcular su factorial:'
	Leer n
	factorial <- 1
	temp <- n
	Si n=0 O n=1 Entonces
		Escribir 'Resultado: El factorial de ', n, ' es 1'
	SiNo
		Repetir
			factorial <- factorial*temp
			temp <- temp-1
		Hasta Que temp=1
		Escribir '-------------------------------------------'
		Escribir 'Resultado: El factorial de ', n, ' es ', factorial
	FinSi
	Escribir '*******************************************'
FinAlgoritmo
