Algoritmo Lecc17_Act_3_Inc1
	//Se tiene una matriz de 4 filas por 3 columnas, en la que se han almacenado 12 datos de tipo entero. 
	//Debes calcular y mostrar la suma de los elementos de cada fila
	
	//Diego Alejandro Chocochic L. IV Bach. CC.LL. Compu. "C" clave:6
	//Encabezado
	Escribir "Diego Chocochic"
	Escribir "IV Bach, CC,LL, Compu, C"
	Escribir "Clave:6"
	Escribir "Ejemplo de una matriz"
	
	Definir fila, colum, suma Como Entero
    Definir tabla Como Entero
    Dimension tabla(4,3)
    
    // Filas
    Para fila <- 1 Hasta 4 Hacer
        Para colum <- 1 Hasta 3 Hacer
            Escribir "Ingrese valor para posicion [", fila, ",", colum, "]:"
            Leer tabla(fila, colum)
        FinPara
    FinPara
    
    // Calcular y mostrar datos
    Para fila <- 1 Hasta 4 Hacer
        suma <- 0 
        Para colum <- 1 Hasta 3 Hacer
            suma <- suma + tabla(fila, colum)
        FinPara
        Escribir "La suma de la fila ", fila, " es: ", suma
    FinPara
FinAlgoritmo
