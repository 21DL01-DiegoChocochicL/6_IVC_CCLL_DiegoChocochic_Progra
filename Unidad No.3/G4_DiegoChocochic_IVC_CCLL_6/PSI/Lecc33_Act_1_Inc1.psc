Algoritmo Lecc33_Act_1_Inc1
	// desarrolla una agenda telefonica deonde guardes el nombre y el telefono de 10 personas. Al ingresar el numero
	// de posicion de la lista, el programa debe mostrar los datos almacenados en esa posicon
	Escribir 'Diego Chocochic'
	Escribir 'IV Bach, CC,LL, Compu, C'
	Escribir 'Clave:6'
	Escribir 'Agenda'
	Dimensionar nombres(10)
	Dimensionar telefonos(10)
	Definir nombres, telefonos Como Cadena
	Definir i, posicion Como Entero
	Definir continuar Como Lógico
	Escribir '--- Registro de la Agenda Telefónica (10 personas) ---'
	Para i<-1 Hasta 10 Con Paso 1 Hacer
		Escribir ''
		Escribir 'Registro #', i, ':'
		Escribir 'Nombre:'
		Leer nombres[i]
		Escribir 'Teléfono:'
		Leer telefonos[i]
	FinPara
	Escribir ''
	Escribir '--- Búsqueda en la Agenda ---'
	continuar <- Verdadero
	Mientras continuar Hacer
		Escribir ''
		Escribir 'Ingrese el número de posición que desea consultar o 0 para salir:'
		Leer posicion
		Si posicion=0 Entonces
			continuar <- Falso
		SiNo
			Si posicion>=1 Y posicion<=10 Entonces
				Escribir ''
				Escribir 'Datos en la posición ', posicion, ':'
				Escribir 'Nombre: ', nombres[posicion]
				Escribir 'Teléfono: ', telefonos[posicion]
			SiNo
				Escribir 'Posición no válida. Debe ingresar un número entre 1 y 10.'
			FinSi
		FinSi
	FinMientras
	Escribir ''
FinAlgoritmo
