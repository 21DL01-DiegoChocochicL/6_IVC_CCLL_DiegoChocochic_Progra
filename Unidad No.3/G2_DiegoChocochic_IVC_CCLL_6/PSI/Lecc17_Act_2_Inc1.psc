Algoritmo Lecc17_Act_2_Inc1
	//Se debe crear la siguiente matriz y asignar en cada posición los valores que se muestran. 
	//Utiliza ciclos y crear el algoritmo para logarlo
	
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
            Si fila == colum Entonces
                tabla(fila, colum) <- 1
            Sino
                tabla(fila, colum) <- 0
            FinSi
        FinPara
    FinPara
    
    //Mostrar Datos
    Para fila <- 1 Hasta 4 Hacer
        Para colum <- 1 Hasta 4 Hacer
            Escribir Sin Saltar tabla(fila, colum), " | "
        FinPara
        Escribir ""
    FinPara
FinAlgoritmo
