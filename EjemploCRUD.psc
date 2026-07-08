Algoritmo EjemploCRUD	
	Definir Estudiantes Como Cadena
	Definir Op Como Entero
	
	Dimensionar Estudiantes[10,3]
	
	Repetir
		
	Escribir "-----MENU------"
	Escribir "1-Registrar un Estudiante"
	Escribir "1-Mostrar"
	Escribir "3-Actualizar"
	Escribir "4-Eliminar"
	Escribir "5-Salir"
	Escribir "---------------"
	
	Escribir "Diguite una opcion:"
	Leer Op
	
	Segun Op Hacer
		1: 
			Limpiar Pantalla
			Escribir "---Registrar Estudiantes---"
			RegistrarEstudiantes(Estudiantes)
			
		2: 
			Limpiar Pantalla
			Escribir "---Mostrar Estudiantes---"
			MostrarEstudiante(Estudiantes)
			
		3: 
			Limpiar Pantalla
			Escribir "---Actualizar Estudiantes---"
			
		4: 
			Limpiar Pantalla
			Escribir "---Eliminar Estudiantes---"
			EliminarEstudiante(Estudiantes)
			
		5: 
			Limpiar Pantalla
			Escribir "Saliendo del Sitema ..."
			
		De Otro Modo:
			Escribir "Una Opcion valida"
	FinSegun
	
	Hasta Que Op=5 
FinAlgoritmo

//Primer SubProceso 
SubProceso RegistrarEstudiantes(Estudiantes)
	Definir i Como Entero
	Para i=1 Hasta 10 Con Paso 1 Hacer
		si Estudiantes[i,1]=="" Entonces
			Escribir "Diguita el codigo:"
			Leer Estudiantes[i,1]
			Escribir "Diguita el Nombre:"
			Leer Estudiantes[i,2]
			Escribir "Diguita la edad:"
			Leer Estudiantes[i,3]
			Escribir "Datos almacenado con Exito"
		FinSi
	Fin Para
	Limpiar Pantalla
	Escribir "Matriz llena"
FinSubProceso

SubProceso MostrarEstudiante(Estudiantes)
	Definir i Como Entero
	Escribir "Codigo   Nombre   Edad"
	Para i=1 Hasta 10 Con Paso 1 Hacer
		Si Estudiantes[i,1]<>"" Entonces
			Escribir Estudiantes[i,1],"    ",Estudiantes[i,2],"    ",Estudiantes[i,3],"    "
		FinSi
	FinPara
FinSubProceso

SubProceso EliminarEstudiante(Estudiantes)
	Definir i Como Entero
	Definir codigo como Cadena
	
	Escribir "Diguite el codigo del Estudiante que quiere Eliminar:"
	Leer codigo
	
	Para i=1 Hasta 10 Con Paso 1 Hacer
		Si Estudiantes[i,1]==codigo  Entonces
			Estudiantes[i,1]=""
			Estudiantes[i,2]=""
			Estudiantes[i,3]=""
			Escribir "Registro Eliminado"
		Fin Si
	Fin Para
	Escribir "No encontrado"
FinSubProceso
	