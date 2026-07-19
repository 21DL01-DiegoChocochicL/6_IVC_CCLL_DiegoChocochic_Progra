Algoritmo Lecc33_Act_2_Inc1
	// Crea un programa que inventa la frase que ingrese el usuario. Por ejemplo, al recibir "Hola Mundo",
	// el programa muestra ""
	Escribir 'Diego Chocochic'
	Escribir 'IV Bach, CC,LL, Compu, C'
	Escribir 'Clave:6'
	Escribir 'La Frase Invertida'
	Definir frase, frase_invertida Como Cadena
	Definir i Como Entero
	Escribir 'Ingrese una frase:'
	Leer frase
	frase_invertida <- ''
	Para i<-Longitud(frase) Hasta 1 Con Paso -1 Hacer
		frase_invertida <- frase_invertida+Subcadena(frase,i,i)
	FinPara
	Escribir ''
	Escribir 'Frase invertida: ', frase_invertida
FinAlgoritmo
