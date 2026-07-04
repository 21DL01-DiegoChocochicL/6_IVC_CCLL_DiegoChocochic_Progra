Algoritmo Act2_Lecc10_inciso2
	Definir n, i Como Entero
	Escribir '*******************************************'
	Escribir '      GENERADOR DE SECUENCIA DE PARES      '
	Escribir '*******************************************'
	Escribir 'Ingrese un número mayor o igual a 2:'
	Leer n
	Si n<2 Entonces
		Escribir '>> [ERROR]: El número debe ser mayor o igual a 2.'
	SiNo
		Escribir '-------------------------------------------'
		Escribir 'Números pares del 2 al ', n, ':'
		Para i<-2 Hasta n Con Paso 2 Hacer
			Escribir i
			Esperar Tecla
		FinPara
		Escribir '-------------------------------------------'
		Escribir 'Secuencia completada.'
	FinSi
	Escribir '*******************************************'
FinAlgoritmo
