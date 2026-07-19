Algoritmo Lecc35_Act_1_Inc3
	// El usuario elige una opcion (piedra, papel o tijeras) y el programa elige al azar su opcion. El programa muestra
	// que eligio la computadora y quien es el ganador. Al final se invita al usuario a jugar de nuevo
	Escribir 'Diego Chocochic'
	Escribir 'IV Bach, CC,LL, Compu, C'
	Escribir 'Clave:6'
	Escribir 'Piedra, papel o tijeras'
	Definir eleccionUsuario, eleccionCPU Como Entero
	Definir nombreUsuario, nombreCPU, respuesta Como Cadena
	Definir jugarDeNuevo Como Lógico
	Escribir '========================================'
	Escribir '    ¡Juego de Piedra, Papel o Tijeras! '
	Escribir '========================================'
	jugarDeNuevo <- Verdadero
	Mientras jugarDeNuevo Hacer
		Escribir ''
		Escribir 'Elige tu opción:'
		Escribir '1. Piedra'
		Escribir '2. Papel'
		Escribir '3. Tijeras'
		Escribir 'Tu elección (1-3):'
		Leer eleccionUsuario
		Si eleccionUsuario<1 O eleccionUsuario>3 Entonces
			Escribir 'Opción no válida. Inténtalo de nuevo.'
		SiNo
			eleccionCPU <- Azar(3)+1
			Según eleccionUsuario Hacer
				1:
					nombreUsuario <- 'Piedra'
				2:
					nombreUsuario <- 'Papel'
				3:
					nombreUsuario <- 'Tijeras'
			FinSegún
			Según eleccionCPU Hacer
				1:
					nombreCPU <- 'Piedra'
				2:
					nombreCPU <- 'Papel'
				3:
					nombreCPU <- 'Tijeras'
			FinSegún
			Escribir ''
			Escribir 'Tú elegiste: ', nombreUsuario
			Escribir 'La computadora eligió: ', nombreCPU
			Escribir ''
			Si eleccionUsuario=eleccionCPU Entonces
				Escribir '¡Es un empate!'
			SiNo
				Si (eleccionUsuario=1 Y eleccionCPU=3) O (eleccionUsuario=2 Y eleccionCPU=1) O (eleccionUsuario=3 Y eleccionCPU=2) Entonces
					Escribir '¡Felicidades, ganaste!'
				SiNo
					Escribir 'La computadora gana. ¡Sigue intentando!'
				FinSi
			FinSi
			Escribir ''
			Escribir '¿Quieres jugar de nuevo? (s/n):'
			Leer respuesta
			Si respuesta<>'s' Y respuesta<>'S' Entonces
				jugarDeNuevo <- Falso
			FinSi
		FinSi
	FinMientras
	Escribir ''
	Escribir 'Gracias por jugar'
FinAlgoritmo
