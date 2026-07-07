Algoritmo Lecc17_Act_3_Inc2
	//Se tiene una matriz de 4 filas por 4 columnas, en la que se han almacenado 16 datos de tipo entero.
	//Debes determinar y mostrar en que fila y en que columna se encuentra el numero mayor
	
	//Diego Alejandro Chocochic L. IV Bach. CC.LL. Compu. "C" clave:6
	//Encabezado
	Escribir "Diego Chocochic"
	Escribir "IV Bach, CC,LL, Compu, C"
	Escribir "Clave:6"
	Escribir "Ejemplo de una matriz"
	
	Definir fila, colum, mayor, posFila, posColum Como Entero
    Definir tabla Como Entero
    Dimension tabla(4,4)
    
    // ingresar los datos 
    Para fila <- 1 Hasta 4 Hacer
        Para colum <- 1 Hasta 4 Hacer
            Escribir "Ingrese valor para posicion [", fila, ",", colum, "]:"
            Leer tabla(fila, colum)
        FinPara
    FinPara
    
    mayor <- tabla(1,1)
    posFila <- 1
    posColum <- 1
	
	//Filas
    Para fila <- 1 Hasta 4 Hacer
        Para colum <- 1 Hasta 4 Hacer
            Si tabla(fila, colum) > mayor Entonces
                mayor <- tabla(fila, colum)
                posFila <- fila
                posColum <- colum
            FinSi
        FinPara
    FinPara
    
    // Mostrar Datos
    Escribir "El numero mayor es: ", mayor
    Escribir "Se encuentra en la Fila: ", posFila, " y Columna: ", posColum
FinAlgoritmo
