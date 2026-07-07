Algoritmo Lecc17_Act_2_Inc2
	//Diseña el algoritmo del programa para crear la siguiente matriz y asignar en cada posicion los vaolres
	//que se muestran. Necesitaras ciclos.
	
	//Diego Alejandro Chocochic L. IV Bach. CC.LL. Compu. "C" clave:6
	//Encabezado
	Escribir "Diego Chocochic"
	Escribir "IV Bach, CC,LL, Compu, C"
	Escribir "Clave:6"
	Escribir "Ejemplo de una matriz"
	
	Definir fila, colum Como Entero
    Definir tabla Como Entero
    Dimension tabla(4,4)
    
    // Filas
    Para fila <- 1 Hasta 4 Hacer
        Para colum <- 1 Hasta 4 Hacer
            tabla(fila, colum) <- colum
        FinPara
    FinPara
    
    // Mostrar Datos
    Para fila <- 1 Hasta 4 Hacer
        Para colum <- 1 Hasta 4 Hacer
            Escribir Sin Saltar tabla(fila, colum), " "
        FinPara
        Escribir ""
    FinPara
FinAlgoritmo
