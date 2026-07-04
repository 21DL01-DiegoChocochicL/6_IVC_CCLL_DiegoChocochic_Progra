Algoritmo Act2_Lecc9_inciso1
	Definir m, f Como Entero
	Definir Level Como Cadena
	
	Escribir "Para Poder subir de nivel debes tener 350 monedas"
	Escribir "Quieres subir al nivel 5?"
	Leer Level
	
	Mientras Level="si" Hacer
		
		Escribir "Cuantas Monedas tienes?"
		Leer m
		
		f=350-m
		
		Si m >= 350  Entonces
			Escribir "Felicidades acabas de subir de nivel!!!"
			level="no"
		SiNo
			Escribir "Te faltan ",f," monedas para poder subir al Nivel 5"
			level="no"
		Fin Si

	Fin Mientras

FinAlgoritmo
