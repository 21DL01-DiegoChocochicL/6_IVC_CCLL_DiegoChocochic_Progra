Algoritmo Lecc17_Act_1_Inc1
	//Define una matriz que represente la siguiente imagen. Define la matriz con el nombre "donas" y luegos asigna un valor 
	//a cada elemento de la matriz con la forma: donas(fila, columna)="sabor"
	
	//Diego Alejandro Chocochic L. IV Bach. CC.LL. Compu. "C" clave:6
	//Encabezado
	Escribir "Diego Chocochic"
	Escribir "IV Bach, CC,LL, Compu, C"
	Escribir "Clave:6"
	Escribir "Ejemplo de una matriz"
	
	Definir donas como Cadena
	Definir fila, columna Como Entero
	Dimensionar donas[2,4]
	
	//Fila 1
	donas[1,1]="Chocolate"
	donas[1,2]="KEKE"
	donas[1,3]="Banano"
	donas[1,4]="Caramelo con cafe"
	//Fila 2
	donas[2,1]="Fresa"
	donas[2,2]="Tiramisu"
	donas[2,3]="Fresas con crema"
	donas[2,4]="Chocolate con fresas"
	
	//Mostrar Datos
	Para fila=1 Hasta 2 Con Paso 1 Hacer
		Para columna=1 Hasta 4 Con Paso 1 Hacer
			Escribir Sin Saltar donas[fila,columna]," | "
		FinPara
		Escribir ()
	FinPara
FinAlgoritmo
