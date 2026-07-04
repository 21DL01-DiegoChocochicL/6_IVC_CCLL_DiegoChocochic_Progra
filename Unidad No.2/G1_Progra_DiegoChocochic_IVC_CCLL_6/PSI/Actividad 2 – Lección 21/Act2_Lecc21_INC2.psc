Algoritmo Act2_Lecc21_INC2
	// Inicio
	Definir n Como Entero
	Escribir 'Bienvenido puede escojer una de estas opciones (1 Ventas, 2 Recepción, 3 Dirección y 4 Compras): '
	Leer n
	// Proceso, Salida y Evaluar
	Si n=1 Entonces
		Escribir 'Bienvenido a Ventas. No podemos atenderte ahora, pero el responsable es Carlos Méndez. Puedes escribirle a ventas@empresa.com o dejar tu mensaje tras el tono. Gracias.'
	SiNo
		Si n=2 Entonces
			Escribir 'Gracias por llamar a Recepción. Para una atención directa, contacta con Lucía Fernández en info@empresa.com, o deja tus datos ahora y te llamaremos pronto.'
			Si n=3 Entonces
				Escribir 'Has comunicado con Dirección. Para asuntos urgentes, contacta con Ricardo Sanz al correo direccion@empresa.com. De lo contrario, deja tu mensaje después de la señal.'
			SiNo
				Si n=4 Entonces
					Escribir 'Bienvenido a Compras. Si eres proveedor, contacta con nuestro responsable, Elena Rivas, en compras@empresa.com. También puedes dejar tu mensaje detallado ahora.'
				SiNo
					Escribir 'Numero no valido'
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo
